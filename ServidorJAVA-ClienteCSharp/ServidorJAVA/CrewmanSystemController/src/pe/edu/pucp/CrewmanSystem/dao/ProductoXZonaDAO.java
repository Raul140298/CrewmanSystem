package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.ProductoXZona;
import java.util.ArrayList;

public interface ProductoXZonaDAO
{
    int insertar(ProductoXZona productoXZona);
    ArrayList<ProductoXZona> listar(String productoStr,String zonaStr);
}
