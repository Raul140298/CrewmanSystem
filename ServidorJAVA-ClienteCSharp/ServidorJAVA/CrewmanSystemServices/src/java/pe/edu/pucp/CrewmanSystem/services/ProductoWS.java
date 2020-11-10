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
import pe.edu.pucp.CrewmanSystem.dao.ProductoDAO;
import pe.edu.pucp.CrewmanSystem.model.Producto;
import pe.edu.pucp.CrewmanSystem.mysql.ProductoMySQL;

/**
 *
 * @author raul1
 */
@WebService(serviceName = "ProductoWS")
public class ProductoWS
{
    private ProductoDAO daoProducto;
    
    public ProductoWS(){
        daoProducto = new ProductoMySQL();
    }
    
    @WebMethod(operationName = "insertarProducto")
    public int insertarProducto(@WebParam(name = "producto") Producto producto){
        int resultado = 0;
        try{
            resultado = daoProducto.insertar(producto);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarProducto")
    public int actualizarProducto(@WebParam(name = "producto") Producto producto){
        int resultado = 0;
        try{
            resultado = daoProducto.actualizar(producto);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarProducto")
    public int eliminarProducto(@WebParam(name = "idProducto") int idProducto){
        int resultado = 0;
        try{
            resultado = daoProducto.eliminar(idProducto);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarProductos")
    public ArrayList<Producto> listarProductos(@WebParam(name = "nombre") String nombre, @WebParam(name = "familiaStr") String familiaStr, @WebParam(name = "subFamiliaStr") String subFamiliaStr, @WebParam(name = "marcaStr") String marcaStr) {
        ArrayList<Producto> misProductos = new ArrayList<>();
        try{
            misProductos = daoProducto.listar(nombre,familiaStr, subFamiliaStr, marcaStr);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return misProductos;
    }
    
    @WebMethod(operationName = "mostrarProducto")
    public Producto mostrarProducto(@WebParam(name = "idProducto") int idProducto){
        Producto resultado = new Producto();
        try{
            resultado = daoProducto.mostrar(idProducto);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
