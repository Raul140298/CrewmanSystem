package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.PersonaContactoDAO;
import pe.edu.pucp.CrewmanSystem.model.PersonaContacto;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import pe.edu.pucp.CrewmanSystem.dao.PersonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Persona;

public class PersonaContactoMySQL implements PersonaContactoDAO{
    Connection con;
    CallableStatement cs;
    PreparedStatement ps;
    ResultSet rs;
    
    @Override
    public int insertar(PersonaContacto personaContacto,int idCliente){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            
            PersonaDAO daoPersona = new PersonaMySQL();
            int idPersona=daoPersona.insertar(personaContacto.obtenerPersona());
            personaContacto.setIdPersona(idPersona);
            
            String sql ="{ call INSERTAR_PERSONACONTACTO(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PERSONA_CONTACTO", java.sql.Types.INTEGER);
            cs.setInt("_ID_PERSONA", idPersona);
            cs.setString("_CARGO", personaContacto.getCargo());
            cs.setInt("_ID_CLIENTE", idCliente);
            cs.executeUpdate();
            resultado=cs.getInt("_ID_PERSONA_CONTACTO");
            personaContacto.setIdPersonaContacto(resultado);
            
            sql = "UPDATE CLIENTE SET ID_PERSONA_CONTACTO = "+resultado+" WHERE ID_CLIENTE = "+idCliente;
            ps = con.prepareStatement(sql);
            rs=ps.executeQuery();
            
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
            resultado = cs.executeUpdate();
            if(resultado==0) return 0;
            
            sql = "SELECT ID_PERSONA FROM PERSONA_CONTACTO WHERE ID_PERSONA_CONTACTO = "+personaContacto.getIdPersonaContacto();
            ps=con.prepareStatement(sql);
            rs=ps.executeQuery();
            rs.next();
            int idPersona = rs.getInt("ID_PERSONA");
            PersonaDAO personaDAO = new PersonaMySQL();
            personaContacto.setIdPersona(idPersona);
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
