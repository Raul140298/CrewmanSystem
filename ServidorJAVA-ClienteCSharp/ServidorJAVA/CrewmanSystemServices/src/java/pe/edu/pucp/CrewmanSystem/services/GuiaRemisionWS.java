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
import pe.edu.pucp.CrewmanSystem.dao.GuiaRemisionDAO;
import pe.edu.pucp.CrewmanSystem.model.GuiaRemision;
import pe.edu.pucp.CrewmanSystem.mysql.GuiaRemisionMySQL;

@WebService(serviceName = "GuiaRemisionWS")
public class GuiaRemisionWS {
    private GuiaRemisionDAO daoGuiaRemision;
    
    public GuiaRemisionWS(){
        daoGuiaRemision = new GuiaRemisionMySQL();
    }
    
    @WebMethod(operationName = "insertarGuiaRemision")
    public int insertarGuiaRemision(@WebParam(name = "guiaRemision") GuiaRemision guiaRemision){
        int resultado = 0;
        try{
            resultado = daoGuiaRemision.insertar(guiaRemision);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarGuiaRemision")
    public int actualizarGuiaRemision(@WebParam(name = "guiaRemision") GuiaRemision guiaRemision){
        int resultado = 0;
        try{
            resultado = daoGuiaRemision.actualizar(guiaRemision);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarGuiaRemisions")
    public ArrayList<GuiaRemision> listarGuiaRemisions(@WebParam(name = "idPedido") int idPedido) {
        ArrayList<GuiaRemision> misGuiaRemisions = new ArrayList<>();
        try{
            misGuiaRemisions = daoGuiaRemision.listar(idPedido);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misGuiaRemisions;
    }
}
