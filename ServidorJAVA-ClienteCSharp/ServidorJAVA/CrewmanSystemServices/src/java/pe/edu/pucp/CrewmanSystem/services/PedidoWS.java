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
import pe.edu.pucp.CrewmanSystem.dao.PedidoDAO;
import pe.edu.pucp.CrewmanSystem.model.Pedido;
import pe.edu.pucp.CrewmanSystem.mysql.PedidoMySQL;

/**
 *
 * @author raul1
 */
@WebService(serviceName = "PedidoWS")
public class PedidoWS
{
    private PedidoDAO daoPedido;
    
    public PedidoWS(){
        daoPedido = new PedidoMySQL();
    }
    
    @WebMethod(operationName = "insertarPedido")
    public int insertarPedido(@WebParam(name = "lineaPedido") Pedido pedido){
        int resultado = 0;
        try{
            resultado = daoPedido.insertar(pedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarPedido")
    public int actualizarPedido(@WebParam(name = "lineaPedido") Pedido pedido){
        int resultado = 0;
        try{
            resultado = daoPedido.actualizar(pedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPedido")
    public int eliminarPedido(@WebParam(name = "idPedido") int idPedido){
        int resultado = 0;
        try{
            resultado = daoPedido.eliminar(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPedidos")
    public ArrayList<Pedido> listarPedidos(@WebParam(name = "idVendedor") int idVendedor, 
            @WebParam(name = "razonSocial") String razonSocial, 
            @WebParam(name = "grupo") String grupo, 
            @WebParam(name = "fechaIni") Date fechaIni, 
            @WebParam(name = "fechaFin") Date fechaFin, 
            @WebParam(name = "tipoPedido") String tipoPedido, 
            @WebParam(name = "estadoPedido") String estadoPedido) 
    {
        ArrayList<Pedido> misPedidos = new ArrayList<>();
        try
        {
            misPedidos = daoPedido.listar(idVendedor,razonSocial, grupo,fechaIni, fechaFin, tipoPedido, estadoPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misPedidos;
    }
    
    @WebMethod(operationName = "listarPedidosSinGuia")
    public ArrayList<Pedido> listarPedidosSinGuia(@WebParam(name = "idVendedor") int idVendedor, 
            @WebParam(name = "razonSocial") String razonSocial, 
            @WebParam(name = "grupo") String grupo, 
            @WebParam(name = "fechaIni") Date fechaIni, 
            @WebParam(name = "fechaFin") Date fechaFin, 
            @WebParam(name = "tipoPedido") String tipoPedido, 
            @WebParam(name = "estadoPedido") String estadoPedido) 
    {
        ArrayList<Pedido> misPedidos = new ArrayList<>();
        try
        {
            misPedidos = daoPedido.listarPedidosSinGuia(idVendedor,razonSocial, grupo,fechaIni, fechaFin, tipoPedido, estadoPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misPedidos;
    }
    
    @WebMethod(operationName = "generarReporte")
    public ArrayList<Pedido> generarReporte(@WebParam(name = "idPedido") String idPedido) {
        ArrayList<Pedido> misPedidos = new ArrayList<>();
        try{
            misPedidos = daoPedido.generarReporte(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misPedidos;
    }
    
    @WebMethod(operationName = "insertarTotal")
    public int insertarTotal(@WebParam(name = "pedido") Pedido pedido)
    {
        int resultado = 0;
        try
        {
            resultado = daoPedido.insertarTotal(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "aprobarBorrador")
    public int aprobarBorrador(@WebParam(name = "pedido") Pedido pedido)
    {
        int resultado = 0;
        try
        {
            resultado = daoPedido.aprobarBorrador(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerPedido")
    public int obtenerPedido(@WebParam(name = "pedido") Pedido pedido)
    {
        int resultado = 0;
        try
        {
            resultado = daoPedido.obtenerPedido(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "liberarStock")
    public int liberarStock(@WebParam(name = "pedido") Pedido pedido)
    {
        int resultado = 0;
        try
        {
            resultado = daoPedido.liberarStock(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "culminarPedido")
    public int culminarPedido(@WebParam(name = "pedido") Pedido pedido)
    {
        int resultado = 0;
        try
        {
            resultado = daoPedido.culminarPedido(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "mostrarPedido")
    public void mostrarPedido(@WebParam(name = "pedido") Pedido pedido)
    {
        try
        {
            daoPedido.mostrar(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }

    }
    
    @WebMethod(operationName = "anular")
    public void anular(@WebParam(name = "pedido") Pedido pedido)
    {
        try
        {
            daoPedido.anular(pedido);
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
    }

    @WebMethod(operationName = "eliminarPedidoEnProceso")
    public int eliminarPedidoEnProceso(@WebParam(name = "idPedido") int idPedido){
        int resultado = 0;
        try{
            resultado = daoPedido.eliminarPedidoEnProceso(idPedido);
        }
        catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "entregarPedido")
    public int entregarPedido(@WebParam(name = "idPedido") int idPedido){
        int resultado = 0;
        try{
            resultado = daoPedido.entregarPedido(idPedido);
        }
        catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
