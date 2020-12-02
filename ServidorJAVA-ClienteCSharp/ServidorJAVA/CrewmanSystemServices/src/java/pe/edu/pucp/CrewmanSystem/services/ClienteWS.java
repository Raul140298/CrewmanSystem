/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.ClienteDAO;
import pe.edu.pucp.CrewmanSystem.model.Cliente;
import pe.edu.pucp.CrewmanSystem.mysql.ClienteMySQL;

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
            @WebParam(name = "grupo") String grupo,
            @WebParam(name = "idZona") int idZona) {
        ArrayList<Cliente> misClientes = new ArrayList<>();
        try{
            misClientes = daoCliente.listar(razonSocial,grupo,idZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClientes;
    }
    
    @WebMethod(operationName = "listarClientesSinCartera")
    public ArrayList<Cliente> listarClientesSinCartera(
            @WebParam(name = "razonSocial") String razonSocial,
            @WebParam(name = "grupo") String grupo,
            @WebParam(name = "idZona") int idZona) {
        ArrayList<Cliente> misClientes = new ArrayList<>();
        try{
            misClientes = daoCliente.listarSinCartera(razonSocial,grupo,idZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClientes;
    }
    
    @WebMethod(operationName = "listarClientesConCartera")
    public ArrayList<Cliente> listarClientesConCartera(
            @WebParam(name = "razonSocial") String razonSocial,
            @WebParam(name = "grupo") String grupo,
            @WebParam(name = "idCartera") int idCartera) {
        ArrayList<Cliente> misClientes = new ArrayList<>();
        try{
            misClientes = daoCliente.listarConCartera(razonSocial,grupo,idCartera);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misClientes;
    }
                
    @WebMethod(operationName = "obtenerCliente")
    public Cliente obtenerCliente(@WebParam(name = "idCliente") int idCliente){
        Cliente cliente = new Cliente();
        try{
            cliente = daoCliente.obtenerCliente(idCliente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return cliente;
    }
    
    @WebMethod(operationName = "segmentarClientes")
    public int segmentarClientes(){
        int resultado = 0;
        try{
            resultado = daoCliente.segmentarClientes();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerInfoSeg")
    public Date obtenerInfoSeg(){
        Date fecha = null;
        try{
            fecha = daoCliente.obtenerInfoSeg();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return fecha;
    }
}
