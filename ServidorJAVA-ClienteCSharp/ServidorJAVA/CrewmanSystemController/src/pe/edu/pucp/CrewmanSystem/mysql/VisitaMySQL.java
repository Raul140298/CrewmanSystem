package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ClienteDAO;
import pe.edu.pucp.CrewmanSystem.dao.VisitaDAO;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import pe.edu.pucp.CrewmanSystem.model.Visita;

public class VisitaMySQL implements VisitaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Visita visita)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_VISITA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_VISITA", java.sql.Types.INTEGER);
            cs.setInt("_ID_CLIENTE", visita.getCliente().getIdCliente());
            cs.setInt("_ID_EMPLEADO", visita.getEmpleado().getIdEmpleado());
            cs.setInt("_ID_CARTERA", visita.getCartera().getIdCartera());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_VISITA");
            visita.setIdVisita(resultado);
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
    public int actualizar(Visita visita)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_VISITA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_VISITA", visita.getIdVisita());
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
    public ArrayList<Visita> listar(Empleado empleado) {
        ArrayList<Visita> visitas = new ArrayList<>();
        ClienteDAO daoCliente = new ClienteMySQL();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_VISITAS_POR_VENDEDOR (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADO", empleado.getIdEmpleado());
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Visita visita = new Visita();
                visita.setIdVisita(rs.getInt("ID_VISITA"));
                visita.getCliente().setIdCliente(rs.getInt("ID_CLIENTE"));
                visita.getCliente().setRuc(rs.getString("RUC"));
                visita.getCliente().setRazonSocial(rs.getString("RAZON_SOCIAL"));
                visita.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
                visita.setEstado(rs.getBoolean("ESTADO"));
                
                visitas.add(visita);
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
        return visitas;
    }
}
