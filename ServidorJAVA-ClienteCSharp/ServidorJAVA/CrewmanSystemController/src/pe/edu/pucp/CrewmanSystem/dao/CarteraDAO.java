package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Cartera;

public interface CarteraDAO
{
    int insertar(Cartera cartera);
    int actualizar(Cartera cartera);
    int eliminar(int idCartera);
}
