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
import pe.edu.pucp.CrewmanSystem.model.Persona;

public class PedidoMySQL implements PedidoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Pedido pedido){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            con.setAutoCommit(false);
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
                sql ="{ call INSERTAR_LINEAPEDIDO(?,?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_ID_LINEA_PEDIDO", java.sql.Types.INTEGER);
                cs.setDouble("_SUBTOTAL", l.getMontoSubTotal());
                cs.setInt("_ID_PEDIDO", l.getPedido().getIdPedido());
                cs.setInt("_ID_PRODUCTOXZONA", l.getProductoXZona().getIdProductoXZona());
                cs.setInt("_CANTIDAD", l.getCantidad());
                cs.executeUpdate();
                cs.getInt("_ID_LINEA_PEDIDO");
                //subtotal = daoLinea.insertar(l);
                //pedido.setMontoTotal(pedido.getMontoTotal()+subtotal);
            }
            sql ="{ call INSERTAR_TOTAL_PEDIDO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setDouble("_MONTO_TOTAL", pedido.getMontoTotal());
            cs.executeUpdate();
            con.commit();
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
            con.setAutoCommit(false);
            String sql ="{ call ACTUALIZAR_PEDIDO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setString("_DIRECCION_ENTREGA", pedido.getDireccionEntrega());
            resultado = cs.executeUpdate();
            for(LineaPedido lp : pedido.getLineasPedidos()){
                if(lp.getIdLineaPedido() != 0){
                    sql ="{ call ACTUALIZAR_LINEAPEDIDO(?,?)}";
                    cs = con.prepareCall(sql);
                    cs.setInt("_ID_LINEA_PEDIDO", lp.getIdLineaPedido());
                    cs.setInt("_CANTIDAD", lp.getCantidad());
                    resultado=cs.executeUpdate();
                }
                else{
                    Pedido p = new Pedido();
                    p.setIdPedido(pedido.getIdPedido());
                    lp.setPedido(p);
                    sql ="{ call INSERTAR_LINEAPEDIDO(?,?,?,?,?)}";
                    cs = con.prepareCall(sql);
                    cs.registerOutParameter("_ID_LINEA_PEDIDO", java.sql.Types.INTEGER);
                    cs.setDouble("_SUBTOTAL", lp.getMontoSubTotal());
                    cs.setInt("_ID_PEDIDO", lp.getPedido().getIdPedido());
                    cs.setInt("_ID_PRODUCTOXZONA", lp.getProductoXZona().getIdProductoXZona());
                    cs.setInt("_CANTIDAD", lp.getCantidad());
                    cs.executeUpdate();
                }
            }
            sql ="{ call INSERTAR_TOTAL_PEDIDO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setDouble("_MONTO_TOTAL", pedido.getMontoTotal());
            cs.executeUpdate();
            con.commit();
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
    public ArrayList<Pedido>listar(int idVendedor,String razonSocial,String grupo, Date fechaIni, Date fechaFin, String tipoPedido, String estadoPedido)
    {
        EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
        ArrayList<Pedido> pedidos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_PEDIDO (?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_VENDEDOR", idVendedor);
            cs.setString("_RAZON_SOCIAL", razonSocial);
            cs.setString("_GRUPO", grupo);
            cs.setDate("_FECHA_INI", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_FECHA_FIN", new java.sql.Date(fechaFin.getTime()));
            cs.setString("_TIPO_PEDIDO", tipoPedido);
            cs.setString("_ESTADO_PEDIDO", estadoPedido);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                Empleado vendedor = new Empleado();
                Persona persona = new Persona();
                
                pedido.setIdPedido(rs.getInt("ID_PEDIDO"));
                
                cliente.setIdCliente(rs.getInt("ID_CLIENTE"));
                cliente.setRuc(rs.getString("RUC"));
                cliente.setRazonSocial(rs.getString("RAZON_SOCIAL"));
                cliente.setGrupo(rs.getString("GRUPO"));
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                pedido.setCliente(cliente);
                
                vendedor.setIdEmpleado(rs.getInt("ID_EMPLEADO"));
                daoEmpleado.obtenerEmpleado(vendedor);
                pedido.setEmpleado(vendedor);
                
                pedido.setFechaEstim(rs.getDate("FECHA_ESTIMADA"));
                pedido.setFechaAprobado(rs.getDate("FECHA_APROBADO"));
                pedido.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
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
        double total = 0;
        try{
            LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
            ArrayList<LineaPedido> lineas = daoLinea.listar(pedido.getIdPedido());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            con.setAutoCommit(false);
            String sql;
            for(LineaPedido lp : lineas){
                sql ="{ call APROBAR_LINEA(?,?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_SUBTOTAL", java.sql.Types.DOUBLE);
                cs.setInt("_ID_LINEA_PEDIDO", lp.getIdLineaPedido());
                cs.setInt("_ID_PRODUCTOXZONA", lp.getProductoXZona().getIdProductoXZona());
                cs.setInt("_CANTIDAD", lp.getCantidad());
                cs.setDouble("_PRECIO_REAL", lp.getProductoXZona().getPrecioReal());
                resultado = cs.executeUpdate();
                if(resultado==0)return 0;
                total += cs.getDouble("_SUBTOTAL");
            }
            sql ="{ call APROBAR_PEDIDO(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", pedido.getIdPedido());
            cs.setDate("_FECHA_ESTIMADA", new java.sql.Date(pedido.getFechaEstim().getTime()));
            cs.setDate("_FECHA_APROBADO", new java.sql.Date(new Date().getTime()));
            cs.setDouble("_TOTAL", total);
            resultado = cs.executeUpdate();
            con.commit();
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
        ArrayList<Factura> facturas = daoFactura.listarPorPedido(pedido.getIdPedido());
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
    
    @Override
    public int eliminarPedidoEnProceso(int idPedido){
        int resultado = 0;
        try{
            LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
            ArrayList<LineaPedido> lineas = daoLinea.listar(idPedido);
            FacturaDAO daoFactura = new FacturaMySQL();
            ArrayList<Factura> facturas = daoFactura.listarPorPedido(idPedido);
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            con.setAutoCommit(false);
            String sql;
            for(LineaPedido lp : lineas){
                sql ="{ call LIBERAR_LINEA(?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PRODUCTOXZONA", lp.getProductoXZona().getIdProductoXZona());
                cs.setInt("_CANTIDAD", lp.getCantidad());
                cs.setInt("_ID_PROMOCIONXPRODUCTO", lp.getPromocionXProducto().getIdPromocionXProducto());
                cs.setInt("_CANTIDAD_PROMO", lp.getCantidadPromo());
                resultado = cs.executeUpdate();
                if(resultado == 0)return 0;
            }
            for(Factura f : facturas){
                sql ="{ call ELIMINAR_FACTURA (?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_FACTURA", f.getIdFactura());
                resultado=cs.executeUpdate();
                if(resultado == 0)return 0;
                
                sql ="{ call INSERTAR_NOTADECREDITO(?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_ID_NOTA_DE_CREDITO", java.sql.Types.INTEGER);
                cs.setInt("_ID_FACTURA", f.getIdFactura());
                cs.setDate("_FECHA_CREACION", new java.sql.Date(new Date().getTime()));
                cs.setDouble("_MONTO", f.getMonto());
                cs.executeUpdate();
                resultado = cs.getInt("_ID_NOTA_DE_CREDITO");
                if(resultado == 0)return 0;
            }
            sql ="{ call ELIMINAR_PEDIDO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", idPedido);
            resultado=cs.executeUpdate();
            con.commit();
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
    public int entregarPedido(int idPedido){
        int resultado = 0;
        try{
            LineaPedidoDAO daoLinea = new LineaPedidoMySQL();
            ArrayList<LineaPedido> lineas = daoLinea.listar(idPedido);
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            con.setAutoCommit(false);
            String sql;
            for(LineaPedido lp : lineas){
                sql ="{ call ENTREGAR_LINEA(?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PRODUCTOXZONA", lp.getProductoXZona().getIdProductoXZona());
                cs.setInt("_CANTIDAD", lp.getCantidad());
                cs.setInt("_ID_PROMOCIONXPRODUCTO", lp.getPromocionXProducto().getIdPromocionXProducto());
                cs.setInt("_CANTIDAD_PROMO", lp.getCantidadPromo());
                resultado = cs.executeUpdate();
                if(resultado == 0)return 0;
            }
            con.commit();
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
