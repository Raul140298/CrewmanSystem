package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class NotaDeCredito{
    //ATRIBUTOS
    private int idNotaDeCredito;
    private Factura factura;
    private Date fechaCreacion;
    private double monto;
    private boolean activo;

    public NotaDeCredito(){
        factura=new Factura();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaCreacion=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.monto=0.0;
        this.activo = true;
    }
    
    public NotaDeCredito(Factura factura){
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaCreacion=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.monto=factura.getMonto();
        this.factura=factura;
        this.activo = true;
    }
    //GETTERS y SETTERS

    public int getIdNotaDeCredito() {
        return idNotaDeCredito;
    }

    public void setIdNotaDeCredito(int idNotaDeCredito) {
        this.idNotaDeCredito = idNotaDeCredito;
    }

    public Factura getFactura() {
        return factura;
    }

    public void setFactura(Factura factura) {
        this.factura = factura;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public double getMonto() {
        return monto;
    }

    public void setMonto(double monto) {
        this.monto = monto;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}