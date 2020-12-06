package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.PersonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Persona;

public class PersonaMySQL implements PersonaDAO{
    Connection con;    
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Persona persona) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_PERSONA(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PERSONA", java.sql.Types.INTEGER);
            cs.setString("_DNI", persona.getDni());
            cs.setString("_NOMBRE", persona.getNombre());
            cs.setString("_APELLIDO_PATERNO", persona.getApellidoPaterno());
            cs.setString("_APELLIDO_MATERNO", persona.getApellidoMaterno());
            cs.setString("_TELEFONO1", persona.getTelefono1());
            cs.setString("_TELEFONO2", persona.getTelefono2());
            cs.setString("_CORREO", persona.getCorreo());
            cs.setString("_GENERO", String.valueOf(persona.getGenero()));
            cs.setBytes("_FOTO", persona.getFoto());
            cs.executeUpdate();
            resultado=cs.getInt("_ID_PERSONA");
            persona.setIdPersona(resultado);
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
    public int actualizar(Persona persona) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_PERSONA(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA", persona.getIdPersona());
            cs.setString("_NOMBRE", persona.getNombre());
            cs.setString("_APELLIDO_PATERNO", persona.getApellidoPaterno());
            cs.setString("_APELLIDO_MATERNO", persona.getApellidoMaterno());
            cs.setString("_TELEFONO1", persona.getTelefono1());
            cs.setString("_TELEFONO2", persona.getTelefono2());
            cs.setString("_CORREO", persona.getCorreo());
            cs.setString("_GENERO", String.valueOf(persona.getGenero()));
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
    public int eliminar(int idPersona) {        
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_PERSONA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA", idPersona);
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
    public Persona mostrar(int idPersona) {
        Persona persona=new Persona();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_PERSONA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA", idPersona);
            cs.executeUpdate();
            rs=cs.getResultSet();
            rs.next();
            persona.setIdPersona(rs.getInt("ID_PERSONA"));
            persona.setDni(rs.getString("DNI"));
            persona.setNombre(rs.getString("NOMBRE"));
            persona.setApellidoPaterno(rs.getString("APELLIDO_PATERNO"));
            persona.setApellidoMaterno(rs.getString("APELLIDO_MATERNO"));
            persona.setTelefono1(rs.getString("TELEFONO1"));
            persona.setTelefono2(rs.getString("TELEFONO2"));
            persona.setCorreo(rs.getString("CORREO"));
            persona.setGenero(rs.getString("GENERO").charAt(0));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return persona;
    }
}
