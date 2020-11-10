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
import pe.edu.pucp.CrewmanSystem.dao.FamiliaDAO;
import pe.edu.pucp.CrewmanSystem.model.Familia;
import pe.edu.pucp.CrewmanSystem.mysql.FamiliaMySQL;

@WebService(serviceName = "FamiliaWS")
public class FamiliaWS {

    private FamiliaDAO daoFamilia;
    
    public FamiliaWS(){
        daoFamilia = new FamiliaMySQL();
    }
    
    @WebMethod(operationName = "insertarFamilia")
    public int insertarFamilia(@WebParam(name = "familia") Familia familia){
        int resultado = 0;
        try{
            resultado = daoFamilia.insertar(familia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarFamilia")
    public int actualizarFamilia(@WebParam(name = "familia") Familia familia){
        int resultado = 0;
        try{
            resultado = daoFamilia.actualizar(familia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarFamilia")
    public int eliminarFamilia(@WebParam(name = "idFamilia") int idFamilia){
        int resultado = 0;
        try{
            resultado = daoFamilia.eliminar(idFamilia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarFamilias")
    public ArrayList<Familia> listarFamilias() {
        ArrayList<Familia> misFamilias = new ArrayList<>();
        try{
            misFamilias = daoFamilia.listar();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misFamilias;
    }
}
