package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ClienteDAO;
import pe.edu.pucp.CrewmanSystem.dao.ClienteXZonaDAO;
import pe.edu.pucp.CrewmanSystem.dao.LineaCreditoDAO;
import pe.edu.pucp.CrewmanSystem.dao.PersonaContactoDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.model.ClienteXZona;
import pe.edu.pucp.CrewmanSystem.model.LineaCredito;
import pe.edu.pucp.CrewmanSystem.model.PersonaContacto;
import pe.edu.pucp.CrewmanSystem.model.Zona;

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
            cs.executeUpdate();
            resultado = cs.getInt("_ID_CLIENTE");
            cliente.setIdCliente(resultado);
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
            resultado = cs.executeUpdate();
            if(resultado==0) return 0;
                        
            ClienteXZonaDAO daoCXZ = new ClienteXZonaMySQL();
            ClienteXZona clixzona = new ClienteXZona(cliente,cliente.getZona());
            daoCXZ.insertar(clixzona);
            
            if(cliente.getLineaCredito().getIdLineaCredito()>0){
                LineaCreditoDAO daoLineaCredito = new LineaCreditoMySQL();
                resultado = daoLineaCredito.actualizar(cliente.getLineaCredito());
                return resultado;
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
    public ArrayList<Cliente> listar(String razonSocial, String grupo,int idZona){
        ArrayList<Cliente> clientes = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_CLIENTE (?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setString("_RAZON_SOCIAL", razonSocial);
            cs.setString("_GRUPO", grupo);
            cs.setInt("_ID_ZONA", idZona);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Cliente cliente = new Cliente();
                Zona zona = new Zona();
                cliente.setIdCliente(rs.getInt("ID_CLIENTE"));
                entero=rs.getInt("ID_LINEA_DE_CREDITO");
                if(entero!=null) cliente.getLineaCredito().setIdLineaCredito(entero.intValue());
                
                entero=rs.getInt("ID_PERSONA_CONTACTO");
                if(entero!=null) cliente.getPersonaContacto().setIdPersonaContacto(entero.intValue());
                
                entero=rs.getInt("ID_CARTERA");
                if(entero!=null) cliente.getCartera().setIdCartera(entero.intValue());
                
                cliente.setRuc(rs.getString("RUC"));
                cliente.setRazonSocial(rs.getString("RAZON_SOCIAL"));
                cliente.setFechaRegistro(rs.getDate("FECHA_REGISTRO"));
                cliente.setFechaUltimaCompra(rs.getDate("FECHA_ULTIMA_COMPRA"));
                cliente.setGrupo(rs.getString("GRUPO"));
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                
                zona.setIdZona(rs.getInt("ID_ZONA"));
                zona.setNombre(rs.getString("NOMBRE"));
                cliente.setZona(zona);
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
    public Cliente obtenerCliente(int idCliente){
        Cliente cliente = new Cliente();
        int resultado=0;
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_CLIENTE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CLIENTE", idCliente);
            resultado = cs.executeUpdate();
            
            if(resultado == 0) return null;
            
            rs = cs.getResultSet();
            rs.next();
            
            entero = rs.getInt("ID_LINEA_DE_CREDITO");
            if(entero!=null)cliente.getLineaCredito().setIdLineaCredito(entero.intValue());
            
            entero = rs.getInt("ID_PERSONA_CONTACTO");
            if(entero!=null)cliente.getPersonaContacto().setIdPersonaContacto(entero.intValue());
            
            entero = rs.getInt("ID_CARTERA");
            if(entero!=null)cliente.getCartera().setIdCartera(entero.intValue());
            
            cliente.setIdCliente(idCliente);
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
        return cliente;
    }

    @Override
    public ArrayList<Cliente> listarSinCartera(String razonSocial, String grupo, int idZona) {
        ArrayList<Cliente> clientes = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_CLIENTES_SIN_CARTERA (?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ZONA", idZona);
            cs.setString("_RAZON_SOCIAL", razonSocial);
            cs.setString("_GRUPO", grupo);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Cliente cliente = new Cliente();
                Zona zona = new Zona();
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
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                
                zona.setIdZona(rs.getInt("ID_ZONA"));
                zona.setNombre(rs.getString("ZONA"));
                cliente.setZona(zona);
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
    public ArrayList<Cliente> listarConCartera(String razonSocial, String grupo, int idCartera) {
        ArrayList<Cliente> clientes = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_CLIENTES_CON_CARTERA (?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_CARTERA", idCartera);
            cs.setString("_RAZON_SOCIAL", razonSocial);
            cs.setString("_GRUPO", grupo);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Cliente cliente = new Cliente();
                Zona zona = new Zona();
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
                cliente.setTipoEmpresa(rs.getString("TIPOCLIENTE"));
                cliente.setDireccion(rs.getString("DIRECCION"));
                
                zona.setIdZona(rs.getInt("ID_ZONA"));
                zona.setNombre(rs.getString("ZONA"));
                cliente.setZona(zona);
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
    public int segmentarClientes(){
        double menor=999999;
        double mayor=0;
        double monto;
        double rango;
        int resultado = 0;
        String tipo = "";
        Date fechaIni;
        Date fechaFin;
        Calendar cal = new GregorianCalendar();
        cal.setTime(new Date());
        cal.add(Calendar.MONTH, -1);
        cal.set(Calendar.DAY_OF_MONTH, 1);
        fechaIni = cal.getTime();
        cal.set(Calendar.DAY_OF_MONTH, cal.getActualMaximum(Calendar.DATE));
        fechaFin = cal.getTime();
        try{
            ClienteDAO daoCliente = new ClienteMySQL();
            ArrayList<Cliente> clientes = daoCliente.listar("", "", 0);
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            con.setAutoCommit(false);
            String sql;
            for(Cliente c : clientes){
                sql ="{ call OBTENER_MONTO_SEG (?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_MONTO_SEG", java.sql.Types.DOUBLE);
                cs.setInt("_ID_CLIENTE", c.getIdCliente());
                cs.setDate("_FECHA_INI",new java.sql.Date(fechaIni.getTime()));
                cs.setDate("_FECHA_FIN",new java.sql.Date(fechaFin.getTime()));
                cs.executeUpdate();
                monto = cs.getDouble("_MONTO_SEG");
                c.setMontoSeg(monto);
                if(monto<menor)menor = monto;
                if(monto>mayor)mayor = monto;
            }
            rango = (mayor - menor) / 3;
            for(Cliente c : clientes){
                monto = c.getMontoSeg();
                if(monto >= menor && monto < (menor + rango)){
                    tipo = "BAJO";
                }
                else if(monto >= (menor + rango) && monto <= (mayor - rango)){
                    tipo = "MEDIO";
                }
                else{
                    tipo = "ALTO";
                }
                sql ="{ call ASIGNAR_TIPO (?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_CLIENTE", c.getIdCliente());
                cs.setString("_TIPO_CLIENTE", tipo);
                resultado = cs.executeUpdate();
                if(resultado == 0)return 0;
            }
            con.commit();
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
