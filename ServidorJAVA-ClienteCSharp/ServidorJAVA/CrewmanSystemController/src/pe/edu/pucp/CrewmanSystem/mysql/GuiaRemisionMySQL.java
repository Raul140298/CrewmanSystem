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
import pe.edu.pucp.CrewmanSystem.model.Pedido;

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
    public ArrayList<GuiaRemision>listar(int idPedido)
    {
        ArrayList<GuiaRemision> guiaRemisions = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql = "{ call LISTAR_GUIADEREMISION (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO",idPedido);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                GuiaRemision guiaRemision=new GuiaRemision();
                guiaRemision.setIdGuiaRemision(rs.getInt("ID_GUIA_DE_REMISION"));
                Pedido p=new Pedido();
                p.setIdPedido(rs.getInt("ID_PEDIDO"));
                guiaRemision.setPedido(p);
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

    @Override
    public ArrayList<GuiaRemision> listarPorVendedor(int idVendedor) {
        ArrayList<GuiaRemision> guiaRemisions = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql = "{ call LISTAR_GUIADEREMISION_X_VENDEDOR (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_VENDEDOR",idVendedor);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                GuiaRemision guiaRemision=new GuiaRemision();
                guiaRemision.setIdGuiaRemision(rs.getInt("ID_GUIA_DE_REMISION"));
                Pedido p=new Pedido();
                p.setIdPedido(rs.getInt("ID_PEDIDO"));
                guiaRemision.setPedido(p);
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
