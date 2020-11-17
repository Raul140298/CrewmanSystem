package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.ZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import pe.edu.pucp.CrewmanSystem.model.Zona;
import pe.edu.pucp.CrewmanSystem.mysql.ZonaMySQL;

@WebService(serviceName = "ZonaWS")
public class ZonaWS {
    private ZonaDAO daoZona;
    
    public ZonaWS(){
        daoZona = new ZonaMySQL();
    }
    
    @WebMethod(operationName = "insertarZona")
    public int insertarZona(@WebParam(name = "zona") Zona zona){
        int resultado = 0;
        try{
            resultado = daoZona.insertar(zona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarZona")
    public int actualizarZona(@WebParam(name = "zona") Zona zona){
        int resultado = 0;
        try{
            resultado = daoZona.actualizar(zona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarZona")
    public int eliminarZona(@WebParam(name = "idZona") int idZona){
        int resultado = 0;
        try{
            resultado = daoZona.eliminar(idZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarZonas")
    public ArrayList<Zona> listarZonas() {
        ArrayList<Zona> misZonas = new ArrayList<>();
        try{
            misZonas = daoZona.listar();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misZonas;
    }
    
    @WebMethod(operationName = "mostrarZona")
    public Zona mostrarZona(@WebParam(name = "idEmpleado") int idEmpleado){
        Zona zona = new Zona();
        try{
            zona = daoZona.mostrar(idEmpleado);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return zona;
    } 
    
    @WebMethod(operationName = "mostrarZonaCliente")
    public Zona mostrarZonaCliente(@WebParam(name = "idCliente") int idCliente){
        Zona zona = new Zona();
        try{
            zona = daoZona.mostrarZonaCliente(idCliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return zona;
    } 
}
