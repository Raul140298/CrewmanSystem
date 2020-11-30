package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Factura;
import java.util.ArrayList;
import java.util.Date;

public interface FacturaDAO{
    int insertar(Factura factura);
    int actualizar(Factura factura);
    int eliminar(Factura factura);
    ArrayList<Factura> listar(int idVendedor,String razonSocial,String grupo,
            Date fechaInicialEmision,Date fechaFinEmision,
            Date fechaInicialVencimiento,Date fechaFinVencimiento,
            int anulado,int estadoPagar);
    ArrayList<Factura> listarPorPedido(int idPedido);
}