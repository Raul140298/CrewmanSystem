package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoDAO;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoXZonaDAO;
import pe.edu.pucp.CrewmanSystem.dao.PersonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Cargo;
import pe.edu.pucp.CrewmanSystem.model.EmpleadoXZona;
import pe.edu.pucp.CrewmanSystem.model.Persona;

public class EmpleadoMySQL implements EmpleadoDAO{
    Connection con;
    CallableStatement cs;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    
    @Override
    public int insertar(Empleado empleado){
        int resultado = 0, idPersona = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            PersonaDAO daoPersona = new PersonaMySQL();
            idPersona=daoPersona.insertar(empleado.obtenerPersona());
            
            if(empleado.getJefe()!=null){
                String sql ="{ call INSERTAR_VENDEDOR(?,?,?,?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_ID_EMPLEADO",java.sql.Types.INTEGER);
                cs.setInt("_ID_PERSONA", idPersona);
                cs.setInt("_ID_JEFE", empleado.getJefe().getIdEmpleado());                
                cs.setDouble("_OBJETIVO_VENTAS", empleado.getObjetivoVentas());
                cs.setDate("_FECHA_CREACION", new java.sql.Date(new Date().getTime()));
                cs.setString("_USUARIO", empleado.getUsuario());
                cs.setString("_CONTRASEÑA", empleado.getContraseña());
                cs.executeUpdate();
                resultado=cs.getInt("_ID_EMPLEADO");
            }
            else{
                String sql ="{ call INSERTAR_JEFE(?,?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_ID_EMPLEADO",java.sql.Types.INTEGER);
                cs.setInt("_ID_PERSONA", idPersona);
                cs.setDate("_FECHA_CREACION", new java.sql.Date(new Date().getTime()));
                cs.setString("_USUARIO", empleado.getUsuario());
                cs.setString("_CONTRASEÑA", empleado.getContraseña());
                cs.executeUpdate();
                resultado=cs.getInt("_ID_EMPLEADO");
            }
            empleado.setIdEmpleado(resultado);
        }
        catch(Exception ex){
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
    public int actualizar(Empleado empleado){
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_EMPLEADO (?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADO", empleado.getIdEmpleado());
            cs.setDouble("_OBJETIVO_VENTAS", empleado.getObjetivoVentas());
            cs.setInt("_ID_CARGO", empleado.getCargo().getIdCargo());
            resultado=cs.executeUpdate();
            
            PersonaDAO personaDAO = new PersonaMySQL();
            resultado=personaDAO.actualizar(empleado.obtenerPersona());
        
            if(empleado.getZona().getIdZona()>0){
                EmpleadoXZonaDAO daoEXZ = new EmpleadoXZonaMySQL();
                EmpleadoXZona empxzona = new EmpleadoXZona(empleado.getZona(),empleado);
                daoEXZ.insertar(empxzona);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idEmpleado){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_EMPLEADO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADO", idEmpleado);
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
    public ArrayList<Empleado>listarPorJefeVentas(int idJefeVentas,String nombre,String apellidoPaterno,String apellidoMaterno){
        ArrayList<Empleado> empleados = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_EMPLEADO_POR_JEFE (?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_JEFE", idJefeVentas);
            cs.setString("_NOMBRE", nombre);
            cs.setString("_APELLIDO_PATERNO", apellidoPaterno);
            cs.setString("_APELLIDO_MATERNO", apellidoMaterno);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Empleado empleado= new Empleado();
                empleado.setIdEmpleado(rs.getInt("ID_EMPLEADO"));
                
                Cargo cargo=new Cargo(1,"VENDEDOR");
                empleado.setCargo(cargo);
                
                PersonaDAO daoPersona = new PersonaMySQL();
                Persona persona = daoPersona.mostrar(rs.getInt("ID_PERSONA")); 
                empleado.asignarPersona(persona);
                
                entero=rs.getInt("ID_CARTERA");
                if(entero!=null) empleado.getCartera().setIdCartera(entero.intValue());
                
                empleado.setSumVentas(rs.getDouble("SUMA_VENTAS_MES"));
                empleado.setObjetivoVentas(rs.getDouble("OBJETIVO_VENTAS"));
                empleado.setFechaCreacion(rs.getDate("FECHA_CREACION"));
                empleado.setUsuario("USUARIO"); 

                empleados.add(empleado);
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
        return empleados;
    }

    @Override
    public Empleado permitirAccesoEmpleado(String usuario, String contra) {
        PersonaDAO daoPersona = new PersonaMySQL();
        Empleado empleado = new Empleado();
        Integer entero;
        int resultado;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call OBTENER_EMPLEADO (?,?)}";
            cs = con.prepareCall(sql);
            cs.setString("_USUARIO", usuario);
            cs.setString("_CONTRASEÑA", contra);
            resultado=cs.executeUpdate();
            rs = cs.getResultSet();
            rs.next();
            
            if(resultado==0) return null;
                 
            empleado.setIdEmpleado(rs.getInt("ID_EMPLEADO"));
            empleado.setFechaCreacion(rs.getDate("FECHA_CREACION"));
            
//            System.out.println(empleado.getIdEmpleado());
//            System.out.println(empleado.getFechaCreacion());
            
            Persona persona = daoPersona.mostrar(rs.getInt("ID_PERSONA"));
            empleado.asignarPersona(persona);

            Cargo cargo=new Cargo();
            cargo.setIdCargo(rs.getInt("ID_CARGO"));
//            System.out.println(empleado.getCargo().getIdCargo());

            if(cargo.getIdCargo()==1){
                cargo.setNombre("VENDEDOR");
                empleado.setSumVentas(rs.getDouble("SUMA_VENTAS_MES"));
                empleado.setObjetivoVentas(rs.getDouble("OBJETIVO_VENTAS"));
                entero=rs.getInt("ID_CARTERA");
                if(entero!=null) empleado.getCartera().setIdCartera(entero.intValue());
            }
            else cargo.setNombre("JEFE DE VENTAS");
            empleado.setCargo(cargo);
               
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return empleado;
    }

    @Override
    public int obtenerEmpleado(Empleado empleado) {
        int resultado = 0;
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_VENDEDOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADO", empleado.getIdEmpleado());
            resultado = cs.executeUpdate();
            rs = cs.getResultSet();
            rs.next();
            
            PersonaDAO daoPersona = new PersonaMySQL();
            Persona persona = daoPersona.mostrar(rs.getInt("ID_PERSONA"));
            empleado.asignarPersona(persona);
            
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