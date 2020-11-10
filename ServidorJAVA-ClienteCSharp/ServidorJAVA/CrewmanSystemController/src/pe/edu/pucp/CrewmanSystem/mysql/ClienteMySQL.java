package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ClienteDAO;
import pe.edu.pucp.CrewmanSystem.dao.ClienteXZonaDAO;
import pe.edu.pucp.CrewmanSystem.dao.LineaCreditoDAO;
import pe.edu.pucp.CrewmanSystem.dao.PersonaContactoDAO;
import pe.edu.pucp.CrewmanSystem.dao.PersonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.model.ClienteXZona;
import pe.edu.pucp.CrewmanSystem.model.LineaCredito;
import pe.edu.pucp.CrewmanSystem.model.PersonaContacto;

public class ClienteMySQL implements ClienteDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
     @Override
    public int insertar(Cliente cliente){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_CLIENTE(?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_CLIENTE", java.sql.Types.INTEGER);
            cs.setString("_RUC", cliente.getRuc());
            cs.setString("_RAZON_SOCIAL", cliente.getRazonSocial());
            cs.setDate("_FECHA_REGISTRO", new java.sql.Date(new Date().getTime()));
            cs.setString("_GRUPO", cliente.getGrupo());
            cs.setString("_DIRECCION", cliente.getDireccion());
            cs.setInt("_ID_ZONA", cliente.getZona().getIdZona());
            resultado = cs.executeUpdate();
            int idCliente=cs.getInt("_ID_CLIENTE");
            cliente.setIdCliente(idCliente);
            
            PersonaDAO daoPersona = new PersonaMySQL();
            int idPersona=daoPersona.insertar(cliente.getPersonaContacto());
            cliente.getPersonaContacto().setIdPersona(idPersona);
            
            PersonaContactoDAO daoPersonaContacto = new PersonaContactoMySQL();
            int idPersonaContacto = daoPersonaContacto.insertar(cliente.getPersonaContacto());
            cliente.getPersonaContacto().setIdPersonaContacto(idPersonaContacto);
            
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
    public int actualizar(Cliente cliente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_CLIENTE(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CLIENTE", cliente.getIdCliente());
            cs.setString("_RAZON_SOCIAL", cliente.getRazonSocial());
            cs.setString("_GRUPO", cliente.getGrupo());
            cs.setString("_DIRECCION", cliente.getDireccion());
            cs.executeUpdate();
            
            PersonaContactoDAO personaContactoDAO = new PersonaContactoMySQL();
            resultado=personaContactoDAO.actualizar(cliente.getPersonaContacto());
            
            if(cliente.getZona().getIdZona()>0){
                ClienteXZonaDAO daoCXZ = new ClienteXZonaMySQL();
                ClienteXZona clixzona = new ClienteXZona(cliente,cliente.getZona());
                daoCXZ.insertar(clixzona);
            }
            if(cliente.getLineaCredito().getIdLineaCredito()>0){
                LineaCreditoDAO daoLineaCredito = new LineaCreditoMySQL();
                daoLineaCredito.actualizar(cliente.getLineaCredito());
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
    public int eliminar(int idCliente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_CLIENTE (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CLIENTE", idCliente);
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
    public ArrayList<Cliente> listar(){
        ArrayList<Cliente> clientes = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_CLIENTE ()}";
            cs = con.prepareCall(sql);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Cliente cliente = new Cliente();
                cliente.setIdCliente(rs.getInt("ID_CLIENTE"));
                entero=rs.getInt("ID_LINEA_DE_CREDITO");
                if(entero!=null) cliente.getLineaCredito().setIdLineaCredito(entero.intValue());
                
                entero=rs.getInt("ID_PERSONA_CONTACTO");
                if(entero!=null) cliente.getPersonaContacto().setIdPersonaContacto(entero.intValue());
                
                entero=rs.getInt("ID_CARTERA");
                if(entero!=null) cliente.getCartera().setIdCartera(entero.intValue());
                
                cliente.setRuc(rs.getString("RUC"));
                cliente.setRazonSocial(rs.getString("RAZON_SOCIAL"));
                cliente.setFechaUltimaCompra(rs.getDate("FECHA_REGISTRO"));
                cliente.setFechaUltimaCompra(rs.getDate("FECHA_ULTIMA_COMPRA"));
                cliente.setGrupo(rs.getString("GRUPO"));
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                clientes.add(cliente);
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
        return clientes;
    }
    
    @Override
    public ArrayList<Cliente> obtenerClientesSinCartera() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Cliente> obtenerClientesPorCartera(int idCartera,String razonSocial,String grupo) {
        ArrayList<Cliente> clientes = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_CLIENTES_POR_CARTERA (?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CARTERA", idCartera);
            cs.setString("_RAZON_SOCIAL", razonSocial);
            cs.setString("_GRUPO", grupo);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Cliente cliente = new Cliente();
                cliente.setIdCliente(rs.getInt("ID_CLIENTE"));
                entero=rs.getInt("ID_LINEA_DE_CREDITO");
                if(entero!=null) cliente.getLineaCredito().setIdLineaCredito(entero.intValue());
                
                entero=rs.getInt("ID_PERSONA_CONTACTO");
                if(entero!=null) cliente.getPersonaContacto().setIdPersonaContacto(entero.intValue());
                
                entero=rs.getInt("ID_CARTERA");
                if(entero!=null) cliente.getCartera().setIdCartera(entero.intValue());
                
                cliente.setRuc(rs.getString("RUC"));
                cliente.setRazonSocial(rs.getString("RAZON_SOCIAL"));
                cliente.setFechaUltimaCompra(rs.getDate("FECHA_REGISTRO"));
                cliente.setFechaUltimaCompra(rs.getDate("FECHA_ULTIMA_COMPRA"));
                cliente.setGrupo(rs.getString("GRUPO"));
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                clientes.add(cliente);
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
        return clientes;
    }

    @Override
    public void mostrar(Cliente cliente) {
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            if(cliente.getLineaCredito().getIdLineaCredito()>0){
                LineaCreditoDAO daoLineaCredito = new LineaCreditoMySQL();
                LineaCredito lineaCredito=daoLineaCredito.mostrar(cliente.getLineaCredito().getIdLineaCredito());
                cliente.setLineaCredito(lineaCredito);
            }
            if(cliente.getPersonaContacto().getIdPersonaContacto()>0){
                PersonaContactoDAO daoPersonaContacto = new PersonaContactoMySQL();
                PersonaContacto personaContacto=daoPersonaContacto.mostrar(cliente.getPersonaContacto().getIdPersonaContacto());
                cliente.setPersonaContacto(personaContacto);
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
    }
    
    @Override
    public int obtenerCliente(Cliente cliente){
        int resultado = 0;
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_CLIENTE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CLIENTE", cliente.getIdCliente());
            resultado = cs.executeUpdate();
            rs = cs.getResultSet();
            rs.next();
            
            entero = rs.getInt("ID_LINEA_DE_CREDITO");
            if(entero!=null)cliente.getLineaCredito().setIdLineaCredito(entero.intValue());
            
            entero = rs.getInt("ID_PERSONA_CONTACTO");
            if(entero!=null)cliente.getPersonaContacto().setIdPersonaContacto(entero.intValue());
            
            entero = rs.getInt("ID_CARTERA");
            if(entero!=null)cliente.getCartera().setIdCartera(entero.intValue());
            
            cliente.setRuc(rs.getString("RUC"));
            cliente.setRazonSocial(rs.getString("RAZON_SOCIAL"));
            cliente.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
            cliente.setFechaUltimaCompra(rs.getDate("FECHA_ULTIMA_COMPRA"));
            cliente.setGrupo(rs.getString("GRUPO"));
            cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
            cliente.setDireccion(rs.getString("DIRECCION"));
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
