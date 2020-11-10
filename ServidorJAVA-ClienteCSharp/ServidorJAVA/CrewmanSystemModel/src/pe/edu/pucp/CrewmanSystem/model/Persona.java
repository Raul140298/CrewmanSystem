package pe.edu.pucp.CrewmanSystem.model;

public class Persona {
    private int idPersona;
    private String dni;
    private String nombre;
    private String apellidoPaterno;
    private String apellidoMaterno;
    private String correo;
    private String telefono1;
    private String telefono2;
    private char genero;
    private boolean activo;
    
    public Persona(){
        this.activo=true;
    }
    
    public Persona(String dni,String nombre,String apellidoPaterno,String apellidoMaterno, String telefono1, String telefono2, String correo){
        this.dni=dni;
        this.nombre=nombre;
        this.apellidoPaterno=apellidoPaterno;
        this.apellidoMaterno=apellidoMaterno;
        this.telefono1=telefono1;
        this.telefono2=telefono2;
        this.correo=correo;
        this.activo=true;
    }

    public int getIdPersona()
    {
        return idPersona;
    }

    public void setIdPersona(int idPersona)
    {
        this.idPersona = idPersona;
    }

    public String getDni()
    {
        return dni;
    }

    public void setDni(String dni)
    {
        this.dni = dni;
    }

    public String getNombre()
    {
        return nombre;
    }

    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }

    public String getApellidoPaterno()
    {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno)
    {
        this.apellidoPaterno = apellidoPaterno;
    }

    public String getApellidoMaterno()
    {
        return apellidoMaterno;
    }

    public void setApellidoMaterno(String apellidoMaterno)
    {
        this.apellidoMaterno = apellidoMaterno;
    }

    public String getCorreo()
    {
        return correo;
    }

    public void setCorreo(String correo)
    {
        this.correo = correo;
    }

    public String getTelefono1()
    {
        return telefono1;
    }

    public void setTelefono1(String telefono1)
    {
        this.telefono1 = telefono1;
    }

    public String getTelefono2()
    {
        return telefono2;
    }

    public void setTelefono2(String telefono2)
    {
        this.telefono2 = telefono2;
    }

    public char getGenero()
    {
        return genero;
    }

    public void setGenero(char genero)
    {
        this.genero = genero;
    }

    public boolean isActivo()
    {
        return activo;
    }

    public void setActivo(boolean activo)
    {
        this.activo = activo;
    }
    
    public void asignarPersona(Persona persona){
        this.idPersona=persona.getIdPersona();
        this.dni=persona.getDni();
        this.nombre=persona.getNombre();
        this.apellidoPaterno=persona.getApellidoPaterno();
        this.apellidoMaterno=persona.getApellidoMaterno();
        this.correo=persona.getCorreo();
        this.telefono1=persona.getTelefono1();
        this.telefono2=persona.getTelefono2();
        this.genero=persona.getGenero();
    }
    
    public Persona obtenerPersona(){
        Persona persona = new Persona();
        persona.setIdPersona(getIdPersona());
        persona.setDni(getDni());
        persona.setNombre(getNombre());
        persona.setApellidoPaterno(getApellidoPaterno());
        persona.setApellidoMaterno(getApellidoMaterno());
        persona.setTelefono1(getTelefono1());
        persona.setTelefono2(getTelefono2());
        persona.setCorreo(getCorreo());
        persona.setGenero(getGenero());
        return persona;
    }
}
