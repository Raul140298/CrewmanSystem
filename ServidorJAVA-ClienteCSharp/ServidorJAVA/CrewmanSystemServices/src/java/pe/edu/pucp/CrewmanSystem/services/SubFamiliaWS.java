package pe.edu.pucp.CrewmanSystem.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.CrewmanSystem.dao.SubFamiliaDAO;
import pe.edu.pucp.CrewmanSystem.model.SubFamilia;
import pe.edu.pucp.CrewmanSystem.mysql.SubFamiliaMySQL;

@WebService(serviceName = "SubFamiliaWS")
public class SubFamiliaWS {
    private SubFamiliaDAO daoSubFamilia;
    
    public SubFamiliaWS(){
        daoSubFamilia = new SubFamiliaMySQL();
    }
    
    @WebMethod(operationName = "insertarSubFamilia")
    public int insertarSubFamilia(@WebParam(name = "subFamilia") SubFamilia subFamilia){
        int resultado = 0;
        try{
            resultado = daoSubFamilia.insertar(subFamilia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarSubFamilia")
    public int actualizarSubFamilia(@WebParam(name = "subFamilia") SubFamilia subFamilia){
        int resultado = 0;
        try{
            resultado = daoSubFamilia.actualizar(subFamilia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarSubFamilia")
    public int eliminarSubFamilia(@WebParam(name = "idSubFamilia") int idSubFamilia){
        int resultado = 0;
        try{
            resultado = daoSubFamilia.eliminar(idSubFamilia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarSubFamilias")
    public ArrayList<SubFamilia> listarSubFamilias(@WebParam(name = "familia") String familia) {
        ArrayList<SubFamilia> misSubFamilias = new ArrayList<>();
        try{
            misSubFamilias = daoSubFamilia.listar(familia);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misSubFamilias;
    }
}
