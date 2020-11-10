package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Marca;
import java.util.ArrayList;

public interface MarcaDAO{
    int insertar(Marca marca);
    int actualizar(Marca marca);
    int eliminar(int idMarca);
    ArrayList<Marca> listar();
}