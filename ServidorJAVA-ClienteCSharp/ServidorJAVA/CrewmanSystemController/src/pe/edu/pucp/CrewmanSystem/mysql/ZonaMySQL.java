package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Zona;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.Empleado;

public class ZonaMySQL implements ZonaDAO
{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Zona zona){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_ZONA(?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_ZONA", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", zona.getNombre());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_ZONA");
            zona.setIdZona(resultado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Zona zona){
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_ZONA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ZONA", zona.getIdZona());
            cs.setString("_NOMBRE", zona.getNombre());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idZona){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_ZONA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ZONA", idZona);
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
    public ArrayList<Zona>listar(){
        ArrayList<Zona> zonas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_ZONA ()}";
            cs = con.prepareCall(sql);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Zona zona=new Zona();
                zona.setIdZona(rs.getInt("ID_ZONA"));
                zona.setNombre(rs.getString("NOMBRE"));
                zona.setActivo(rs.getBoolean("ACTIVO"));
                zonas.add(zona);
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
        return zonas;
    }   

    @Override
    public Zona mostrar(int idEmpleado) {
        int resultado = 0;
        Zona zona = new Zona();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_ZONA_DE_EMPLEADO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADO", idEmpleado);
            resultado = cs.executeUpdate();
            if(resultado==0)return null;
            rs = cs.getResultSet();
            rs.next();
            zona.setIdZona(rs.getInt("ID_ZONA"));
            zona.setNombre(rs.getString("NOMBRE"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return zona;
    }
    
    public Zona mostrarZonaCliente(int idCliente) {
        int resultado = 0;
        Zona zona = new Zona();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_ZONA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CLIENTE", idCliente);
            resultado = cs.executeUpdate();
            if(resultado==0)return null;
            rs = cs.getResultSet();
            rs.next();
            zona.setIdZona(rs.getInt("ID_ZONA"));
            zona.setNombre(rs.getString("NOMBRE"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return zona;
    }
}
