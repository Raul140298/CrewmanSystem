package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class Cartera{
    private int idCartera;
    private Empleado empleado;
    private Date fechaInicio;
    private Date fechaFin;
    private boolean activo;
    private ArrayList<Visita> listaVisita;
    
    //CONSTRUCTORES
    public Cartera(){
        idCartera=0;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaInicio=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        fechaFin=null;
        listaVisita=new ArrayList<>();
        this.activo=true;
    }
    
    //GETTERS y SETTERS

    public int getIdCartera() {
        return idCartera;
    }

    public void setIdCartera(int idCartera) {
        this.idCartera = idCartera;
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

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public ArrayList<Visita> getListaVisita() {
        return listaVisita;
    }

    public void setListaVisita(ArrayList<Visita> listaVisita) {
        this.listaVisita = listaVisita;
    }
}