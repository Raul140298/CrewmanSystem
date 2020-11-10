package pe.edu.pucp.CrewmanSystem.model;

import java.util.ArrayList;

public class Familia{
    //ATRIBUTOS
    private int idFamilia;
    private String descripcion;
    private boolean activo;
    private ArrayList<SubFamilia> listaSubFamilia;
    
    //CONSTRUCTORES
    public Familia(){
        listaSubFamilia=new ArrayList<>();
        this.activo=true;
    }
    
    public Familia(String descripcion){
        this.descripcion = descripcion;
        listaSubFamilia=new ArrayList<>();
        this.activo = true;
    }
    
    public String getDescripcion(){
      return descripcion;
    }
    
    public void setDescripcion(String descripcion){
        this.descripcion=descripcion;
    }
    
    public ArrayList<SubFamilia> obtenerListaSubFamilia(){
        return listaSubFamilia;
    }
    
    public int getIdFamilia() {
        return idFamilia;
    }
    
    public void setIdFamilia(int idFamilia) {
        this.idFamilia = idFamilia;
    }

    public boolean getActivo() {
        return this.activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}