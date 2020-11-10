package pe.edu.pucp.CrewmanSystem.model;

import java.util.ArrayList;

public class Zona{
    //ATRIBUTOS
    private int idZona;
    private String nombre;
    private boolean activo;
    private ArrayList<ProductoXZona> listaProductoXZona;
    private ArrayList<PromocionXZona> listaPromocionXZona;
    private ArrayList<EmpleadoXZona> listaEmpleadoXZona; 
    private ArrayList<ClienteXZona> listaClienteXZona;
    
    //CONSTRUCTORES
    public Zona(){
        this.activo=true;
        listaProductoXZona=new ArrayList<>();
        listaPromocionXZona=new ArrayList<>();
        listaEmpleadoXZona=new ArrayList<>();
        listaClienteXZona=new ArrayList<>();
    }
    
    public Zona(String nombre){
        this.nombre=nombre;
        this.activo=true;
        listaProductoXZona=new ArrayList<>();
        listaEmpleadoXZona=new ArrayList<>();
        listaClienteXZona=new ArrayList<>();
    }
    
    //GETTERS y SETTERS
    public int getIdZona() {
        return idZona;
    }

    public void setIdZona(int idZona) {
        this.idZona = idZona;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public ArrayList<ProductoXZona> obtenerListaProductoxZona(){
        return this.listaProductoXZona;
    }

    public ArrayList<PromocionXZona> obtenerListaPromocionXZona(){
        return this.listaPromocionXZona;
    }
  
    public ArrayList<ClienteXZona> obtenerListaClienteXZona(){
        return this.listaClienteXZona;
    }
  
    public ArrayList<EmpleadoXZona> obtenerListaEmpleadoXZona(){
        return this.listaEmpleadoXZona;
    }
}