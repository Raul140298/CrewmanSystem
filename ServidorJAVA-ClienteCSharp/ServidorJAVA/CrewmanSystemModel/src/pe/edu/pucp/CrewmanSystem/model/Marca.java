package pe.edu.pucp.CrewmanSystem.model;

public class Marca{
    private int idMarca;
    private String nombre;
    private boolean activo;
    
    public Marca(){
        this.activo=true;
    }
    public Marca(String nombre){
        this.nombre=nombre;
        this.activo=true;
    }
    
    public int getIdMarca() {
        return idMarca;
    }

    public void setIdMarca(int idMarca) {
        this.idMarca = idMarca;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}