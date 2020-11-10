package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import java.util.ArrayList;

public interface EmpleadoDAO{
    int insertar(Empleado empleado);
    int actualizar(Empleado empleado);
    int eliminar(int idEmpleado);
    
    Empleado obtenerEmpleado(String usuario, String contra);
    
    int getEmpleado(Empleado empleado);
    ArrayList<Empleado> listarPorJefeVentas(int idEmpleado,String nombre,String apellidoPaterno,String apellidoMaterno);
}
