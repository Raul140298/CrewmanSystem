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
import pe.edu.pucp.CrewmanSystem.dao.VisitaDAO;
import pe.edu.pucp.CrewmanSystem.model.Cargo;
import pe.edu.pucp.CrewmanSystem.model.EmpleadoXZona;
import pe.edu.pucp.CrewmanSystem.model.Persona;
import pe.edu.pucp.CrewmanSystem.model.Visita;
import pe.edu.pucp.CrewmanSystem.model.Zona;

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
            
            if(empleado.getJefe()!=null && empleado.getCargo().getIdCargo()==1){
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
                
                if(empleado.getZona().getIdZona()>0){
                    EmpleadoXZonaDAO daoEmpleadoXZona = new EmpleadoXZonaMySQL();
                    EmpleadoXZona exz = new EmpleadoXZona();
                    exz.setZona(empleado.getZona());
                    exz.setEmpleado(empleado);
                    int resultadoZona = daoEmpleadoXZona.insertar(exz);
                    if(resultadoZona==0) return 0;
                }
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
                
                if(empleado.getZona().getIdZona()>0){
                    EmpleadoXZonaDAO daoEmpleadoXZona = new EmpleadoXZonaMySQL();
                    EmpleadoXZona exz = new EmpleadoXZona(empleado.getZona(), empleado);
                    daoEmpleadoXZona.insertar(exz);
                }
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
            else{
                st = con.createStatement();
                sql = "UPDATE EMPLEADOXZONA SET ACTIVO=0 WHERE ID_EMPLEADO = "+empleado.getIdEmpleado();
                st.executeUpdate(sql);
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
    public ArrayList<Empleado> listarPorJefeVentas(int idJefeVentas,String nombre,String apellidoPaterno,String apellidoMaterno){
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
                Empleado jefe = new Empleado();
                empleado.setIdEmpleado(rs.getInt("ID_EMPLEADO"));
                
                Cargo cargo=new Cargo(1,"VENDEDOR");
                empleado.setCargo(cargo);
                
                jefe.setIdEmpleado(rs.getInt("ID_JEFE"));
                empleado.setJefe(jefe);
                
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
            rs.close();
            for(Empleado e : empleados){
                Zona zona = new Zona();
                st=con.createStatement();
                sql = "SELECT Z.ID_ZONA, Z.NOMBRE "
                        + "FROM EMPLEADOXZONA EXZ, ZONA Z "
                        + "WHERE EXZ.ID_EMPLEADO = "+e.getIdEmpleado()+" AND EXZ.ID_ZONA=Z.ID_ZONA AND EXZ.ACTIVO=1";
                rs = st.executeQuery(sql);
                if(rs.next()){
                    entero = rs.getInt("ID_ZONA");
                    if(entero!=null){
                        zona.setIdZona(entero.intValue());
                        zona.setNombre(rs.getString("NOMBRE"));
                    } 
                    else{
                        zona.setIdZona(0);
                        zona.setNombre("");
                    }
                }
                e.setZona(zona);
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
            
            Persona persona = daoPersona.mostrar(rs.getInt("ID_PERSONA"));
            empleado.asignarPersona(persona);

            Cargo cargo=new Cargo();
            cargo.setIdCargo(rs.getInt("ID_CARGO"));

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
    
    @Override
    public ArrayList<Empleado> listarPorJefeVentasYZona(int idJefeVentas, String nombre, String apellidoPaterno, String apellidoMaterno, int idZona) {
         ArrayList<Empleado> empleados = new ArrayList<>();
        Integer entero;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_EMPLEADO_POR_JEFE_Y_ZONA (?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_JEFE", idJefeVentas);
            cs.setString("_NOMBRE", nombre);
            cs.setString("_APELLIDO_PATERNO", apellidoPaterno);
            cs.setString("_APELLIDO_MATERNO", apellidoMaterno);
            cs.setInt("_ID_ZONA",idZona);
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
            rs.close();
            for(Empleado e : empleados){
                Zona zona = new Zona();
                st=con.createStatement();
                sql = "SELECT Z.ID_ZONA, Z.NOMBRE "
                        + "FROM EMPLEADOXZONA EXZ, ZONA Z "
                        + "WHERE EXZ.ID_EMPLEADO = "+e.getIdEmpleado()+" AND EXZ.ID_ZONA=Z.ID_ZONA AND EXZ.ACTIVO=1";
                rs = st.executeQuery(sql);
                if(rs.next()){
                    entero = rs.getInt("ID_ZONA");
                    if(entero!=null){
                        zona.setIdZona(entero.intValue());
                        zona.setNombre(rs.getString("NOMBRE"));
                    } 
                    else{
                        zona.setIdZona(0);
                        zona.setNombre("");
                    }
                }
                e.setZona(zona);
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
    public ArrayList<Integer> obtenerNumClientes(int idEmpleado) {
        ArrayList<Integer> resultado = new ArrayList<>();
        try{
            ArrayList<Empleado> vendedores = listarPorJefeVentas(idEmpleado, "", "", "");
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            for(Empleado v : vendedores){
                String sql ="{ call LISTAR_NUM_CLIENTES_VENDEDOR(?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_EMPLEADO", v.getIdEmpleado());
                rs = cs.executeQuery();
                rs.next();
                resultado.add(rs.getInt("COUNT"));        
                rs.close();
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception e){
                System.out.println(e.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Integer> obtenerNumVisitados(int idEmpleado) {
        ArrayList<Integer> resultado = new ArrayList<>();
        try{
            ArrayList<Empleado> vendedores = listarPorJefeVentas(idEmpleado, "", "", "");
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            for(Empleado v : vendedores){
                String sql ="{ call LISTAR_NUM_VISITAS_VENDEDOR(?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_ID_EMPLEADO", v.getIdEmpleado());
                rs = cs.executeQuery();
                rs.next();
                resultado.add(rs.getInt("COUNT"));        
                rs.close();
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception e){
                System.out.println(e.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int cambiarContraseña(int idEmpleado, String contraseña) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call CAMBIAR_CONTRASEÑA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EMPLEADO", idEmpleado);
            cs.setString("_CONTRASEÑA", contraseña);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception e){
                System.out.println(e.getMessage());
            }
        }
        return resultado;
    }
    
}