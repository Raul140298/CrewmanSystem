package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class LineaCredito{
    //ATRIBUTOS
    private int idLineaCredito;
    private Cliente cliente;
    private Date fechaCreacion;
    private Empleado responsable;
    private double montoLineaCredito;
    private double montoUtilizado;
    private boolean aprobado;
    private String motivo;
    
    //CONSTRUCTORES
    public LineaCredito(){
        montoUtilizado=0.0;
        montoLineaCredito=0.0;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaCreacion=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    
    public LineaCredito(Cliente cliente,Empleado responsable,boolean aprobado,double montoLineaCredito,String motivo){
        this.cliente=cliente;
        this.responsable=responsable;
        this.montoLineaCredito=montoLineaCredito;
        this.montoUtilizado=0.0;        
        this.motivo=motivo;
        this.aprobado=aprobado;        
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaCreacion=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    //GETTERS y SETTERS

    public int getIdLineaCredito() {
        return idLineaCredito;
    }

    public void setIdLineaCredito(int idLineaCredito) {
        this.idLineaCredito = idLineaCredito;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Empleado getResponsable() {
        return responsable;
    }

    public void setResponsable(Empleado responsable) {
        this.responsable = responsable;
    }

    public double getMontoLineaCredito() {
        return montoLineaCredito;
    }

    public void setMontoLineaCredito(double montoLineaCredito) {
        this.montoLineaCredito = montoLineaCredito;
    }

    public double getMontoUtilizado() {
        return montoUtilizado;
    }

    public void setMontoUtilizado(double montoUtilizado) {
        this.montoUtilizado = montoUtilizado;
    }

    public boolean getAprobado() {
        return aprobado;
    }

    public void setAprobado(boolean aprobado) {
        this.aprobado = aprobado;
    }

    public String getMotivo() {
        return motivo;
    }

    public void setMotivo(String motivo) {
        this.motivo = motivo;
    }

    
    
}