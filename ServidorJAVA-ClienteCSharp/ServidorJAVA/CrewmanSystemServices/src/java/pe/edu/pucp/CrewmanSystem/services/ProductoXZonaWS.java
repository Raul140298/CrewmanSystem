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
import pe.edu.pucp.CrewmanSystem.dao.ProductoXZonaDAO;
import pe.edu.pucp.CrewmanSystem.model.ProductoXZona;
import pe.edu.pucp.CrewmanSystem.mysql.ProductoXZonaMySQL;

/**
 *
 * @author raul1
 */
@WebService(serviceName = "ProductoXZonaWS")
public class ProductoXZonaWS
{
    private ProductoXZonaDAO daoProductoXZona;
    
    public ProductoXZonaWS(){
        daoProductoXZona = new ProductoXZonaMySQL();
    }
    @WebMethod(operationName = "insertarProductoXZona")
    public int insertarProductoXZona(@WebParam(name = "productoXZona") ProductoXZona producto){
        int resultado = 0;
        try{
            resultado = daoProductoXZona.insertar(producto);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    //String nombre,String familiaStr,String subFamiliaStr,String marcaStr,int idZona
    @WebMethod(operationName = "listarProductosXZonas")
    public ArrayList<ProductoXZona> listarProductoXZonas(@WebParam(name = "nombre") String nombre, @WebParam(name = "familiaStr") String familiaStr, 
            @WebParam(name = "subFamiliaStr") String subFamiliaStr, @WebParam(name = "marcaStr") String marcaStr, @WebParam(name = "idZona") int idZona) {
        ArrayList<ProductoXZona> misProductoXZonas = new ArrayList<>();
        try{
            misProductoXZonas = daoProductoXZona.listar(nombre, familiaStr,subFamiliaStr,marcaStr,idZona);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misProductoXZonas;
    }
}
