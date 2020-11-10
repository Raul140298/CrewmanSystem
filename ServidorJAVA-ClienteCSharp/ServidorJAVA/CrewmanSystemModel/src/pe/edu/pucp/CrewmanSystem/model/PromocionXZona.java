package pe.edu.pucp.CrewmanSystem.model;

public class PromocionXZona {
    //ATRIBUTOS
    private int idPromocionXZona;
    private Promocion promocion;
    private Zona zona;
    private boolean activo;
    
    //CONSTRUCTORES
    public PromocionXZona(){
        promocion=new Promocion();
        zona=new Zona();
        this.activo=true;
    }
    
    public PromocionXZona(Promocion promocion, Zona zona){
        this.promocion = promocion;
        this.zona = zona;
        this.activo=true;
    }
    //GETTERS y SETTERS
    public int getIdPromocionXZona() {
        return idPromocionXZona;
    }

    public void setIdPromocionXZona(int idPromocionXZona) {
        this.idPromocionXZona = idPromocionXZona;
    }

    public Promocion getPromocion() {
        return promocion;
    }

    public void setPromocion(Promocion promocion) {
        this.promocion = promocion;
    }

    public Zona getZona() {
        return zona;
    }

    public void setZona(Zona zona) {
        this.zona = zona;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}
