package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.PersonaContactoDAO;
import pe.edu.pucp.CrewmanSystem.model.PersonaContacto;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import pe.edu.pucp.CrewmanSystem.dao.PersonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Persona;

public class PersonaContactoMySQL implements PersonaContactoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(PersonaContacto personaContacto){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_PERSONACONTACTO(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PERSONA_CONTACTO", java.sql.Types.INTEGER);
            cs.setInt("_ID_PERSONA", personaContacto.getIdPersona());
            cs.setString("_CARGO", personaContacto.getCargo());
            cs.setInt("_ID_CLIENTE", personaContacto.getCliente().getIdCliente());
            cs.executeUpdate();
            resultado=cs.getInt("_ID_PERSONA_CONTACTO");
            personaContacto.setIdPersonaContacto(resultado);
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
    public int actualizar(PersonaContacto personaContacto){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql = "{ call ACTUALIZAR_PERSONACONTACTO(?,?) }";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA_CONTACTO",personaContacto.getIdPersonaContacto());
            cs.setString("_CARGO",personaContacto.getCargo());
            cs.executeUpdate();
            
            PersonaDAO personaDAO = new PersonaMySQL();
            resultado=personaDAO.actualizar(personaContacto.obtenerPersona());
            
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
    public int eliminar(int idPersonaContacto){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_PERSONACONTACTO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_DNI", idPersonaContacto);
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
    public PersonaContacto mostrar(int idPersonaContacto) {
        PersonaContacto personaContacto=new PersonaContacto();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_PERSONACONTACTO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA_CONTACTO", idPersonaContacto);
            cs.executeUpdate();
            rs=cs.getResultSet();
            rs.next();
            personaContacto.setIdPersonaContacto(rs.getInt("ID_PERSONA_CONTACTO"));
            personaContacto.setIdPersona(rs.getInt("ID_PERSONA"));
            personaContacto.setCargo(rs.getString("CARGO"));
            
            PersonaDAO daoPersona = new PersonaMySQL();
            Persona persona=daoPersona.mostrar(personaContacto.getIdPersona());
            
            personaContacto.asignarPersona(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return personaContacto;
    }
}
