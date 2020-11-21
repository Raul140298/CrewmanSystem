package pe.edu.pucp.CrewmanSystem.dao;
import java.sql.Connection;
import pe.edu.pucp.CrewmanSystem.model.PersonaContacto;
import java.util.ArrayList;

public interface PersonaContactoDAO{
    int insertar(PersonaContacto personaContacto,int idCliente);
    int actualizar(PersonaContacto personaContacto);
    int eliminar(int idPersonaContacto);
    PersonaContacto mostrar(int idPersonaContacto);
}