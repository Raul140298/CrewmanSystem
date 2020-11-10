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
import pe.edu.pucp.CrewmanSystem.dao.FacturaDAO;
import pe.edu.pucp.CrewmanSystem.model.Factura;
import pe.edu.pucp.CrewmanSystem.mysql.FacturaMySQL;

/**
 *
 * @author User
 */
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
    public ArrayList<Factura> listarFacturas(@WebParam(name = "idPedido") int idPedido) {
        ArrayList<Factura> misFacturas = new ArrayList<>();
        try{
            misFacturas = daoFactura.listar(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misFacturas;
    }
}
