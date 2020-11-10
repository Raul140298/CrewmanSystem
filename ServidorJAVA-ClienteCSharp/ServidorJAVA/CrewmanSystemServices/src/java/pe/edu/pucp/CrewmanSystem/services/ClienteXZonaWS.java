/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.ClienteXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.ClienteXZona;
import pe.edu.pucp.CrewmanSystem.mysql.ClienteXZonaMySQL;

/**
 *
 * @author User
 */
@WebService(serviceName = "ClienteXZonaWS")
public class ClienteXZonaWS {
    
    private ClienteXZonaDAO daoClienteXZona;
    
    public ClienteXZonaWS(){
        daoClienteXZona= new ClienteXZonaMySQL();
    }
    
    @WebMethod(operationName = "insertarClienteXZona")
    public int insertarClienteXZona(
            @WebParam(name = "clienteXZona") ClienteXZona clienteXZona){
        int resultado = 0;
        try{
            resultado = daoClienteXZona.insertar(clienteXZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarClienteXZona")
    public int eliminarClienteXZona(
            @WebParam(name = "idClienteXZona") int idClienteXZona) {
        int resultado=0;
        try{
            resultado = daoClienteXZona.eliminar(idClienteXZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerClientePorZona")
    public ArrayList<ClienteXZona> obtenerClientePorZona(
            @WebParam(name = "idZona") int idZona) {
        ArrayList<ClienteXZona> misClienteXZona = new ArrayList<>();
        try{
            misClienteXZona = daoClienteXZona.obtenerClientePorZona(idZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClienteXZona;
    }
}
