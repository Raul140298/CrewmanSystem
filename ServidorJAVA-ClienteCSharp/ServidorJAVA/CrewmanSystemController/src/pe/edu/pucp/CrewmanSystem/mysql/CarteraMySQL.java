package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.CarteraDAO;
import pe.edu.pucp.CrewmanSystem.model.Cartera;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.dao.VisitaDAO;
import pe.edu.pucp.CrewmanSystem.model.Visita;

public class CarteraMySQL implements CarteraDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    PreparedStatement ps;
    
    @Override
    public int insertar(Cartera cartera){
        int resultado = 0;
        int idCartera;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_CARTERA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_CARTERA", java.sql.Types.INTEGER);
            cs.setInt("_ID_EMPLEADO", cartera.getEmpleado().getIdEmpleado());
            cs.setDate("_FECHA_INICIO", new java.sql.Date(new Date().getTime()));
            cs.setDate("_FECHA_FIN", new java.sql.Date(cartera.getFechaFin().getTime()));
            cs.executeUpdate();
            idCartera = cs.getInt("_ID_CARTERA");
            cartera.setIdCartera(idCartera);
            cs.close();
            
            for(Visita v : cartera.getListaVisita()){
                v.setCartera(cartera);
                v.setEmpleado(cartera.getEmpleado());
                
                sql ="{ call INSERTAR_CLIENTECARTERA(?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_CLIENTE", v.getCliente().getIdCliente());
                cs.setInt("_ID_CARTERA", idCartera);
                cs.executeUpdate();
                
                VisitaDAO daoVisita = new VisitaMySQL(); 
                resultado = daoVisita.insertar(v);
                v.setIdVisita(resultado);
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
        return resultado;
    }

    @Override
    public int actualizar(Cartera cartera) {
        int resultado=0;
        CarteraDAO daoCartera = new CarteraMySQL();
        try{
            daoCartera.eliminar(cartera.getIdCartera());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_CARTERA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CARTERA", cartera.getIdCartera());
            cs.setDate("_FECHA_FIN", new java.sql.Date(cartera.getFechaFin().getTime()));
            resultado=cs.executeUpdate();
            
            for(Visita v : cartera.getListaVisita()){
                sql ="{ call INSERTAR_CLIENTECARTERA(?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_CLIENTE", v.getCliente().getIdCliente());
                cs.setInt("_ID_CARTERA", cartera.getIdCartera());
                cs.executeUpdate();
                
                v.setCartera(cartera);
                v.setEmpleado(cartera.getEmpleado());
                
                
                VisitaDAO daoVisita = new VisitaMySQL(); 
                if(v.getIdVisita()==0){
                    resultado = daoVisita.insertar(v);
                    v.setIdVisita(resultado);
                }
                else{
                    resultado = daoVisita.actualizar(v);
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idCartera) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_CARTERA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CARTERA", idCartera);
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
}