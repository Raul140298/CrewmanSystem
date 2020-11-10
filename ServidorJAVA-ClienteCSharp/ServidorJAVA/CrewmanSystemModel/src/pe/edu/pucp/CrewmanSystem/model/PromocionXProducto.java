package pe.edu.pucp.CrewmanSystem.model;

public class PromocionXProducto {
    //ATRIBUTOS
    private int idPromocionXProducto;
    private Promocion promocion;
    private Producto producto;
    private int descuento;
    private int stock;
    private int stockReservado;
    private boolean activo;
    
    //CONSTRUCTORES
    public PromocionXProducto(){
        producto=new Producto();
        promocion=new Promocion();
        this.stockReservado = 0;
        this.activo=true;
    }
    
    public PromocionXProducto(Promocion promocion, Producto producto, int descuento,int stock){
        this.promocion = promocion;
        this.producto = producto;
        this.descuento = descuento;
        this.stock = stock;
        this.stockReservado = 0;
        this.activo=true;
    }
    //GETTERS y SETTERS
    public int getIdPromocionXProducto() {
        return idPromocionXProducto;
    }

    public void setIdPromocionXProducto(int idPromocionXProducto) {
        this.idPromocionXProducto = idPromocionXProducto;
    }

    public Promocion getPromocion() {
        return promocion;
    }

    public void setPromocion(Promocion promocion) {
        this.promocion = promocion;
    }

    public Producto getProducto() {
        return producto;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    public int getDescuento() {
        return descuento;
    }

    public void setDescuento(int descuento) {
        this.descuento = descuento;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public int getStockReservado() {
        return stockReservado;
    }

    public void setStockReservado(int stockReservado) {
        this.stockReservado = stockReservado;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}
