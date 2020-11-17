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
import pe.edu.pucp.CrewmanSystem.dao.LineaPedidoDAO;
import pe.edu.pucp.CrewmanSystem.model.LineaPedido;
import pe.edu.pucp.CrewmanSystem.mysql.LineaPedidoMySQL;

@WebService(serviceName = "LineaPedidoWS")
public class LineaPedidoWS {
    private LineaPedidoDAO daoLineaPedido;
    
    public LineaPedidoWS(){
        daoLineaPedido = new LineaPedidoMySQL();
    }
    
    @WebMethod(operationName = "insertarLineaPedido")
    public int insertarLineaPedido(@WebParam(name = "lineaPedido") LineaPedido lineaPedido){
        int resultado = 0;
        try{
            resultado = daoLineaPedido.insertar(lineaPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarLineaPedido")
    public int actualizarLineaPedido(@WebParam(name = "lineaPedido") LineaPedido lineaPedido){
        int resultado = 0;
        try{
            resultado = daoLineaPedido.actualizar(lineaPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarLineaPedido")
    public int eliminarLineaPedido(@WebParam(name = "idLineaPedido") int idLineaPedido){
        int resultado = 0;
        try{
            resultado = daoLineaPedido.eliminar(idLineaPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarLineaPedidos")
    public ArrayList<LineaPedido> listarLineaPedidos(@WebParam(name = "idPedido") int idPedido) {
        ArrayList<LineaPedido> misLineaPedidos = new ArrayList<>();
        try{
            misLineaPedidos = daoLineaPedido.listar(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misLineaPedidos;
    }
}
