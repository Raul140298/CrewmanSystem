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
import pe.edu.pucp.CrewmanSystem.dao.NotaDeCreditoDAO;
import pe.edu.pucp.CrewmanSystem.model.NotaDeCredito;
import pe.edu.pucp.CrewmanSystem.mysql.NotaDeCreditoMySQL;

/**
 *
 * @author Joseph
 */
@WebService(serviceName = "NotaDeCreditoWS")
public class NotaDeCreditoWS {
    private NotaDeCreditoDAO daoNotaDeCredito;
    
    public NotaDeCreditoWS(){
        daoNotaDeCredito = new NotaDeCreditoMySQL();
    }
    
    @WebMethod(operationName = "insertarNotaDeCredito")
    public int insertarNotaDeCredito(@WebParam(name = "notaDeCredito") NotaDeCredito notaDeCredito){
        int resultado = 0;
        try{
            resultado = daoNotaDeCredito.insertar(notaDeCredito);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "mostrarNotaDeCreditos")
    public ArrayList<NotaDeCredito> mostrarNotaDeCreditos(@WebParam(name = "idPedido") int idPedido) {
        ArrayList<NotaDeCredito> misNotasDeCreditos = new ArrayList<>();
        try{
            misNotasDeCreditos = daoNotaDeCredito.listar(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misNotasDeCreditos;
    }
}
