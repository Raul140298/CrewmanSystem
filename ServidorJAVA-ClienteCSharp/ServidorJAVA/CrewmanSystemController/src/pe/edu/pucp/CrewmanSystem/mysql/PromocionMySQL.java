package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.PromocionDAO;
import pe.edu.pucp.CrewmanSystem.model.Promocion;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.dao.PromocionXProductoDAO;
import pe.edu.pucp.CrewmanSystem.model.PromocionXProducto;

public class PromocionMySQL implements PromocionDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Promocion promocion)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_PROMOCION(?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PROMOCION", java.sql.Types.INTEGER);
            cs.setInt("_ID_ZONA", promocion.getZona().getIdZona());
            cs.setString("_NOMBRE", promocion.getNombre());
            cs.setString("_DESCRIPCION", promocion.getDescripcion());
            cs.setDate("_FECHA_INICIO", new java.sql.Date(promocion.getFechaInicio().getTime()));
            cs.setDate("_FECHA_FIN", new java.sql.Date(promocion.getFechaFin().getTime()));
            cs.executeUpdate();
            resultado = cs.getInt("_ID_PROMOCION");
            promocion.setIdPromocion(resultado);
                        
            PromocionXProductoDAO daoPromocionXProducto = new PromocionXProductoMySQL();
            for(PromocionXProducto pxp : promocion.getListaPromocionXProducto()){
                pxp.getPromocion().setIdPromocion(resultado);
                daoPromocionXProducto.insertar(pxp);
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
    public int actualizar(Promocion promocion)
    {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_PROMOCION(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROMOCION", promocion.getIdPromocion());
            cs.setString("_NOMBRE", promocion.getNombre());
            cs.setString("_DESCRIPCION", promocion.getDescripcion());
            cs.setDate("_FECHA_FIN", new java.sql.Date(promocion.getFechaFin().getTime()));
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idPromocion){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_PROMOCION (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROMOCION", idPromocion);
            cs.executeUpdate();
            resultado = 1;
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
    public ArrayList<Promocion>listar(String nombre,Date fechaIni,Date fechaFin){
        ArrayList<Promocion> promocions = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_PROMOCION (?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setString("_NOMBRE", nombre);
            cs.setDate("_FECHA_INICIO", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_FECHA_FIN", new java.sql.Date(fechaFin.getTime()));
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Promocion promocion=new Promocion();
                promocion.setIdPromocion(rs.getInt("ID_PROMOCION"));
                promocion.setNombre(rs.getString("NOMBRE"));
                promocion.setDescripcion(rs.getString("DESCRIPCION"));
                promocion.setFechaInicio(rs.getDate("FECHA_INICIO"));
                promocion.setFechaFin(rs.getDate("FECHA_FIN"));
                promocions.add(promocion);
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
        return promocions;
    }
    
}