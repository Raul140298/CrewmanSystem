package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.LineaCreditoDAO;
import pe.edu.pucp.CrewmanSystem.model.LineaCredito;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.model.Empleado;

public class LineaCreditoMySQL implements LineaCreditoDAO
{
    Connection con;
    CallableStatement cs;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    
    @Override
    public int insertar(LineaCredito lineaCredito){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_LINEADECREDITO(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_LINEA_DE_CREDITO", java.sql.Types.INTEGER);
            cs.setInt("_ID_CLIENTE", lineaCredito.getCliente().getIdCliente());
            cs.setDouble("_MONTO", lineaCredito.getMontoLineaCredito());
            cs.setInt("_ID_RESPONSABLE", lineaCredito.getResponsable().getIdEmpleado());
            cs.setDate("_FECHA_CREACION", new java.sql.Date(new Date().getTime()));
            cs.setDouble("_MONTO_UTILIZADO", lineaCredito.getMontoUtilizado());
            cs.setBoolean("_APROBADO", lineaCredito.getAprobado());
            cs.setString("_MOTIVO", lineaCredito.getMotivo());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_LINEA_DE_CREDITO");
            lineaCredito.setIdLineaCredito(resultado);
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
    public int actualizar(LineaCredito lineaCredito)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_LINEA_DE_CREDITO(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEA_DE_CREDITO", lineaCredito.getIdLineaCredito());
            cs.setDouble("_MONTO", lineaCredito.getMontoLineaCredito());
            cs.setDouble("_MONTO_UTILIZADO", lineaCredito.getMontoUtilizado());
            cs.setBoolean("_APROBADO", lineaCredito.getAprobado());
            cs.setString("_MOTIVO", lineaCredito.getMotivo());
            
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
    public LineaCredito mostrar(int idLineaCredito) {
        LineaCredito lineaCredito = new LineaCredito();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_LINEACREDITO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEA_DE_CREDITO", idLineaCredito);
            cs.executeUpdate();
            rs = cs.getResultSet();
            rs.next();
            lineaCredito.setIdLineaCredito(rs.getInt("ID_LINEA_DE_CREDITO"));
            Empleado responsable=new Empleado();
            responsable.setIdEmpleado(rs.getInt("ID_RESPONSABLE"));
            responsable.setNombre(rs.getString("R_NOMBRE"));
            responsable.setApellidoPaterno(rs.getString("R_APELLIDO_PATERNO"));
            responsable.setApellidoMaterno(rs.getString("R_APELLIDO_MATERNO"));
            lineaCredito.setResponsable(responsable);
            lineaCredito.setFechaCreacion(rs.getDate("FECHA_CREACION"));
            lineaCredito.setMontoLineaCredito(rs.getDouble("MONTO"));
            lineaCredito.setMontoUtilizado(rs.getDouble("MONTO_UTILIZADO"));
            lineaCredito.setMotivo(rs.getString("MOTIVO"));
            lineaCredito.setAprobado(rs.getBoolean("APROBADO"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineaCredito;
    }
}
