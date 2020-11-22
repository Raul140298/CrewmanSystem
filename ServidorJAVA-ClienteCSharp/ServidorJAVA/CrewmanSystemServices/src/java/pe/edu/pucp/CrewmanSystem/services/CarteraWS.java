/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.CarteraDAO;
import pe.edu.pucp.CrewmanSystem.model.Cartera;
import pe.edu.pucp.CrewmanSystem.mysql.CarteraMySQL;

@WebService(serviceName = "CarteraWS")
public class CarteraWS {

    private CarteraDAO daoCartera;
     
    public CarteraWS(){
        daoCartera = new CarteraMySQL();
    }
         
    @WebMethod(operationName = "actualizarCartera")
    public int actualizarCartera(@WebParam(name = "cartera") Cartera cartera) {
        int resultado=0;
        try{
            resultado = daoCartera.actualizar(cartera);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
