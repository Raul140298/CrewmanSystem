package pe.edu.pucp.CrewmanSystem.dao;

import java.sql.Connection;
import pe.edu.pucp.CrewmanSystem.model.Persona;

public interface PersonaDAO {
    int insertar(Persona persona);
    int actualizar(Persona persona);
    int eliminar(int idPersona);
    Persona mostrar(int idPersona);
}
