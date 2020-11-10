package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.PromocionXProductoDAO;
import pe.edu.pucp.CrewmanSystem.model.PromocionXProducto;
import pe.edu.pucp.CrewmanSystem.mysql.PromocionXProductoMySQL;

@WebService(serviceName = "PromocionXProductoWS")
public class PromocionXProductoWS {
    private PromocionXProductoDAO daoPromocionXProductoDAO;
    
    public PromocionXProductoWS(){
        daoPromocionXProductoDAO = new PromocionXProductoMySQL();
    }
    
    @WebMethod(operationName = "insertarPromocionXProducto")
    public int insertarPromocionXProducto(@WebParam(name = "promocionXProducto") PromocionXProducto promocionXProducto){
        int resultado = 0;
        try{
            resultado = daoPromocionXProductoDAO.insertar(promocionXProducto);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPromocionXProducto")
    public ArrayList<PromocionXProducto> listarPromocionXProducto(@WebParam(name = "idPromocion") int idPromocion) {
        ArrayList<PromocionXProducto> misPromocionXProducto = new ArrayList<>();
        try{
            misPromocionXProducto = daoPromocionXProductoDAO.listar(idPromocion);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misPromocionXProducto;
    }
}
