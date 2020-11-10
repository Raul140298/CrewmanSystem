package pe.edu.pucp.CrewmanSystem.dao;
import pe.edu.pucp.CrewmanSystem.model.SubFamilia;
import java.util.ArrayList;

public interface SubFamiliaDAO
{
    int insertar(SubFamilia subFamilia);
    int actualizar(SubFamilia subFamilia);
    int eliminar(int idSubFamilia);
    ArrayList<SubFamilia> listar(String familia);
}