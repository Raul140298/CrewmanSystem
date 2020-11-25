package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.VisitaDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.model.Visita;
import pe.edu.pucp.CrewmanSystem.model.Zona;

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
    public ArrayList<Visita> listar(int idCartera) {
        ArrayList<Visita> visitas = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_CLIENTES_POR_CARTERA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CARTERA", idCartera);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Visita visita = new Visita();
                Cliente cliente = new Cliente();
                Zona zona = new Zona();
                
                visita.setIdVisita(rs.getInt("ID_VISITA"));
                
                cliente.setIdCliente(rs.getInt("ID_CLIENTE"));
                entero=rs.getInt("ID_LINEA_DE_CREDITO");
                if(entero!=null) cliente.getLineaCredito().setIdLineaCredito(entero.intValue());
                entero=rs.getInt("ID_PERSONA_CONTACTO");
                if(entero!=null) cliente.getPersonaContacto().setIdPersonaContacto(entero.intValue());
                entero=rs.getInt("ID_CARTERA");
                if(entero!=null) cliente.getCartera().setIdCartera(entero.intValue());
                cliente.setRuc(rs.getString("RUC"));
                cliente.setRazonSocial(rs.getString("RAZON_SOCIAL"));
                cliente.setGrupo(rs.getString("GRUPO"));
                cliente.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
                cliente.setFechaUltimaCompra(rs.getDate("FECHA_ULTIMA_COMPRA"));
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                
                zona.setIdZona(rs.getInt("ID_ZONA"));
                zona.setNombre(rs.getString("ZONA"));
                cliente.setZona(zona);
                visita.setCliente(cliente);
                
                visita.setFechaRegistro(rs.getDate("FECHA_VISITA"));
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

    @Override
    public int registrar(int idVisita) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call REGISTRAR_VISITA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_VISITA", idVisita);
            cs.setDate("_FECHA_VISITA", new java.sql.Date(new Date().getTime()));
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
