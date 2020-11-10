package pe.edu.pucp.CrewmanSystem.model;
import java.util.ArrayList;
import java.util.Date;

public class Promocion {
    //ATRIBUTOS
    private int idPromocion;
    private String nombre;
    private String descripcion;
    private Date fechaInicio;
    private Date fechaFin;
    private ArrayList<PromocionXProducto> listaPromocionXProducto;
    private ArrayList<PromocionXZona> listaPromocionXZona;
    private boolean activo;
    
    //CONSTRUCTORES
    public Promocion(){
        this.fechaInicio=null;
        this.fechaFin=null;
        this.activo=true;
        listaPromocionXProducto=new ArrayList<>();
        listaPromocionXZona=new ArrayList<>();
    }
    
    public Promocion(String nombre, String descripcion){
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.activo=true;
        listaPromocionXProducto=new ArrayList<>();
        listaPromocionXZona=new ArrayList<>();
    }
    //GETTERS y SETTERS   

    public int getIdPromocion() {
        return idPromocion;
    }

    public void setIdPromocion(int idPromocion) {
        this.idPromocion = idPromocion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public ArrayList<PromocionXProducto> getListaPromocionXProducto() {
        return listaPromocionXProducto;
    }

    public void setListaPromocionXProducto(ArrayList<PromocionXProducto> listaPromocionXProducto) {
        this.listaPromocionXProducto = listaPromocionXProducto;
    }

    public ArrayList<PromocionXZona> getListaPromocionXZona() {
        return listaPromocionXZona;
    }

    public void setListaPromocionXZona(ArrayList<PromocionXZona> listaPromocionXZona) {
        this.listaPromocionXZona = listaPromocionXZona;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
