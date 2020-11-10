package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Queja{
    //ATRIBUTOS
    private int idQueja;
    private Pedido pedido;
    private String descripcion;
    private Date fechaCreacion;
  
    //CONSTRUCTORES
    public Queja(){
        pedido=new Pedido();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaCreacion=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    
    public Queja(Pedido pedido,String descripcion){
        this.pedido=pedido;
        this.descripcion=descripcion;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaCreacion=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    //GETTERS y SETTERS
    public int getIdQueja() {
        return idQueja;
    }

    public void setIdQueja(int idQueja) {
        this.idQueja = idQueja;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Pedido getPedido() {
        return pedido;
    }

    public void setPedido(Pedido pedido) {
        this.pedido = pedido;
    }
}