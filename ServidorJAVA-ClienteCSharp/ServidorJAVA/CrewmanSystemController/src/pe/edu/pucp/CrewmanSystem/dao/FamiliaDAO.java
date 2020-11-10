package pe.edu.pucp.CrewmanSystem.dao;

import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.Familia;

public interface FamiliaDAO {
    int insertar(Familia familia);
    int actualizar(Familia familia);
    int eliminar(int idFamilia);
    ArrayList<Familia> listar();
}