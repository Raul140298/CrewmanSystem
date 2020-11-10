package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.GuiaRemision;
import java.util.ArrayList;

public interface GuiaRemisionDAO{
    int insertar(GuiaRemision guiaRemision);
    int actualizar(GuiaRemision guiaRemision);
    ArrayList<GuiaRemision> listar(int idPedido);
}