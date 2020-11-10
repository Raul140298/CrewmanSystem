package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class Factura{
    private int idFactura;
    private double monto;
    private String observacion;
    private Date fechaEmision;
    private Date fechaVencimiento;
    private double impuestos;
    private boolean anulado;
    private boolean estadoPagar;
    private Pedido pedido;
    private NotaDeCredito notaCredito;
    private ArrayList<NotaDeCredito> listaNotaDeCredito;

    public Factura(){
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaEmision=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.fechaVencimiento=null;
        this.anulado=false;
        this.estadoPagar=true;
        listaNotaDeCredito=new ArrayList<>();   
    } 
    public Factura(Pedido pedido,double monto,String observacion,double impuestos,Date fechaVencimiento){
        this.monto=monto;
        this.observacion=observacion;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaEmision=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.impuestos=impuestos;
        this.pedido=pedido;
        this.fechaVencimiento=fechaVencimiento;
        this.anulado=false;
        this.estadoPagar=true;
        listaNotaDeCredito=new ArrayList<>();          
    }

    public int getIdFactura() {
        return idFactura;
    }

    public void setIdFactura(int idFactura) {
        this.idFactura = idFactura;
    }

    public double getMonto() {
        return monto;
    }

    public void setMonto(double monto) {
        this.monto = monto;
    }

    public String getObservacion() {
        return observacion;
    }

    public void setObservacion(String observacion) {
        this.observacion = observacion;
    }

    public Date getFechaEmision() {
        return fechaEmision;
    }

    public void setFechaEmision(Date fechaEmision) {
        this.fechaEmision = fechaEmision;
    }

    public Date getFechaVencimiento() {
        return fechaVencimiento;
    }

    public void setFechaVencimiento(Date fechaVencimiento) {
        this.fechaVencimiento = fechaVencimiento;
    }

    public double getImpuestos() {
        return impuestos;
    }

    public void setImpuestos(double impuestos) {
        this.impuestos = impuestos;
    }

    public boolean getAnulado() {
        return anulado;
    }

    public void setAnulado(boolean anulado) {
        this.anulado = anulado;
    }

    public boolean getEstadoPagar() {
        return estadoPagar;
    }

    public void setEstadoPagar(boolean estadoPagar) {
        this.estadoPagar = estadoPagar;
    }

    public Pedido getPedido() {
        return pedido;
    }

    public void setPedido(Pedido pedido) {
        this.pedido = pedido;
    }

    public NotaDeCredito getNotaCredito() {
        return notaCredito;
    }

    public void setNotaCredito(NotaDeCredito notaCredito) {
        this.notaCredito = notaCredito;
    }

    public ArrayList<NotaDeCredito> getListaNotaDeCredito() {
        return listaNotaDeCredito;
    }

    public void setListaNotaDeCredito(ArrayList<NotaDeCredito> listaNotaDeCredito) {
        this.listaNotaDeCredito = listaNotaDeCredito;
    }
    
    
}