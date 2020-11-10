/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.EmpleadoXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.EmpleadoXZona;
import pe.edu.pucp.CrewmanSystem.mysql.EmpleadoXZonaMySQL;

/**
 *
 * @author User
 */
@WebService(serviceName = "EmpleadoXZonaWS")
public class EmpleadoXZonaWS {

    private EmpleadoXZonaDAO daoEmpleadoXZona;
    
    public EmpleadoXZonaWS(){
        daoEmpleadoXZona=new EmpleadoXZonaMySQL();
    }
    
    @WebMethod(operationName = "insertarEmpleadoXZona")
    public int insertarEmpleadoXZona(
            @WebParam(name = "empleadoXZona") EmpleadoXZona empleadoXZona){
        int resultado = 0;
        try{
            resultado = daoEmpleadoXZona.insertar(empleadoXZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
     @WebMethod(operationName = "eliminarEmpleadoXZona")
    public int eliminarEmpleadoXZona(
            @WebParam(name = "idEmpleadoXZona") int idEmpleadoXZona) {
        int resultado=0;
        try{
            resultado = daoEmpleadoXZona.eliminar(idEmpleadoXZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
