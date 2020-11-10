package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Queja;
import java.util.ArrayList;

public interface QuejaDAO
{
    int insertar(Queja queja);
    int actualizar(Queja queja);
    int eliminar(int idQueja);
    ArrayList<Queja> listar(int idPedido);
}