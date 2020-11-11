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
import pe.edu.pucp.CrewmanSystem.dao.ClienteDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.mysql.ClienteMySQL;

/**
 *
 * @author User
 */
@WebService(serviceName = "ClienteWS")
public class ClienteWS {

    private ClienteDAO daoCliente;
    
    public ClienteWS(){
        daoCliente=new ClienteMySQL();
    }
    
    @WebMethod(operationName = "insertarCliente")
    public int insertarCliente(@WebParam(name = "cliente") Cliente cliente) {
        int resultado = 0;
        try{
            resultado = daoCliente.insertar(cliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarCliente")
    public int actualizarCliente(@WebParam(name = "cliente") Cliente cliente) {
        int resultado=0;
        try{
            resultado = daoCliente.actualizar(cliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCliente")
    public int eliminarCliente(@WebParam(name = "idCliente") int idCliente) {
        int resultado=0;
        try{
            resultado = daoCliente.eliminar(idCliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "mostrarCliente")
    public int mostrarCliente(@WebParam(name = "cliente") Cliente cliente) {
        int resultado=0;
        try{
            daoCliente.mostrar(cliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarClientes")
    public ArrayList<Cliente> listarClientes(
            @WebParam(name = "razonSocial") String razonSocial,
            @WebParam(name = "grupo") String grupo) {
        ArrayList<Cliente> misClientes = new ArrayList<>();
        try{
            misClientes = daoCliente.listar(razonSocial,grupo);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClientes;
    }
            
    @WebMethod(operationName = "obtenerClientesSinCartera")
    public ArrayList<Cliente> obtenerClientesSinCartera() {
        ArrayList<Cliente> misClientes = new ArrayList<>();
        try{
            misClientes = daoCliente.obtenerClientesSinCartera();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClientes;
    }
    
    @WebMethod(operationName = "obtenerClientesPorCartera")
    public ArrayList<Cliente> obtenerClientesPorCartera(
            @WebParam(name = "idCartera") int idCartera,
            @WebParam(name = "razonSocial") String razonSocial,
            @WebParam(name = "grupo") String grupo) {
        ArrayList<Cliente> misClientes = new ArrayList<>();
        try{
            misClientes = daoCliente.obtenerClientesPorCartera(idCartera, 
                    razonSocial, grupo);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClientes;
    }
    
    @WebMethod(operationName = "obtenerCliente")
    public int obtenerCliente(@WebParam(name = "cliente") Cliente cliente){
        int resultado = 0;
        try{
            resultado = daoCliente.obtenerCliente(cliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
}
