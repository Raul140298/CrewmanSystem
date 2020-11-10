package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Cartera;
import pe.edu.pucp.CrewmanSystem.model.Empleado;

public interface CarteraDAO
{
    int insertar(Cartera cartera);
    int actualizar(Cartera cartera);
    int eliminar(int idCartera);
}
