package pe.edu.pucp.CrewmanSystem.model;

public class PersonaContacto extends Persona{
    //ATRIBUTOS
    private int idPersonaContacto;
    private Cliente cliente;
    private String cargo;
    private boolean activo;
    
    //CONSTRUCTORES
    public PersonaContacto(){
        activo=true;
    }
    
    public PersonaContacto(int idPersonaContacto, Cliente cliente, String cargo,String dni, String nombre, String apellidoPaterno,String apellidoMaterno, String telefono1, String telefono2, String correo) 
    {
        super(dni,nombre,apellidoPaterno,apellidoMaterno, telefono1, telefono2, correo);
        this.idPersonaContacto = idPersonaContacto;
        this.cliente = cliente;
        this.cargo = cargo;
        this.activo = true;
    }
    
    public int getIdPersonaContacto()
    {
        return idPersonaContacto;
    }

    public void setIdPersonaContacto(int idPersonaContacto)
    {
        this.idPersonaContacto = idPersonaContacto;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }    
    
    public String getCargo()
    {
        return cargo;
    }

    public void setCargo(String cargo)
    {
        this.cargo = cargo;
    }
}
