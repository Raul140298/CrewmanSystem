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

    public ArrayList<LineaPedido> getLineasPedidos() {
        return lineasPedidos;
    }

    public void setLineasPedidos(ArrayList<LineaPedido> lineasPedidos) {
        this.lineasPedidos = lineasPedidos;
    }
    
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

    public void setEmpleado(Empleado empleado){
        this.empleado=empleado;
    }

    public Empleado getEmpleado(){
        return this.empleado;
    }

    public void setCliente(Cliente empresa){
        this.cliente=empresa;
    }

    public Cliente getCliente(){
        return this.cliente;
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
    //METODOS
    public ArrayList<Factura> obtenerListaFactura(){
        return this.facturas;
    }
    
    public void agregarFactura(Factura factura){
        facturas.add(factura);
        montoPagar=montoTotal-factura.getMonto();
        if(montoPagar==0) estadoPedido=EstadoPedido.FINALIZADO;
    }
    
    public ArrayList<GuiaRemision> obtenerListaGuiaRemision(){
        return this.guiasRemision;
    }
    
    public void agregarGuiaRemision(GuiaRemision guiaRemision){
        guiasRemision.add(guiaRemision);
    }
    
    public ArrayList<Queja> obtenerListaQueja(){
        return this.quejas;
    }
    
    public void agregarQueja(Queja queja){
        quejas.add(queja);
    }

    public ArrayList<LineaPedido> obtenerListaLineaPedidos(){
        return this.lineasPedidos;
    }
    
    public void agregarLineaPedido(LineaPedido lineaPedido){
        lineasPedidos.add(lineaPedido);    
    }

    public double calcularMontoTotal(){
        for(LineaPedido l:lineasPedidos){
          montoTotal+=l.calcularMontoSubTotal();
        }
        montoPagar=montoTotal;
        return montoTotal;
    }
    
    public void evaluarPedido(){
        if(this.getCliente().getLineaCredito().getMontoLineaCredito() < this.montoTotal)
        {
          this.setTipoPedido(TipoPedido.BORRADOR);
        }
    }
        
    public void cancelarPedido(){
//        estadoPedido=estadoPedido.CANCELADO;
//        FacturaDAO misFacturas=new FacturaMySQL();
//        ArrayList<Factura> facturas=misFacturas.listar(this.idPedido);
//        
//        NotaDeCreditoDAO daoNotasCredito=new NotaDeCreditoMySQL();
//        for(Factura f:facturas){
//            NotaDeCredito notaCredito = new NotaDeCredito(cliente, f);
//            daoNotasCredito.insertar(notaCredito);
//        }
    }
}