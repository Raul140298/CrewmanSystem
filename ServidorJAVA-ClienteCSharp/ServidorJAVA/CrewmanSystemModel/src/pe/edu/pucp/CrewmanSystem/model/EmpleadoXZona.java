package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class EmpleadoXZona {
    private int idVendedorXZona;
    private Zona zona;
    private Empleado empleado;
    private Date fechaInicio;
    private Date fechaFin;
    private boolean activo;
    
    public EmpleadoXZona(){
        zona=new Zona();
        empleado=new Empleado();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaInicio=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.fechaFin=null;
        this.activo=true;
    }
    
    public EmpleadoXZona(Zona zona,Empleado empleado){
        this.zona=zona;
        this.empleado=empleado;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaInicio=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.activo=true;
    }
    
    public int getIdVendedorXZona() {
        return idVendedorXZona;
    }

    public void setIdVendedorXZona(int idVendedorXZona) {
        this.idVendedorXZona = idVendedorXZona;
    }

    public Zona getZona() {
        return zona;
    }

    public void setZona(Zona zona) {
        this.zona = zona;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
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
