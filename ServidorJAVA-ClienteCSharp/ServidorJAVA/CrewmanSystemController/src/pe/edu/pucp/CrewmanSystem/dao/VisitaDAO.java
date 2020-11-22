package pe.edu.pucp.CrewmanSystem.dao;

import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.Visita;

public interface VisitaDAO {
    int insertar(Visita visita);
    ArrayList<Visita> listar(int idCartera);
    int registrar(int idVisita);
}
