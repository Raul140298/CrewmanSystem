package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.PromocionXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.PromocionXZona;
import pe.edu.pucp.CrewmanSystem.model.Zona;

public class PromocionXZonaMySQL implements PromocionXZonaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;

    @Override
    public int insertar(PromocionXZona promocionXZona) {
       int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_PROMOCIONXZONA(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PROMOCIONXZONA", java.sql.Types.INTEGER);
            cs.setInt("_ID_PROMOCION", promocionXZona.getPromocion().getIdPromocion());
            cs.setInt("_ID_ZONA", promocionXZona.getZona().getIdZona());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_PROMOCIONXZONA");
            promocionXZona.setIdPromocionXZona(resultado);
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
    public ArrayList<PromocionXZona> listar(int idPromocion) {
        ArrayList<PromocionXZona> promocionesXZona = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_PROMOCIONXZONA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROMOCION", idPromocion);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                PromocionXZona promocionXZona=new PromocionXZona();
                Zona zona = new Zona();
                promocionXZona.setIdPromocionXZona(rs.getInt("ID_PROMOCIONXZONA"));
                
                zona.setIdZona(rs.getInt("ID_ZONA"));
                zona.setNombre(rs.getString("NOMBRE"));
                promocionXZona.setZona(zona);
                
                promocionesXZona.add(promocionXZona);
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
        return promocionesXZona;
    }
}
