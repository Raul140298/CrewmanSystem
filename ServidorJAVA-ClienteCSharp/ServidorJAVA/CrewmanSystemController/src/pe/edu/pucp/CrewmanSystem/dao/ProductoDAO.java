package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Producto;
import java.util.ArrayList;

public interface ProductoDAO
{
    int insertar(Producto producto);
    int actualizar(Producto producto);
    int eliminar(int idProducto);
    Producto mostrar(int idProducto);
    ArrayList<Producto> listar(String nombre,String familiaStr,String subFamiliaStr,String marcaStr);
}