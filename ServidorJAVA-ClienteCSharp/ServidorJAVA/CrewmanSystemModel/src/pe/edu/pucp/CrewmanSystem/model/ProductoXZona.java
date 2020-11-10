package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class ProductoXZona{
    //ATRIBUTOS
    private int idProductoXZona;
    private Producto producto;
    private Zona zona;
    private double precioReal;
    private Date fechaInicio;
    private Date fechaFin;
    private boolean activo;
    
    //CONSTRUCTORES
    public ProductoXZona(){
        producto=new Producto();
        zona=new Zona();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        Date fecha=new Date();
        try {
            this.fechaInicio=formato.parse(formato.format(fecha));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        fechaFin=null;
        activo=true;
    }
    
    public ProductoXZona(Producto producto,Zona zona,double precioReal){
        this.producto=producto;
        this.zona=zona;
        this.precioReal=precioReal;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        Date fecha=new Date();
        try {
            this.fechaInicio=formato.parse(formato.format(fecha));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.fechaFin=null;           
        this.activo=true;
    }
    
    //GETTERS y SETTERS
    public int getIdProductoXZona() {
        return idProductoXZona;
    }

    public void setIdProductoXZona(int idProductoXZona) {    
        this.idProductoXZona = idProductoXZona;
    }

    public Producto getProducto() {
        return producto;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    public Zona getZona() {
        return zona;
    }

    public void setZona(Zona zona) {
        this.zona = zona;
    }

    public double getPrecioReal() {
        return precioReal;
    }

    public void setPrecioReal(double precioReal) {
        this.precioReal = precioReal;
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

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    //METODOS
}