package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.PedidoDAO;
import pe.edu.pucp.CrewmanSystem.model.Pedido;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.dao.ClienteDAO;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoDAO;
import pe.edu.pucp.CrewmanSystem.dao.FacturaDAO;
import pe.edu.pucp.CrewmanSystem.dao.LineaPedidoDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.model.EstadoPedido;
import pe.edu.pucp.CrewmanSystem.model.LineaPedido;
import pe.edu.pucp.CrewmanSystem.model.TipoPedido;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import pe.edu.pucp.CrewmanSystem.model.Factura;

public class PedidoMySQL implements PedidoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Pedido pedido){
        int resultado = 0;
        double subtotal = 0;
        PedidoDAO daoPedido = new PedidoMySQL();
        LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_BORRADOR(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PEDIDO", java.sql.Types.INTEGER);
            cs.setInt("_ID_CLIENTE", pedido.getCliente().getIdCliente());
            cs.setInt("_ID_EMPLEADO", pedido.getEmpleado().getIdEmpleado());
            cs.setDate("_FECHA_REGISTRO", new java.sql.Date(new Date().getTime()));
            cs.setString("_DIRECCION_ENTREGA", pedido.getDireccionEntrega());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_PEDIDO");
            pedido.setIdPedido(resultado);
            
            for(LineaPedido l : pedido.getLineasPedidos()){
                l.setPedido(pedido);
                subtotal = daoLinea.insertar(l);
                pedido.setMontoTotal(pedido.getMontoTotal()+subtotal);
            }
            daoPedido.insertarTotal(pedido);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Pedido pedido)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_PEDIDO(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setInt("_ID_CLIENTE", pedido.getCliente().getIdCliente());
            cs.setInt("_ID_EMPLEADO", pedido.getEmpleado().getIdEmpleado());
            cs.setString("_DIRECCION_ENTREGA", pedido.getDireccionEntrega());
            resultado = cs.executeUpdate();
            
            LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
            for(LineaPedido lp : pedido.getLineasPedidos()){
                if(lp.getIdLineaPedido() != 0){
                    daoLinea.actualizar(lp);
                }
                else{
                    daoLinea.insertar(lp);
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idPedido)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_PEDIDO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", idPedido);
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public ArrayList<Pedido>listar()
    {
        ArrayList<Pedido> pedidos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_PEDIDO ()}";
            cs = con.prepareCall(sql);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Pedido pedido=new Pedido();
                Cliente cliente=new Cliente();
                Empleado vendedor=new Empleado();
                
                pedido.setIdPedido(rs.getInt("ID_PEDIDO"));
                
                cliente.setIdCliente(rs.getInt("ID_CLIENTE"));
                pedido.setCliente(cliente);
                
                vendedor.setIdEmpleado(rs.getInt("ID_EMPLEADO"));
                pedido.setEmpleado(vendedor);
                
                pedido.setFechaEstim(rs.getDate("FECHA_ESTIMADA"));
                pedido.setFechaRegistro(rs.getDate("FECHA_APROBADO"));
                pedido.setFechaAprobado(rs.getDate("FECHA_REGISTRO"));
                pedido.setMontoTotal(rs.getDouble("MONTO_TOTAL"));
                pedido.setMontoPagar(rs.getDouble("MONTO_PAGAR"));
                pedido.setDireccionEntrega(rs.getString("DIRECCION_ENTREGA"));
                pedido.setTipoPedido(TipoPedido.valueOf(rs.getString("TIPO_PEDIDO")));
                pedido.setEstadoPedido(EstadoPedido.valueOf(rs.getString("ESTADO_PEDIDO")));
                pedidos.add(pedido);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                rs.close();
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return pedidos;
    }

    @Override
    public ArrayList<Pedido> generarReporte(String idPedido) {
        ArrayList<Pedido> eae=new ArrayList<>();
        return eae;
    }

    @Override
    public int insertarTotal(Pedido pedido){
        int resultado = 0;
        LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_TOTAL_PEDIDO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setDouble("_MONTO_TOTAL", pedido.getMontoTotal());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public void mostrar(Pedido pedido) {
        if(pedido.getCliente().getIdCliente()>0){
            ClienteDAO daoCliente = new ClienteMySQL();
            pedido.setCliente(daoCliente.obtenerCliente(pedido.getCliente().getIdCliente()));
        }
        if(pedido.getEmpleado().getIdEmpleado()>0){
            EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
            daoEmpleado.obtenerEmpleado(pedido.getEmpleado());
        }
    }
    
    @Override
    public int aprobarBorrador(Pedido pedido) {
        int resultado = 0;
        boolean reserva = false;
        LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call APROBAR_BORRADOR(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ERROR", java.sql.Types.BOOLEAN);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setDate("_FECHA_ESTIMADA", new java.sql.Date(pedido.getFechaEstim().getTime()));
            cs.setDate("_FECHA_APROBADO", new java.sql.Date(new Date().getTime()));
            resultado = cs.executeUpdate();
            reserva = cs.getBoolean("_ERROR");
            if(reserva){
                System.out.println("no hay suficiente stock");
                return resultado;
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public int obtenerPedido(Pedido pedido){
        int resultado = 0;
        LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call GET_PEDIDO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            resultado = cs.executeUpdate();
            rs = cs.getResultSet();
            rs.next();
            pedido.getCliente().setIdCliente(rs.getInt("ID_CLIENTE"));
            pedido.getEmpleado().setIdEmpleado(rs.getInt("ID_EMPLEADO"));
            pedido.setFechaEstim(rs.getDate("FECHA_ESTIMADA"));
            pedido.setFechaAprobado(rs.getDate("FECHA_APROBADO"));
            pedido.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
            pedido.setMontoTotal(rs.getDouble("MONTO_TOTAL"));
            pedido.setMontoPagar(rs.getDouble("MONTO_PAGAR"));
            pedido.setDireccionEntrega(rs.getString("DIRECCION_ENTREGA"));
            pedido.setTipoPedido(TipoPedido.valueOf(rs.getString("TIPO_PEDIDO")));
            pedido.setEstadoPedido(EstadoPedido.valueOf(rs.getString("ESTADO_PEDIDO")));
            
            LineaPedidoDAO daoLineas = new LineaPedidoMySQL();
            ArrayList<LineaPedido> lineas = daoLineas.listar(pedido.getIdPedido());
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public void anular(Pedido pedido){
        PedidoDAO daoPedido = new PedidoMySQL();
        daoPedido.liberarStock(pedido);
        daoPedido.eliminar(pedido.getIdPedido());
        FacturaDAO daoFactura = new FacturaMySQL();
        ArrayList<Factura> facturas = daoFactura.listar(pedido.getIdPedido());
        for(Factura f : facturas){
            daoFactura.eliminar(f);
        }
    }
    
    @Override
    public int liberarStock(Pedido pedido){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LIBERAR_STOCK(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public int culminarPedido(Pedido pedido){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call CULMINAR_PEDIDO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
}
