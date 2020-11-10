package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.EmpleadoXZona;

public class EmpleadoXZonaMySQL implements EmpleadoXZonaDAO{
    Connection con;
    CallableStatement cs;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    
    @Override
    public int insertar(EmpleadoXZona empleadoXZona) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_EMPLEADOXZONA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_EMPLEADOXZONA", java.sql.Types.INTEGER);
            cs.setInt("_ID_EMPLEADO", empleadoXZona.getEmpleado().getIdEmpleado());
            cs.setInt("_ID_ZONA", empleadoXZona.getZona().getIdZona());
            cs.setDate("_FECHA_INICIO", new java.sql.Date(new Date().getTime()));
            cs.executeUpdate();
            resultado = cs.getInt("_ID_EMPLEADOXZONA");
            empleadoXZona.setIdVendedorXZona(resultado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idEmpleadoXZona) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_EMPLEADOXZONA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADOXZONA", idEmpleadoXZona);
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
}
