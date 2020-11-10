package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Visita {
    private int idVisita;
    private Cliente cliente;
    private Empleado empleado;
    private Cartera cartera;
    private Date fechaRegistro;
    private boolean estado;
    private boolean activo;

    public Visita() {
        cliente=new Cliente();
        empleado=new Empleado();
        cartera=new Cartera();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaRegistro=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        estado=false;
        activo = true;
    }

    public Visita(Cliente cliente, Empleado empleado, Cartera cartera, Date fecha_registro) {
        this.cliente = cliente;
        this.empleado = empleado;
        this.cartera = cartera;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaRegistro=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.estado=false;
        this.activo = true;
    }    

    public int getIdVisita() {
        return idVisita;
    }

    public void setIdVisita(int visita) {
        this.idVisita = visita;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
    }

    public Cartera getCartera() {
        return cartera;
    }

    public void setCartera(Cartera cartera) {
        this.cartera = cartera;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
