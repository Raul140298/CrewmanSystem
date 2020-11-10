/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.LineaCreditoDAO;
import pe.edu.pucp.CrewmanSystem.model.LineaCredito;
import pe.edu.pucp.CrewmanSystem.mysql.LineaCreditoMySQL;

@WebService(serviceName = "LineaCreditoWS")
public class LineaCreditoWS {
    private LineaCreditoDAO daoLineaCredito;
    
    public LineaCreditoWS(){
        daoLineaCredito = new LineaCreditoMySQL();
    }
    
    @WebMethod(operationName = "insertarLineaCredito")
    public int insertarLineaCredito(@WebParam(name = "lineaCredito") LineaCredito lineaCredito){
        int resultado = 0;
        try{
            resultado = daoLineaCredito.insertar(lineaCredito);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarLineaCredito")
    public int actualizarLineaCredito(@WebParam(name = "lineaCredito") LineaCredito lineaCredito){
        int resultado = 0;
        try{
            resultado = daoLineaCredito.actualizar(lineaCredito);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "mostrarLineaCreditos")
    public LineaCredito mostrarLineaCreditos(@WebParam(name = "idLineaCredito") int idLineaCredito) {
        LineaCredito lineaCredito = new LineaCredito();
        try{
            lineaCredito = daoLineaCredito.mostrar(idLineaCredito);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return lineaCredito;
    }
}
