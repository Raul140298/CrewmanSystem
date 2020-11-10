/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import java.sql.Connection;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.PersonaContactoDAO;
import pe.edu.pucp.CrewmanSystem.model.PersonaContacto;
import pe.edu.pucp.CrewmanSystem.mysql.PersonaContactoMySQL;

/**
 *
 * @author User
 */
@WebService(serviceName = "PersonaContactoWS")
public class PersonaContactoWS {
private PersonaContactoDAO daoPersonaContacto;
    public PersonaContactoWS(){
        daoPersonaContacto = new PersonaContactoMySQL();
    }
   
    @WebMethod(operationName = "insertarPersonaContacto")
    public int insertarPersonaContacto(@WebParam(name = "persona") PersonaContacto persona) {
        int resultado = 0;
        try{
            resultado = daoPersonaContacto.insertar(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarPersonaContacto")
    public int actualizarPersonaContacto(@WebParam(name = "persona") PersonaContacto persona) {
        int resultado = 0;
        try{
            resultado = daoPersonaContacto.actualizar(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPersonaContacto")
    public int eliminarPersonaContacto(@WebParam(name = "persona") int idPersonaContacto) {
        int resultado = 0;
        try{
            resultado = daoPersonaContacto.eliminar(idPersonaContacto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "mostrarPersonaContacto")
    public PersonaContacto mostrarPersonaContacto(@WebParam(name = "persona") int idPersonaContacto) {
        PersonaContacto resultado = new PersonaContacto();
        try{
            resultado = daoPersonaContacto.mostrar(idPersonaContacto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
