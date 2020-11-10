package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Pedido;
import java.util.ArrayList;

public interface PedidoDAO
{
    int insertar(Pedido pedido);
    int actualizar(Pedido pedido);
    int eliminar(int idPedido);
    ArrayList<Pedido> listar();
    ArrayList<Pedido> generarReporte(String idPedido);
    
    int insertarTotal(Pedido pedido);
    int aprobarBorrador(Pedido pedido);
    int obtenerPedido(Pedido pedido);
    int liberarStock(Pedido pedido);
    int culminarPedido(Pedido pedido);
    void anular(Pedido pedido);
    void mostrar(Pedido pedido);
}
