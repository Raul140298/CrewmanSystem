package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.GuiaRemision;
import java.util.ArrayList;
import java.util.Date;

public interface GuiaRemisionDAO{
    int insertar(GuiaRemision guiaRemision);
    int actualizar(GuiaRemision guiaRemision);
    ArrayList<GuiaRemision> listar(int idPedido);
    ArrayList<GuiaRemision> listarPorVendedor(int idVendedor,String motivoTraslado,
    Date fechaIniRegistro,Date fechaFinRegistro, Date fechaIniTraslado, Date fechaFinTraslado);
}