package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.GuiaRemisionDAO;
import pe.edu.pucp.CrewmanSystem.model.GuiaRemision;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import pe.edu.pucp.CrewmanSystem.model.EstadoPedido;
import pe.edu.pucp.CrewmanSystem.model.Pedido;
import pe.edu.pucp.CrewmanSystem.model.Persona;
import pe.edu.pucp.CrewmanSystem.model.TipoPedido;

public class GuiaRemisionMySQL implements GuiaRemisionDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(GuiaRemision guiaRemision)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_GUIADEREMISION(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_GUIA_DE_REMISION", java.sql.Types.INTEGER);
            cs.setInt("_ID_PEDIDO", guiaRemision.getPedido().getIdPedido());
            cs.setString("_MOTIVO_TRASLADO", guiaRemision.getMotivoTraslado());
            cs.setDate("_FECHA_REGISTRO", new java.sql.Date(new Date().getTime()));
            cs.setDate("_FECHA_TRASLADO", new java.sql.Date(guiaRemision.getFechaTraslado().getTime()));
            cs.executeUpdate();
            resultado = cs.getInt("_ID_GUIA_DE_REMISION");
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
    public int actualizar(GuiaRemision guiaRemision) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_GUIADEREMISION(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_GUIA_DE_REMISION", guiaRemision.getIdGuiaRemision());
            cs.setString("_MOTIVO", guiaRemision.getMotivoTraslado());
            cs.setDate("_FECHA_TRASLADO", new java.sql.Date(guiaRemision.getFechaTraslado().getTime()));
            
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
    public ArrayList<GuiaRemision>listar(int idVendedor,String razonSocial,String grupo,
            Date fechaInicialRegistro,Date fechaFinRegistro,
            Date fechaInicialTraslado,Date fechaFinTraslado){
        EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
        ArrayList<GuiaRemision> guiaRemisions = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql = "{ call LISTAR_GUIADEREMISION (?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_VENDEDOR",idVendedor);
            cs.setString("_RAZON_SOCIAL", razonSocial);
            cs.setString("_GRUPO", grupo);
            cs.setDate("_FECHA_INICIAL_REGISTRO", new java.sql.Date(fechaInicialRegistro.getTime()));
            cs.setDate("_FECHA_FIN_REGISTRO", new java.sql.Date(fechaFinRegistro.getTime()));
            cs.setDate("_FECHA_INICIAL_TRASLADO", new java.sql.Date(fechaInicialTraslado.getTime()));
            cs.setDate("_FECHA_FIN_TRASLADO", new java.sql.Date(fechaFinTraslado.getTime()));
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                GuiaRemision guiaRemision=new GuiaRemision();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                Empleado vendedor = new Empleado();
                Persona persona = new Persona();
                
                guiaRemision.setIdGuiaRemision(rs.getInt("ID_GUIA_DE_REMISION"));
                
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
                
                guiaRemision.setPedido(pedido);
                guiaRemision.setMotivoTraslado(rs.getString("MOTIVO_TRASLADO"));
                guiaRemision.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
                guiaRemision.setFechaTraslado(rs.getDate("FECHA_TRASLADO"));
                guiaRemisions.add(guiaRemision);
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
        return guiaRemisions;
    }
}
