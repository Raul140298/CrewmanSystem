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
import pe.edu.pucp.CrewmanSystem.dao.FacturaDAO;
import pe.edu.pucp.CrewmanSystem.model.Factura;
import pe.edu.pucp.CrewmanSystem.mysql.FacturaMySQL;

@WebService(serviceName = "FacturaWS")
public class FacturaWS {

    private FacturaDAO daoFactura;
    
    public FacturaWS(){
        daoFactura=new FacturaMySQL();
    }
    
    @WebMethod(operationName = "insertarFactura")
    public int insertarFactura(@WebParam(name = "factura") Factura factura){
        int resultado = 0;
        try{
            resultado = daoFactura.insertar(factura);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarFactura")
    public int actualizarFactura(@WebParam(name = "factura") Factura factura) {
        int resultado=0;
        try{
            resultado = daoFactura.actualizar(factura);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarFactura")
    public int eliminarFactura(@WebParam(name = "factura") Factura factura) {
        int resultado=0;
        try{
            resultado = daoFactura.eliminar(factura);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarFacturas")
    public ArrayList<Factura> listarFacturas(@WebParam(name = "idVendedor") int idVendedor,
            @WebParam(name = "razonSocial") String razonSocial,
            @WebParam(name = "grupo") String grupo,
            @WebParam(name = "fechaInicialEmision") Date fechaInicialEmision,
            @WebParam(name = "fechaFinEmision") Date fechaFinEmision,
            @WebParam(name = "fechaInicialVencimiento") Date fechaInicialVencimiento,
            @WebParam(name = "fechaFinVencimiento") Date fechaFinVencimiento,
            @WebParam(name = "anulado") int anulado,
            @WebParam(name = "estadoPagar") int estadoPagar) {
        ArrayList<Factura> misFacturas = new ArrayList<>();
        try{
            misFacturas = daoFactura.listar(idVendedor, razonSocial, grupo, fechaInicialEmision, fechaFinEmision, fechaInicialVencimiento, fechaFinVencimiento, anulado, estadoPagar);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misFacturas;
    }
    
    @WebMethod(operationName = "listarFacturasPorPedido")
    public ArrayList<Factura> listarFacturasPorPedido(@WebParam(name = "idPedido") int idPedido) {
        ArrayList<Factura> misFacturas = new ArrayList<>();
        try{
            misFacturas = daoFactura.listarPorPedido(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misFacturas;
    }
}
