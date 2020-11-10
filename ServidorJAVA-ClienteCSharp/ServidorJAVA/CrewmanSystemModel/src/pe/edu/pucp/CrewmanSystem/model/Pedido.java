package pe.edu.pucp.CrewmanSystem.model;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class Pedido{
    //ATRIBUTOS
    private int idPedido;
    private Date fechaAprobado;
    private Date fechaEstim;
    private Date fechaRegistro;
    private double montoPagar;
    private double montoTotal;
    private String direccionEntrega;
    private TipoPedido tipoPedido;
    private EstadoPedido estadoPedido;
    private Cliente cliente;
    private Empleado empleado;
    private ArrayList<LineaPedido> lineasPedidos;
    private ArrayList<Queja> quejas;
    private ArrayList<GuiaRemision> guiasRemision;
    private ArrayList<Factura> facturas;

    public Pedido(){
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaRegistro=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        fechaAprobado=null;
        fechaEstim=null;
        montoTotal=0.0;
        montoPagar=0.0;
        tipoPedido=TipoPedido.BORRADOR;
        estadoPedido=EstadoPedido.ESPERANDO;
        cliente=new Cliente();
        empleado=new Empleado();
        lineasPedidos=new ArrayList<>();
        quejas=new ArrayList<>();
        guiasRemision=new ArrayList<>();
        facturas=new ArrayList<>();
    }
  
    public Pedido(Cliente cliente,Empleado empleado,String direccionEntrega){
        this.cliente=cliente;
        this.empleado=empleado;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        try {
            this.fechaRegistro=formato.parse(formato.format(new Date()));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        this.direccionEntrega = direccionEntrega;
        this.fechaAprobado=null;
        this.fechaEstim=null;
        this.montoPagar = 0.0;
        this.montoTotal = 0.0;
        this.tipoPedido = tipoPedido.BORRADOR;
        this.estadoPedido=EstadoPedido.ESPERANDO;
        lineasPedidos=new ArrayList<>();
        quejas=new ArrayList<>();
        guiasRemision=new ArrayList<>();
        facturas=new ArrayList<>();
    }
    //GETTERS y SETTERS

    public int getIdPedido() {
        return idPedido;
    }

    public void setIdPedido(int idPedido) {
        this.idPedido = idPedido;
    }

    public Date getFechaAprobado() {
        return fechaAprobado;
    }

    public void setFechaAprobado(Date fechaAprobado) {
        this.fechaAprobado = fechaAprobado;
    }

    public Date getFechaEstim() {
        return fechaEstim;
    }

    public void setFechaEstim(Date fechaEstim) {
        this.fechaEstim = fechaEstim;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public double getMontoPagar() {
        return montoPagar;
    }

    public void setMontoPagar(double montoPagar) {
        this.montoPagar = montoPagar;
    }

    public double getMontoTotal() {
        return montoTotal;
    }

    public void setMontoTotal(double montoTotal) {
        this.montoTotal = montoTotal;
    }

    public String getDireccionEntrega() {
        return direccionEntrega;
    }

    public void setDireccionEntrega(String direccionEntrega) {
        this.direccionEntrega = direccionEntrega;
    }

    public TipoPedido getTipoPedido() {
        return tipoPedido;
    }

    public void setTipoPedido(TipoPedido tipoPedido) {
        this.tipoPedido = tipoPedido;
    }

    public EstadoPedido getEstadoPedido() {
        return estadoPedido;
    }

    public void setEstadoPedido(EstadoPedido estadoPedido) {
        this.estadoPedido = estadoPedido;
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

    public ArrayList<LineaPedido> getLineasPedidos() {
        return lineasPedidos;
    }

    public void setLineasPedidos(ArrayList<LineaPedido> lineasPedidos) {
        this.lineasPedidos = lineasPedidos;
    }

    public ArrayList<Queja> getQuejas() {
        return quejas;
    }

    public void setQuejas(ArrayList<Queja> quejas) {
        this.quejas = quejas;
    }

    public ArrayList<GuiaRemision> getGuiasRemision() {
        return guiasRemision;
    }

    public void setGuiasRemision(ArrayList<GuiaRemision> guiasRemision) {
        this.guiasRemision = guiasRemision;
    }

    public ArrayList<Factura> getFacturas() {
        return facturas;
    }

    public void setFacturas(ArrayList<Factura> facturas) {
        this.facturas = facturas;
    }

}