package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.NotaDeCredito;
import java.util.ArrayList;

public interface NotaDeCreditoDAO{
    int insertar(NotaDeCredito notaCredito);
    ArrayList<NotaDeCredito> listar(int idPedido);
}