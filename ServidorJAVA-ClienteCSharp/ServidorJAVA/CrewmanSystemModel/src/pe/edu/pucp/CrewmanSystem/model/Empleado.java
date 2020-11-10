package pe.edu.pucp.CrewmanSystem.model;

import java.util.ArrayList;
import java.util.Date;

public class Empleado extends Persona{
    private int idEmpleado;
    private Empleado jefe;
    private String usuario;
    private String contraseña;
    private Zona zona;
    private Date fechaCreacion;
    private double sumVentas;
    private double objetivoVentas;
    private Cargo cargo;
    private ArrayList<Pedido> listaPedidos;
    private ArrayList<Empleado> listaEmpleados;
    private Cartera cartera;
    private int[]cords = new int[2];
    
    public Empleado(){
        jefe=null;
        zona=new Zona();
        cargo = new Cargo();
        cartera=new Cartera();
        objetivoVentas=0.0;
        sumVentas = 0.0;
        listaPedidos= new ArrayList<>();
        listaEmpleados=new ArrayList<>();
    }
    public Empleado(Cargo cargo, String dni, String nombre, String apellidoPaterno,String apellidoMaterno, char genero,String telefono1, String telefono2, String correo) 
    {
        super(dni,nombre,apellidoPaterno,apellidoMaterno, telefono1, telefono2, correo);
        setGenero(genero);
        this.jefe=null;
        this.zona=new Zona();
        cartera=new Cartera();
        this.objetivoVentas=0.0;
        this.sumVentas = 0.0;
        this.cargo = cargo;
        this.listaPedidos= new ArrayList<>();
        this.listaEmpleados=new ArrayList<>();
    }

    public int getIdEmpleado()
    {
        return idEmpleado;
    }

    public void setIdEmpleado(int idEmpleado)
    {
        this.idEmpleado = idEmpleado;
    }

    public Empleado getJefe()
    {
        return jefe;
    }

    public void setJefe(Empleado jefe)
    {
        this.jefe = jefe;
    }

    public String getUsuario()
    {
        return usuario;
    }

    public void setUsuario(String usuario)
    {
        this.usuario = usuario;
    }

    public String getContraseña()
    {
        return contraseña;
    }

    public void setContraseña(String contraseña)
    {
        this.contraseña = contraseña;
    }

    public Zona getZona()
    {
        return zona;
    }

    public void setZona(Zona zona)
    {
        this.zona = zona;
    }

    public Date getFechaCreacion()
    {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion)
    {
        this.fechaCreacion = fechaCreacion;
    }

    public double getSumVentas()
    {
        return sumVentas;
    }

    public void setSumVentas(double sumVentas)
    {
        this.sumVentas = sumVentas;
    }

    public double getObjetivoVentas()
    {
        return objetivoVentas;
    }

    public void setObjetivoVentas(double objetivoVentas)
    {
        this.objetivoVentas = objetivoVentas;
    }

    public Cargo getCargo()
    {
        return cargo;
    }

    public void setCargo(Cargo cargo)
    {
        this.cargo = cargo;
    }

    public ArrayList<Pedido> getListaPedidos()
    {
        return listaPedidos;
    }

    public void setListaPedidos(ArrayList<Pedido> listaPedidos)
    {
        this.listaPedidos = listaPedidos;
    }

    public ArrayList<Empleado> getListaEmpleados()
    {
        return listaEmpleados;
    }

    public void setListaEmpleados(ArrayList<Empleado> listaEmpleados)
    {
        this.listaEmpleados = listaEmpleados;
    }

    public Cartera getCartera()
    {
        return cartera;
    }

    public void setCartera(Cartera cartera)
    {
        this.cartera = cartera;
    }

    public int[] getCords()
    {
        return cords;
    }

    public void setCords(int[] cords)
    {
        this.cords = cords;
    }
    
    public void asignarPersona(Persona persona)
    {
      
    }
        
    public void registrarVisita(Cliente cliente){
//        EmpleadoDAO daoEmpleado=new EmpleadoMySQL();
//        daoEmpleado.registrarVisita(getDni(),cliente.getRuc());
    }
    
    public void generarCartera(){
//        ClienteDAO clientes=new ClienteMySQL();
//        ArrayList<Cliente> misClientes=clientes.obtenerClientesSinCartera();
//        
//        Cartera cartera=new Cartera();
//        
//        for(Cliente c : misClientes){
//            if(c.getZona().getIdZona()==zona.getIdZona()){
//                cartera.obtenerListaCliente().add(c);
//            }
//        }
//        //ASIGNO LA CARTERA AL ATRIBUTO Y SETEO EL VENDEDOR A LA MISMA
//        this.cartera = cartera;
//        this.cartera.setEmpleado(this);
    }
    
    public void generarReporteCumplimientoVentas(){
//        EmpleadoDAO daoEmpleado=new EmpleadoMySQL();
//        ArrayList<Empleado> empleadoes=daoEmpleado.listar();
//        
//        System.out.println("REPORTE DE CUMPLIMIENTO DE VENTAS");
//        System.out.println("===============================================================");
//        System.out.println("ID_VENDEDOR   NOMBRE  APELLIDO_PATERNO  APELLIDO_MATERNO  SUMA_VENTAS  OBJETIVO_VENTAS");
//        System.out.println("===============================================================");
//        for(Empleado v:empleadoes){
//            System.out.println(v.getDni()+"  "+v.getNombre()+"  "+v.getApellidoPaterno()+"  "+v.getApellidoMaterno()+" "+v.getSumVentas()+"  "+v.getObjetivoVentas());    
//        }
    }

    public void generarReportePedidos(){
//        PedidoDAO daoPedido=new PedidoMySQL();
//        ArrayList<Pedido> pedidos=daoPedido.generarReporte(getDni());
//        
//        System.out.println("REPORTE DE PEDIDOS");
//        System.out.println("========================================================================================================");
//        System.out.println("ID_PEDIDO   FECHA_REGISTRO  FECHA_ESTIMADA  FECHA_REAL  MONTO_A_PAGAR   DIRECCION   TIPO    ESTADO");
//        System.out.println("========================================================================================================");
//        for(Pedido p : pedidos){
//            SimpleDateFormat spd=new SimpleDateFormat("dd-MM-yyyy");
//            String fechaRegistro=spd.format(p.getFechaRegistro());
//            String fechaReal=spd.format(p.getFechaReal());
//            String fechaEstimada=spd.format(p.getFechaEstim());
//            System.out.println(p.getIdPedido()+"  "+fechaRegistro+"  "+fechaEstimada+"  "+fechaReal+"  "+p.getMontoPagar()+"  "+p.getDireccionEntrega()+"  "+p.getTipoPedido()+"  "+p.getEstadoPedido());            
//        }
    }
}