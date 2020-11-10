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
import pe.edu.pucp.CrewmanSystem.dao.MarcaDAO;
import pe.edu.pucp.CrewmanSystem.model.Marca;
import pe.edu.pucp.CrewmanSystem.mysql.MarcaMySQL;

@WebService(serviceName = "MarcaWS")
public class MarcaWS {
    private MarcaDAO daoMarca;
    
    public MarcaWS(){
        daoMarca = new MarcaMySQL();
    }
    
    @WebMethod(operationName = "insertarMarca")
    public int insertarMarca(@WebParam(name = "marca") Marca marca){
        int resultado = 0;
        try{
            resultado = daoMarca.insertar(marca);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarMarca")
    public int actualizarMarca(@WebParam(name = "marca") Marca marca){
        int resultado = 0;
        try{
            resultado = daoMarca.actualizar(marca);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarMarca")
    public int eliminarMarca(@WebParam(name = "idMarca") int idMarca){
        int resultado = 0;
        try{
            resultado = daoMarca.eliminar(idMarca);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarMarcas")
    public ArrayList<Marca> listarMarcas() {
        ArrayList<Marca> misMarcas = new ArrayList<>();
        try{
            misMarcas = daoMarca.listar();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misMarcas;
    }
}
