package pe.edu.pucp.CrewmanSystem.model;

public class LineaPedido{
    private int idLineaPedido;
    private int cantidad;
    private ProductoXZona productoXZona;
    private PromocionXProducto promocionXProducto;
    private int cantidadPromo;
    private double montoSubTotal;
    private Pedido pedido;

    public LineaPedido(){
        productoXZona=new ProductoXZona();
        promocionXProducto = new PromocionXProducto();
        cantidadPromo = 0;
    }     
    public LineaPedido(int cantidad,ProductoXZona productoXZona){
        this.cantidad=cantidad;
        this.productoXZona=productoXZona;
        this.montoSubTotal=0.0;
        promocionXProducto = new PromocionXProducto();
        cantidadPromo = 0;
    }

    public PromocionXProducto getPromocionXProducto() {
        return promocionXProducto;
    }

    public void setPromocionXProducto(PromocionXProducto promocionXProducto) {
        this.promocionXProducto = promocionXProducto;
    }

    public int getCantidadPromo() {
        return cantidadPromo;
    }

    public void setCantidadPromo(int cantidadPromo) {
        this.cantidadPromo = cantidadPromo;
    }

    public Pedido getPedido() {
        return pedido;
    }

    public void setPedido(Pedido pedido) {
        this.pedido = pedido;
    }

    public int getIdLineaPedido() {
        return idLineaPedido;
    }

    public void setIdLineaPedido(int idLineaPedido) {
        this.idLineaPedido = idLineaPedido;
    }
    
    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public ProductoXZona getProductoXZona() {
        return productoXZona;
    }

    public void setProductoXZona(ProductoXZona productoXZona) {
        this.productoXZona = productoXZona;
    }

    public double getMontoSubTotal() {
        return montoSubTotal;
    }

    public void setMontoSubTotal(double montoSubTotal) {
        this.montoSubTotal = montoSubTotal;
    }
    //METODOS
    public double calcularMontoSubTotal(){
        montoSubTotal=cantidad*productoXZona.getPrecioReal();
        return montoSubTotal;
    }
} 