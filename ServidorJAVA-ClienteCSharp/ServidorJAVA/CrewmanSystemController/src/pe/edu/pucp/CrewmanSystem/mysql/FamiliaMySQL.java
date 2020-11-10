package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.FamiliaDAO;
import pe.edu.pucp.CrewmanSystem.model.Familia;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

public class FamiliaMySQL implements FamiliaDAO
{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Familia familia){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_FAMILIA(?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_FAMILIA", java.sql.Types.INTEGER);
            cs.setString("_DESCRIPCION", familia.getDescripcion());
            cs.executeUpdate();
            resultado=cs.getInt("_ID_FAMILIA");
            familia.setIdFamilia(resultado);
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
    public int actualizar(Familia familia){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_FAMILIA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_FAMILIA", familia.getIdFamilia());
            cs.setString("_DESCRIPCION", familia.getDescripcion());
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
    public int eliminar(int idFamilia){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_FAMILIA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_FAMILIA", idFamilia);
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
    public ArrayList<Familia>listar(){
        ArrayList<Familia> familias = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_FAMILIA ()}";
            cs = con.prepareCall(sql);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Familia familia=new Familia();
                familia.setIdFamilia(rs.getInt("ID_FAMILIA"));
                familia.setDescripcion(rs.getString("DESCRIPCION"));
                familia.setActivo(rs.getBoolean("ACTIVO"));
                familias.add(familia);
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
        return familias;
    } 
}
