package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.Empleado;
import java.util.ArrayList;

public interface EmpleadoDAO{
    int insertar(Empleado empleado);
    int actualizar(Empleado empleado);
    int eliminar(int idEmpleado);
    //Para el inicio de sesion
    Empleado permitirAccesoEmpleado(String usuario, String contra);
    //Para las funciones que requieran informacion del empleado
    int obtenerEmpleado(Empleado empleado);
    ArrayList<Empleado> listarPorJefeVentas(int idEmpleado,String nombre,String apellidoPaterno,String apellidoMaterno);
    ArrayList<Empleado>listarPorJefeVentasYZona(int idJefeVentas,String nombre,String apellidoPaterno,String apellidoMaterno,int idZona);
    ArrayList<Integer> obtenerNumClientes(int idEmpleado);
    ArrayList<Integer> obtenerNumVisitados(int idEmpleado);
    int cambiarContraseña(int idEmpleado,String contraseña);
}
