package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Cliente {
    private int idCliente;
    private String ruc;
    private LineaCredito lineaCredito;
    private PersonaContacto personaContacto;
    private Zona zona;
    private Cartera cartera;
    private String razonSocial;
    private Date fechaRegistro;
    private Date fechaUltimaCompra;
    private String grupo;
    private String tipoEmpresa;
    private String direccion;
    private boolean activo;
    private int[]cords = new int[2];

    public Cliente(){
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaRegistro=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        cartera=new Cartera();
        lineaCredito=new LineaCredito();
        personaContacto=new PersonaContacto();
        zona=new Zona();
        fechaUltimaCompra=null;
        activo=true;
    }
    
    public Cliente(String ruc, String razonSocial, String grupo, String direccion) {
        this.ruc = ruc;
        this.razonSocial = razonSocial;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaRegistro=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        cartera=new Cartera();
        this.fechaUltimaCompra=null;
        lineaCredito=new LineaCredito();
        personaContacto=new PersonaContacto();
        zona=new Zona();
        this.grupo = grupo;
        this.direccion = direccion;
    }

    public int getIdCliente() {
        return idCliente;
    }

    public void setIdCliente(int idCliente) {
        this.idCliente = idCliente;
    }
    
    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public LineaCredito getLineaCredito() {
        return lineaCredito;
    }

    public void setLineaCredito(LineaCredito lineaCredito) {
        this.lineaCredito = lineaCredito;
    }

    public PersonaContacto getPersonaContacto() {
        return personaContacto;
    }

    public void setPersonaContacto(PersonaContacto personaContacto) {
        this.personaContacto = personaContacto;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public Date getFechaUltimaCompra() {
        return fechaUltimaCompra;
    }

    public void setFechaUltimaCompra(Date fechaUltimaCompra) {
        this.fechaUltimaCompra = fechaUltimaCompra;
    }

    public String getGrupo() {
        return grupo;
    }

    public void setGrupo(String grupo) {
        this.grupo = grupo;
    }

    public String getTipoEmpresa() {
        return tipoEmpresa;
    }

    public void setTipoEmpresa(String tipoEmpresa) {
        this.tipoEmpresa = tipoEmpresa;
    }

    public Zona getZona() {
        return zona;
    }
    
    public void setZona(Zona zona) {
        this.zona = zona;
    }    

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public void setCords(int x, int y) {
        this.cords[0]=x;
        this.cords[1]=y;
    }
    
    public int[] getCords() {
        return this.cords;
    }

    public Cartera getCartera() {
        return cartera;
    }

    public void setCartera(Cartera cartera) {
        this.cartera = cartera;
    }
    
    
}
