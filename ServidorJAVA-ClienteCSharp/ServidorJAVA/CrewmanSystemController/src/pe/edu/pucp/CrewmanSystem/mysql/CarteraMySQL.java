package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.CarteraDAO;
import pe.edu.pucp.CrewmanSystem.model.Cartera;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import pe.edu.pucp.CrewmanSystem.model.Visita;

public class CarteraMySQL implements CarteraDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    PreparedStatement ps;
    
    @Override
    public int actualizar(Cartera cartera) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            con.setAutoCommit(false);
            String sql = "{ call ELIMINAR_CARTERA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CARTERA", cartera.getIdCartera());
            cs.executeUpdate();
                        
            for(Visita v : cartera.getListaVisita()){
                sql ="{ call INSERTAR_CLIENTECARTERA(?,?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_CARTERA", cartera.getIdCartera());
                cs.setInt("_ID_CLIENTE", v.getCliente().getIdCliente());
                cs.setInt("_ID_EMPLEADO", cartera.getEmpleado().getIdEmpleado());
                cs.setDate("_FECHA_REGISTRO", new java.sql.Date(v.getFechaRegistro().getTime()));
                cs.setBoolean("_ESTADO", v.isEstado());
                cs.executeUpdate();
            }
            resultado = 1;
            con.commit();
        }catch(Exception ex){
            try{
                con.rollback();
            }catch(Exception e){
                System.out.println(e.getMessage());
            }
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.setAutoCommit(true);
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
}