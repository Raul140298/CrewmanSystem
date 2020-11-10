package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ClienteXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.ClienteXZona;

public class ClienteXZonaMySQL implements ClienteXZonaDAO{
    Connection con;
    CallableStatement cs;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    
    @Override
    public int insertar(ClienteXZona clienteXZona) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_CLIENTEXZONA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_CLIENTEXZONA", java.sql.Types.INTEGER);
            cs.setInt("_ID_CLIENTE", clienteXZona.getCliente().getIdCliente());
            cs.setInt("_ID_ZONA", clienteXZona.getZona().getIdZona());
            cs.setDate("_FECHA_INICIO", new java.sql.Date(new Date().getTime()));
            cs.executeUpdate();
            resultado = cs.getInt("_ID_CLIENTEXZONA");
            clienteXZona.setIdClienteXZona(resultado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idClienteXZona) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_CLIENTEXZONA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CLIENTEXZONA", idClienteXZona);
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
    public ArrayList<ClienteXZona> obtenerClientePorZona(int idZona){
        return null;
    }
}
