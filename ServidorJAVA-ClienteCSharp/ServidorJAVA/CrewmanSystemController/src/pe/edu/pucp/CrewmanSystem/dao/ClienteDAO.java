package pe.edu.pucp.CrewmanSystem.dao;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.Cliente;

public interface ClienteDAO
{
    int insertar(Cliente cliente);
    int actualizar(Cliente cliente);
    int eliminar(int idCliente);
    void mostrar(Cliente cliente);
    ArrayList<Cliente> listar(String razonSocial, String grupo);
    ArrayList<Cliente> obtenerClientesSinCartera();
    ArrayList<Cliente> obtenerClientesPorCartera(int idCartera,String razonSocial,String grupo);
    int obtenerCliente(Cliente cliente);
}
