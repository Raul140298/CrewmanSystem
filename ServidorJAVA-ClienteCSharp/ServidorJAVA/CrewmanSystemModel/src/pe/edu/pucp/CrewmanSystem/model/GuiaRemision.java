package pe.edu.pucp.CrewmanSystem.model;

import java.util.Date;

public class GuiaRemision{
    //ATRIBUTOS
    private int idGuiaRemision;
    private Pedido pedido;
    private String motivoTraslado;
    private Date fechaRegistro;
    private Date fechaTraslado;
    
    //CONSTRUCTORES
    public GuiaRemision(){
        pedido=new Pedido();
        this.fechaRegistro=new Date();
    }
    public GuiaRemision(Pedido pedido,String motivoTraslado){
      this.pedido=pedido;
      this.motivoTraslado=motivoTraslado;
      this.fechaRegistro=new Date();
    }
    
    //GETTERS y SETTERS

    public int getIdGuiaRemision() {
        return idGuiaRemision;
    }

    public void setIdGuiaRemision(int idGuiaRemision) {
        this.idGuiaRemision = idGuiaRemision;
    }

    public Pedido getPedido() {
        return pedido;
    }

    public void setPedido(Pedido pedido) {
        this.pedido = pedido;
    }

    public String getMotivoTraslado() {
        return motivoTraslado;
    }

    public void setMotivoTraslado(String motivoTraslado) {
        this.motivoTraslado = motivoTraslado;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public Date getFechaTraslado() {
        return fechaTraslado;
    }

    public void setFechaTraslado(Date fechaTraslado) {
        this.fechaTraslado = fechaTraslado;
    }
    

}