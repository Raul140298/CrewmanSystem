package pe.edu.pucp.CrewmanSystem.dao;

import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.ClienteXZona;

public interface ClienteXZonaDAO {
    int insertar(ClienteXZona clienteXZona);
    int eliminar(int idClienteXZona);
    ArrayList<ClienteXZona> obtenerClientePorZona(int idZona);
}
