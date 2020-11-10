package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.LineaCredito;
import java.util.ArrayList;

public interface LineaCreditoDAO
{
    int insertar(LineaCredito lineaCredito);
    int actualizar(LineaCredito lineaCredito);
    LineaCredito mostrar(int idLineaCredito);
}