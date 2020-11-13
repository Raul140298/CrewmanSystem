package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Zona;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.Empleado;

public interface ZonaDAO
{
    int insertar(Zona zona);
    int actualizar(Zona zona);
    int eliminar(int idZona);
    ArrayList<Zona> listar();
    Zona mostrar(int idEmpleado);
}