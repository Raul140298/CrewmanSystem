package pe.edu.pucp.CrewmanSystem.dao;

import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.PromocionXZona;

public interface PromocionXZonaDAO {
    int insertar(PromocionXZona promocionXZona);
    ArrayList<PromocionXZona> listar(int idPromocion);
}
