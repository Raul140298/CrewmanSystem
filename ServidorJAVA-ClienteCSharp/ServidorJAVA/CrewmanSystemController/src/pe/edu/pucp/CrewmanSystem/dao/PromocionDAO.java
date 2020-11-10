package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Promocion;
import java.util.ArrayList;
import java.util.Date;

public interface PromocionDAO{
    int insertar(Promocion promocion);
    int actualizar(Promocion promocion);
    int eliminar(int idPromocion);
    ArrayList<Promocion> listar(String nombre,Date fechaIni,Date fechaFin);
}