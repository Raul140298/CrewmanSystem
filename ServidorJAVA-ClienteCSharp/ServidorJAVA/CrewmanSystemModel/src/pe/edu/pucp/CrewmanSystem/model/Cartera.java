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

    public int getIdCartera()
    {
        return idCartera;
    }

    public void setIdCartera(int idCartera)
    {
        this.idCartera = idCartera;
    }

    public Empleado getEmpleado()
    {
        return empleado;
    }

    public void setEmpleado(Empleado empleado)
    {
        this.empleado = empleado;
    }

    public Date getFechaInicio()
    {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio)
    {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin()
    {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin)
    {
        this.fechaFin = fechaFin;
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
    
    public void generarRuta(Empleado empleado){
        //En lugar de recibir un vendedor, debería recibir unas coordenadas. Así, el vendedor podría generar su ruta desde cualquier posiicon
        //en la que se encuentre. También le permitiría poder generar nuevas rutas, después de haber completado una ruta parcial y haber
        //regresado a su hogar o alguna otra posición inicial
        //CREACION DE MATRIZ DE ADYACENCIA
        //Grafo grafo = new Grafo(empleado,this.listaVisita);
        //grafo.imprimeMatrix();
        //CREACION DE TSP
        //grafo.generarRuta(this.listaVisita);
    }
}