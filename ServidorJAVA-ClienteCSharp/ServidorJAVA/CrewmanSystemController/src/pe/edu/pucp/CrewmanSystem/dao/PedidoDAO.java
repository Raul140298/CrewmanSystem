package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Pedido;
import java.util.ArrayList;
import java.util.Date;

public interface PedidoDAO
{
    int insertar(Pedido pedido);
    int actualizar(Pedido pedido);
    int eliminar(int idPedido);
    ArrayList<Pedido> listar(int idVendedor,String razonSocial,String grupo, Date fechaIni, Date fechaFin, String tipoPedido, String estadoPedido);
    ArrayList<Pedido> generarReporte(String idPedido);
    ArrayList<Pedido> listarPedidosSinGuia(int idVendedor,String razonSocial,String grupo, Date fechaIni, Date fechaFin, String tipoPedido, String estadoPedido);
    int insertarTotal(Pedido pedido);
    int aprobarBorrador(Pedido pedido);
    int obtenerPedido(Pedido pedido);
    int liberarStock(Pedido pedido);
    int culminarPedido(Pedido pedido);
    void anular(Pedido pedido);
    void mostrar(Pedido pedido);
    int eliminarPedidoEnProceso(int idPedido);
    int entregarPedido(int idPedido);
    
}
