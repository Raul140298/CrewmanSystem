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
import pe.edu.pucp.CrewmanSystem.dao.PromocionDAO;
import pe.edu.pucp.CrewmanSystem.model.Promocion;
import pe.edu.pucp.CrewmanSystem.mysql.PromocionMySQL;

/**
 *
 * @author raul1
 */
@WebService(serviceName = "PromocionWS")
public class PromocionWS
{
    private PromocionDAO daoPromocion;
    
    public PromocionWS(){
        daoPromocion = new PromocionMySQL();
    }
    
    @WebMethod(operationName = "insertarPromocion")
    public int insertarPromocion(@WebParam(name = "promocion") Promocion promocion){
        int resultado = 0;
        try{
            resultado = daoPromocion.insertar(promocion);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarPromocion")
    public int actualizarPromocion(@WebParam(name = "promocion") Promocion promocion){
        int resultado = 0;
        try{
            resultado = daoPromocion.actualizar(promocion);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPromocion")
    public int eliminarPromocion(@WebParam(name = "idPromocion") int idPromocion){
        int resultado = 0;
        try{
            resultado = daoPromocion.eliminar(idPromocion);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPromocions")
    public ArrayList<Promocion> listarPromocions(@WebParam(name = "nombre") String nombre, @WebParam(name = "fechaIni") Date fechaIni, @WebParam(name = "fechaFin") Date fechaFin) {
        ArrayList<Promocion> misPromocions = new ArrayList<>();
        try{
            misPromocions = daoPromocion.listar(nombre, fechaIni, fechaFin);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misPromocions;
    }
}
