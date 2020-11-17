package pe.edu.pucp.CrewmanSystem.dao;

import pe.edu.pucp.CrewmanSystem.model.LineaPedido;
import java.util.ArrayList;

public interface LineaPedidoDAO
{
    int insertar(LineaPedido lineaPedido);
    int actualizar(LineaPedido lineaPedido);
    int eliminar(int idLineaPedido);
    ArrayList<LineaPedido> listar(int idPedido);
}