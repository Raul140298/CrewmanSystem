package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class ClienteXZona {
    private int idClienteXZona;
    private Cliente cliente;
    private Zona zona;
    private Date fechaInicio;
    private Date fechaFin;
    private boolean activo;
    
    public ClienteXZona(){
        this.cliente=new Cliente();
        this.zona=new Zona();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaInicio=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.fechaFin=null;
        this.activo=true;
    }
    
    public ClienteXZona(Cliente cliente,Zona zona){
        this.cliente=cliente;
        this.zona=zona;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaInicio=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.fechaFin=null;
        this.activo=true;
    }
    
    public int getIdClienteXZona() {
        return idClienteXZona;
    }

    public void setIdClienteXZona(int idClienteXZona) {
        this.idClienteXZona = idClienteXZona;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Zona getZona() {
        return zona;
    }

    public void setZona(Zona zona) {
        this.zona = zona;
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
}
