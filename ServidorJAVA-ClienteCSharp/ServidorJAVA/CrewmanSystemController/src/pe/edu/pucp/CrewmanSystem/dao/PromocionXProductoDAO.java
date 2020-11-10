package pe.edu.pucp.CrewmanSystem.dao;

import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.PromocionXProducto;

public interface PromocionXProductoDAO {
    int insertar(PromocionXProducto promocionXProducto);
    ArrayList<PromocionXProducto> listar(int idPromocion);
}
