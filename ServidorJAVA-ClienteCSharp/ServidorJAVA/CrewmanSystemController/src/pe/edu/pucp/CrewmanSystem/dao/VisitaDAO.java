package pe.edu.pucp.CrewmanSystem.dao;

import java.sql.Connection;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import pe.edu.pucp.CrewmanSystem.model.Visita;

public interface VisitaDAO {
    int insertar(Visita visita);
    int actualizar(Visita visita);
    ArrayList<Visita> listar(Empleado empleado);
}
