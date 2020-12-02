package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.QuejaDAO;
import pe.edu.pucp.CrewmanSystem.model.Queja;
import pe.edu.pucp.CrewmanSystem.mysql.QuejaMySQL;

@WebService(serviceName = "QuejaWS")
public class QuejaWS {
    private QuejaDAO daoQueja;
    
    public QuejaWS(){
        daoQueja = new QuejaMySQL();
    }
    
    @WebMethod(operationName = "insertarQueja")
    public int insertarQueja(@WebParam(name = "queja") Queja queja){
        int resultado = 0;
        try{
            resultado = daoQueja.insertar(queja);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarQueja")
    public int actualizarQueja(@WebParam(name = "queja") Queja queja){
        int resultado = 0;
        try{
            resultado = daoQueja.actualizar(queja);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarQueja")
    public int eliminarQueja(@WebParam(name = "idQueja") int idQueja){
        int resultado = 0;
        try{
            resultado = daoQueja.eliminar(idQueja);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarQuejas")
    public ArrayList<Queja> listarQuejas(@WebParam(name = "idVendedor") int idVendedor) {
        ArrayList<Queja> misQuejas = new ArrayList<>();
        try{
            misQuejas = daoQueja.listar(idVendedor);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misQuejas;
    }
}
