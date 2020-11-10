package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Factura;
import java.util.ArrayList;

public interface FacturaDAO{
    int insertar(Factura factura);
    int actualizar(Factura factura);
    int eliminar(Factura factura);
    ArrayList<Factura> listar(int idPedido);
}