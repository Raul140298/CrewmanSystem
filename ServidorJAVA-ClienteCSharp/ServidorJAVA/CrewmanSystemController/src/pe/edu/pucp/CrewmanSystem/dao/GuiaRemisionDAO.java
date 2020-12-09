package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.GuiaRemision;
import java.util.ArrayList;
import java.util.Date;

public interface GuiaRemisionDAO{
    int insertar(GuiaRemision guiaRemision);
    int actualizar(GuiaRemision guiaRemision);
    ArrayList<GuiaRemision> listar(int idVendedor,String razonSocial,String grupo,
    Date fechaIniRegistro,Date fechaFinRegistro, Date fechaIniTraslado, Date fechaFinTraslado);
}