package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.QuejaDAO;
import pe.edu.pucp.CrewmanSystem.model.Queja;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import pe.edu.pucp.CrewmanSystem.model.EstadoPedido;
import pe.edu.pucp.CrewmanSystem.model.Pedido;
import pe.edu.pucp.CrewmanSystem.model.Persona;
import pe.edu.pucp.CrewmanSystem.model.TipoPedido;

public class QuejaMySQL implements QuejaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Queja queja){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_QUEJA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_QUEJA", java.sql.Types.INTEGER);
            cs.setInt("_ID_PEDIDO", queja.getPedido().getIdPedido());
            cs.setString("_DESCRIPCION",queja.getDescripcion());
            cs.setDate("_FECHA_CREACION", new java.sql.Date(queja.getFechaCreacion().getTime()));
            cs.executeUpdate();
            resultado = cs.getInt("_ID_QUEJA");
            queja.setIdQueja(resultado);
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
    public int actualizar(Queja queja){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_QUEJA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_QUEJA", queja.getIdQueja());
            cs.setString("_DESCRIPCION",queja.getDescripcion());
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
    public int eliminar(int idQueja){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_QUEJA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_QUEJA", idQueja);
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
    public ArrayList<Queja>listar(int idVendedor)
    {
        EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
        ArrayList<Queja> quejas = new ArrayList<>();
        try{    
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_QUEJA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_VENDEDOR", idVendedor);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Queja queja = new Queja();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                Empleado vendedor = new Empleado();
                Persona persona = new Persona();
                
                queja.setIdQueja(rs.getInt("ID_QUEJA"));
                
                pedido.setIdPedido(rs.getInt("ID_PEDIDO"));
                pedido.setMontoTotal(rs.getDouble("MONTO_TOTAL"));
                pedido.setMontoPagar(rs.getDouble("MONTO_PAGAR"));
                pedido.setTipoPedido(TipoPedido.valueOf(rs.getString("TIPO_PEDIDO")));
                pedido.setEstadoPedido(EstadoPedido.valueOf(rs.getString("ESTADO_PEDIDO")));
                
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
                
                queja.setPedido(pedido);
                queja.setDescripcion(rs.getString("DESCRIPCION"));
                queja.setFechaCreacion(rs.getDate("FECHA_CREACION"));
                quejas.add(queja);
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
        return quejas;
    }
}