package pe.edu.pucp.CrewmanSystem.model;

import java.util.ArrayList;
import java.util.Date;

public class Producto{
    //ATRIBUTOS
    private int idProducto;
    private Marca marca;
    private SubFamilia subFamilia;
    private double precioSugerido;
    private String nombre;
    private String unidades;
    private double cantUnidad;
    private int stock;
    private int stockReservado;
    private boolean activo;
    private ArrayList<ProductoXZona> listaProductoXZona;
    private ArrayList<PromocionXProducto> listaPromocionXProducto;
    
    //CONSTRUCTORES
    public Producto(){
        marca=new Marca();
        subFamilia=new SubFamilia();
        this.activo=true;
        this.stockReservado=0;
        this.listaProductoXZona = new ArrayList<>();
        this.listaPromocionXProducto = new ArrayList<>();
    }

    public Producto(Marca marca,SubFamilia subFamilia,String nombre, double cantUnidad, String unidades, double precioSugerido,int stock) {
        this.marca=marca;
        this.nombre = nombre;
        this.unidades = unidades;
        this.cantUnidad = cantUnidad;
        this.precioSugerido = precioSugerido;
        this.subFamilia = subFamilia;
        this.stock=stock;
        this.activo=true;
        this.stockReservado=0;
        this.listaProductoXZona = new ArrayList<>();
        this.listaPromocionXProducto = new ArrayList<>();
    }
    
    //GETTERS y SETTERS
    public int getIdProducto() {
        return idProducto;
    }

    public void setIdProducto(int idProducto) {
        this.idProducto = idProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Marca getMarca() {
        return marca;
    }

    public void setMarca(Marca marca) {
        this.marca = marca;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public double getPrecioSugerido() {
        return precioSugerido;
    }

    public void setPrecioSugerido(double precioSugerido) {
        this.precioSugerido = precioSugerido;
    }
    
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public SubFamilia getSubFamilia() {
        return subFamilia;
    }

    public void setSubFamilia(SubFamilia subFamilia) {
        this.subFamilia = subFamilia;
    }

    public String getUnidades() {
        return unidades;
    }

    public void setUnidades(String unidades) {
        this.unidades = unidades;
    }

    public double getCantUnidad() {
        return cantUnidad;
    }

    public void setCantUnidad(double cantUnidad) {
        this.cantUnidad = cantUnidad;
    }

    public int getStockReservado() {
        return stockReservado;
    }

    public void setStockReservado(int stockReservado) {
        this.stockReservado = stockReservado;
    }
    
    public ArrayList<ProductoXZona> obtenerListaProductoXZona(){
        return this.listaProductoXZona;
    }
    
    public ArrayList<PromocionXProducto> obtenerListaPromocionXProducto(){
        return this.listaPromocionXProducto;
    }
}