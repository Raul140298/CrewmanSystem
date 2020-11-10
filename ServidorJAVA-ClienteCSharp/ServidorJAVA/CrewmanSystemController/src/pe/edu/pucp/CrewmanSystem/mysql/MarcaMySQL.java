package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.MarcaDAO;
import pe.edu.pucp.CrewmanSystem.model.Marca;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

public class MarcaMySQL implements MarcaDAO
{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Marca marca){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_MARCA(?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_MARCA", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", marca.getNombre());
            cs.executeUpdate();
            resultado=cs.getInt("_ID_MARCA");
            marca.setIdMarca(resultado);
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
    public int actualizar(Marca marca){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_MARCA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MARCA", marca.getIdMarca());
            cs.setString("_NOMBRE", marca.getNombre());
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
    public int eliminar(int idMarca){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_MARCA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MARCA", idMarca);
            resultado = cs.executeUpdate();;
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
    public ArrayList<Marca>listar(){
        ArrayList<Marca> marcas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_MARCA ()}";
            cs = con.prepareCall(sql);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Marca marca=new Marca();
                marca.setIdMarca(rs.getInt("ID_MARCA"));
                marca.setNombre(rs.getString("NOMBRE"));
                marca.setActivo(rs.getBoolean("ACTIVO"));
                marcas.add(marca);
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
        return marcas;
    }
}
