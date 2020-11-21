package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.VisitaDAO;
import pe.edu.pucp.CrewmanSystem.model.Visita;
import pe.edu.pucp.CrewmanSystem.mysql.VisitaMySQL;

@WebService(serviceName = "VisitaWS")
public class VisitaWS {
    private VisitaDAO daoVisita;
    
    public VisitaWS(){
        daoVisita = new VisitaMySQL();
    }
    
    @WebMethod(operationName = "insertarVisita")
    public int insertarVisita(@WebParam(name = "visita") Visita visita){
        int resultado = 0;
        try{
            resultado = daoVisita.insertar(visita);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
        
    @WebMethod(operationName = "listarVisitas")
    public ArrayList<Visita> listarVisitas(@WebParam(name = "idCartera") int idCartera) {
        ArrayList<Visita> misVisitas = new ArrayList<>();
        try{
            misVisitas = daoVisita.listar(idCartera);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misVisitas;
    }  
}
