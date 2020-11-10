package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.PromocionXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.PromocionXZona;
import pe.edu.pucp.CrewmanSystem.mysql.PromocionXZonaMySQL;

@WebService(serviceName = "PromocionXZonaWS")
public class PromocionXZonaWS {
    private PromocionXZonaDAO daoPromocionXZona;
    
    public PromocionXZonaWS(){
        daoPromocionXZona = new PromocionXZonaMySQL();
    }    
    
    @WebMethod(operationName = "insertarPromocionXZona")
    public int insertarPromocionXZona(@WebParam(name = "promocionXZona") PromocionXZona promocionXZona){
        int resultado = 0;
        try{
            resultado = daoPromocionXZona.insertar(promocionXZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPromocionXZona")
    public ArrayList<PromocionXZona> listarPromocionXZona(@WebParam(name = "idPromocion") int idPromocion) {
        ArrayList<PromocionXZona> misPromocionXZona = new ArrayList<>();
        try{
            misPromocionXZona = daoPromocionXZona.listar(idPromocion);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misPromocionXZona;
    }
}
