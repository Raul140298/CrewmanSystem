package pe.edu.pucp.CrewmanSystem.model;

import java.util.Date;

public class GuiaRemision{
    //ATRIBUTOS
    private int id;
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
    public void setFechaTraslado(Date fechaTraslado){
      this.fechaTraslado=fechaTraslado;
    }
    
    public Date getFechaTraslado(){
      return this.fechaTraslado;
    }
    
    public void setFechaRegistro(Date fechaRegistro){
      this.fechaRegistro=fechaRegistro;
    }
    
    public Date getFechaRegistro(){
      return this.fechaRegistro;
    }
    
    public void setPedido(Pedido pedido){
      this.pedido=pedido;
    }
    
    public Pedido getPedido(){
      return this.pedido;
    }
    
    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public String getMotivoTraslado()
    {
        return motivoTraslado;
    }

    public void setMotivoTraslado(String motivoTraslado)
    {
        this.motivoTraslado = motivoTraslado;
    }

}