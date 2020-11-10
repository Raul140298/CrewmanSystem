package pe.edu.pucp.CrewmanSystem.model;

import java.util.ArrayList;

public class SubFamilia{
    //ATRIBUTOS
    private int idSubFamilia;
    private Familia familia;
    private String descripcionSubFamilia;
    private boolean activo;
    private ArrayList<Producto> listaProductos;
    
    //CONSTRUCTORES
    public SubFamilia(){
        familia=new Familia();
        this.activo=true;
        listaProductos=new ArrayList<>();
    }
    public SubFamilia(Familia familia,String descripcionSubFamilia){
        this.familia=familia;
        this.descripcionSubFamilia = descripcionSubFamilia;
        this.activo=true;
        listaProductos=new ArrayList<>();
    }
    //GETTERS y SETTERS
    public int getIdSubFamilia() {
        return idSubFamilia;
    }

    public void setIdSubFamilia(int idSubFamilia) {
        this.idSubFamilia = idSubFamilia;
    }

    public Familia getFamilia() {
        return familia;
    }

    public void setFamilia(Familia familia) {
        this.familia = familia;
    }

    public String getDescripcionSubFamilia() {
        return descripcionSubFamilia;
    }

    public void setDescripcionSubFamilia(String descripcionSubFamilia) {
        this.descripcionSubFamilia = descripcionSubFamilia;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public ArrayList<Producto> obtenerListaProducto(){
        return this.listaProductos;
    }
}