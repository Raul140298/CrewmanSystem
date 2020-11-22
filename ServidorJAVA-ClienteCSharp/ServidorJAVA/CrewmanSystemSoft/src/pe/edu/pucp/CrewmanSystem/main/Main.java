package pe.edu.pucp.CrewmanSystem.main;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.CrewmanSystem.dao.*;
import pe.edu.pucp.CrewmanSystem.model.*;
import pe.edu.pucp.CrewmanSystem.mysql.*;

public class Main{
    private static SimpleDateFormat sdf=new SimpleDateFormat("dd-MM-yyyy");
    private static FamiliaDAO daoFamilia = new FamiliaMySQL();
    private static ArrayList<Familia> misFamilias;
    private static SubFamiliaDAO daoSubFamilia = new SubFamiliaMySQL();
    private static ArrayList<SubFamilia> misSubFamilias;
    private static MarcaDAO daoMarca = new MarcaMySQL();
    private static ArrayList<Marca> misMarcas;
    private static ZonaDAO daoZona = new ZonaMySQL();
    private static ArrayList<Zona> misZonas;
    private static ClienteDAO daoCliente = new ClienteMySQL();
    private static ArrayList<Cliente> misClientes;
    private static LineaCreditoDAO daoLineaCredito = new LineaCreditoMySQL();
    private static EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
    private static ArrayList<Empleado> misEmpleados;
    private static ProductoDAO daoProducto=new ProductoMySQL();
    private static ArrayList<Producto> misProductos;
    private static ProductoXZonaDAO daoProductoXZona=new ProductoXZonaMySQL();
    private static ArrayList<ProductoXZona> misProductosXZonas;
    private static PromocionDAO daoPromocion=new PromocionMySQL();
    private static ArrayList<Promocion> misPromociones;
    private static PromocionXProductoDAO daoPromocionXProducto=new PromocionXProductoMySQL();
    private static ArrayList<PromocionXProducto> misPromocionXProducto;
    private static PedidoDAO daoPedido=new PedidoMySQL();
    private static ArrayList<Pedido> misPedidos;
    private static LineaPedidoDAO daoLineaPedido=new LineaPedidoMySQL();
    private static ArrayList<LineaPedido> misLineasDePedido;
    private static CarteraDAO daoCartera=new CarteraMySQL();
    private static ArrayList<Cartera> misCarteras;
    private static VisitaDAO daoVisita=new VisitaMySQL();
    private static ArrayList<Visita> misVisitas;
    private static FacturaDAO daoFactura = new FacturaMySQL();
    private static ArrayList<Factura> misFacturas;
    private static NotaDeCreditoDAO daoNotaDeCredito = new NotaDeCreditoMySQL();
    private static ArrayList<NotaDeCredito> misNotasDeCredito;
    private static GuiaRemisionDAO daoGuiaRemision = new GuiaRemisionMySQL();
    private static ArrayList<GuiaRemision> misGuiasDeRemision;
    private static QuejaDAO daoQueja = new QuejaMySQL();
    private static ArrayList<Queja> misQuejas;
    private static PersonaDAO daoPersona = new PersonaMySQL();
    private static PersonaContactoDAO daoPersonaContacto = new PersonaContactoMySQL();
    
    public static void main(String[] args) {
//        gestionarFamilias();
//        gestionarSubFamilias();
//        gestionarMarcas();
//        gestionarZonas();
//       gestionarClientes();
//        gestionarEmpleados();
//        gestionarProductos();
//        gestionarProductoXZona();
//      gestionarPromociones();
//       gestionarPromocionXProducto();
//        gestionarPedidos();
//        gestionarLineasDePedido();
//        gestionarFacturas();
//        gestionarNotasDeCredito();
//        gestionarGuiasDeRemision();
//        gestionarQuejas();

//        misZonas = daoZona.listar();
//        Promocion promo = new Promocion();
//        promo.setNombre("Promocion por fin de semana");
//        promo.setDescripcion("Aprovecha por este fin de temporada");
//        try{
//            promo.setFechaInicio(sdf.parse("12-11-2020"));
//            promo.setFechaFin(sdf.parse("23-12-2020"));
//        }catch(Exception e){
//            System.out.println("MAL");
//        }
//        promo.setZona(misZonas.get(2));
//        misPromocionXProducto = new ArrayList<>();
//        PromocionXProducto pxp = new PromocionXProducto();
//        pxp.set
//        
//        misPromocionXProducto.add(e);
//        promo.setListaPromocionXProducto(misPromocionXProducto);


//        misEmpleados = daoEmpleado.listarPorJefeVentas(21, "", "", "");
//        for(Empleado e : misEmpleados){
//            System.out.println(e.getIdEmpleado()+" "+e.getNombre()+" "+e.getApellidoPaterno()+""+e.getObjetivoVentas()+" "+e.getZona().getIdZona()+" "+e.getZona().getNombre());
//        }
//        Empleado miEmpleado = misEmpleados.get(1);
//        
//        miEmpleado.setApellidoPaterno("Cardozo");
//        miEmpleado.setObjetivoVentas(3500);
//        miEmpleado.getZona().setIdZona(151);
//        
//        int resultado = daoEmpleado.actualizar(miEmpleado);
//        System.out.println(resultado);
//        misEmpleados = daoEmpleado.listarPorJefeVentas(21, "", "", "");
//        for(Empleado e : misEmpleados){
//            System.out.println(e.getIdEmpleado()+" "+e.getNombre()+" "+e.getApellidoPaterno()+""+e.getObjetivoVentas()+" "+e.getZona().getIdZona()+" "+e.getZona().getNombre());
//        }

        //Zona zona = daoZona.mostrarZonaCliente(14);
//        Pedido pedido = new Pedido();
//        pedido.setIdPedido(54);
//        pedido.setDireccionEntrega("Almacen 2 javier prado");
//        pedido.setMontoTotal(205);
//        misLineasDePedido = new ArrayList<LineaPedido>();
//        LineaPedido lp1 = new LineaPedido();
//        lp1.setCantidad(25);
//        lp1.setMontoSubTotal(180);
//        lp1.getProductoXZona().setIdProductoXZona(68);
//        LineaPedido lp2 = new LineaPedido();
//        lp2.setCantidad(10);
//        lp2.setMontoSubTotal(25);
//        lp2.getProductoXZona().setIdProductoXZona(69);
//        misLineasDePedido.add(lp1);
//        misLineasDePedido.add(lp2);
//        pedido.setLineasPedidos(misLineasDePedido);
//        daoPedido.actualizar(pedido);
//        System.out.println("EL MODELADO HA CONCLUIDO");
//        try{
//            misPedidos = daoPedido.listar(0, sdf.parse("01-01-2019"), sdf.parse("01-01-2021"), "BORRADOR", "ESPERANDO");
//        }catch(Exception e){
//            System.out.println("MAL");
//        }

//        misClientes=daoCliente.listarSinCartera("", "", 125);
//        for(Cliente c : misClientes) System.out.println(c.getIdCliente()+" "+c.getRuc());
//        
//        misVisitas=daoVisita.listar(6);
//        for(Visita v : misVisitas) System.out.println(v.getCliente().getRazonSocial()+" "+v.getFechaRegistro()+""+v.isEstado());

//        Cartera cartera = new Cartera();
//        cartera.setIdCartera(8);
//        Empleado empleado = new Empleado();
//        empleado.setIdEmpleado(22);
//        cartera.setEmpleado(empleado);
//        
//        Visita v1 = new Visita();
//        Cliente c1 = new Cliente();
//        c1.setIdCliente(24);
//        v1.setCliente(c1);
//        cartera.getListaVisita().add(v1);
//        
//        Visita v2 = new Visita();
//        Cliente c2 = new Cliente();
//        c2.setIdCliente(28);
//        v2.setCliente(c2);
//        cartera.getListaVisita().add(v2);
//        daoCartera.actualizar(cartera);
        
//        Pedido pedido = new Pedido();
//        pedido.setIdPedido(55);
//        misLineasDePedido = daoLineaPedido.listar(pedido.getIdPedido());
//        pedido.setLineasPedidos(misLineasDePedido);
//        try{
//            pedido.setFechaEstim(sdf.parse("01-01-2021"));
//        }catch(Exception e){
//            System.out.println("MAL");
//        }
//        daoPedido.aprobarBorrador(pedido);
        //Empleado empleado = daoEmpleado.permitirAccesoEmpleado("sofi1", "sofi1");
        //misClientes=daoCliente.listarConCartera("", "", empleado.getCartera().getIdCartera());
    }
    
    private static void gestionarFamilias(){
//        FamiliaDAO daoFamilia = new FamiliaMySQL();
//        Familia familia1= new Familia("Golosinas");
//        Familia familia2= new Familia("Snacks");
//        daoFamilia.insertar(familia1);
//        daoFamilia.insertar(familia2);
        misFamilias=daoFamilia.listar();
        System.out.println("LISTADO DE FAMILIA");
        System.out.println("==================================================================================");
        for(Familia f:misFamilias) System.out.println(f.getIdFamilia()+" - "+f.getDescripcion());
        System.out.println("\n");
    }
        
    private static void gestionarSubFamilias(){
        //misFamilias=daoFamilia.listar();
        Familia familia1 = new Familia();
        familia1.setIdFamilia(14);
        SubFamilia subFamilia1= new SubFamilia();
        subFamilia1.setIdSubFamilia(18);
        subFamilia1.setDescripcionSubFamilia("Quesos");
        subFamilia1.setFamilia(familia1);
        subFamilia1.setActivo(true);
        
        daoSubFamilia.actualizar(subFamilia1);

        String familia = "";
        misSubFamilias=daoSubFamilia.listar(familia);
        System.out.println("LISTADO DE SUBFAMILIA");        
        System.out.println("==================================================================================");
        System.out.println("Familia: "+familia);
        System.out.println("==================================================================================");
        for(SubFamilia sf:misSubFamilias) System.out.println(sf.getIdSubFamilia()+" - "+sf.getDescripcionSubFamilia()+" - "+sf.getFamilia().getIdFamilia()+" - "+sf.getFamilia().getDescripcion());
        System.out.println("\n");
    }
    
    private static void gestionarMarcas(){
//        Marca marca1=new Marca("PULLPA");
//        daoMarca.insertar(marca1);
//        marca2.setIdMarca(1);
//        marca2.setNombre("Tres Ositos");
//        daoMarca.actualizar(marca2);
        misMarcas=daoMarca.listar();
        System.out.println("LISTADO DE MARCAS");
        System.out.println("==================================================================================");
        for(Marca m:misMarcas) System.out.println(m.getIdMarca()+" - "+m.getNombre());
        System.out.println("\n");
    }
    
    private static void gestionarZonas(){
//        Zona zona1 = new Zona("Cercado de Lima");
//        daoZona.insertar(zona1);        
//        Zona zona2=new Zona();
//        zona2.setIdZona(126);
//        zona2.setNombre("Carabayllo");
//        daoZona.actualizar(zona2);
//        daoZona.eliminar(126); 
        misZonas=daoZona.listar();
        
        System.out.println("LISTADO DE ZONAS");
        System.out.println("==================================================================================");
        for(Zona z:misZonas) System.out.println(z.getIdZona()+" - "+z.getNombre());
        System.out.println("\n");
    }
    
    private static void gestionarClientes(){
        Cliente cliente1=new Cliente("10680029640","MARKET ANDINO","NACIONAL","Primera Zona Av Los Rosales");
        PersonaContacto perCont1 = new PersonaContacto();
        perCont1.setDni("76891429");
        perCont1.setCargo("GERENTE");
        perCont1.setNombre("Saúl");
        perCont1.setApellidoPaterno("Peredo");
        perCont1.setApellidoMaterno("Quiroga");
        perCont1.setGenero('M');
        perCont1.setCorreo("saull_qrg@hotmail.com");
        perCont1.setTelefono1("986365129");
        perCont1.setTelefono2("");
        cliente1.setPersonaContacto(perCont1);
        cliente1.getZona().setIdZona(125);
        int resultado = daoCliente.insertar(cliente1);
        int resultado2 = daoPersonaContacto.insertar(perCont1, resultado);
//        cliente1.setIdCliente(35);
//        cliente1.getPersonaContacto().setIdPersonaContacto(25);
//        int resultado = daoCliente.actualizar(cliente1);
        
        String razonSocial = "";
        String grupo = "";
        misClientes=daoCliente.listar(razonSocial,grupo,0);
        System.out.println("LISTADO DE CLIENTES");
        System.out.println("==================================================================================");
        System.out.println("Razon social: "+razonSocial);
        System.out.println("Grupo: "+grupo);
        System.out.println("==================================================================================");
        for(Cliente c:misClientes) System.out.println(c.getIdCliente()+" - "+c.getRuc()+" - "+c.getRazonSocial()+
                " - "+c.getGrupo()+" - "+c.getTipoEmpresa()+" - "+c.getDireccion()+" - "+sdf.format(c.getFechaRegistro())+" - "+c.getZona().getNombre());
        System.out.println("\n");
        
//        Cliente miCliente=misClientes.get(0);
//        daoCliente.mostrar(miCliente);
//        LineaCredito lineaCredito=miCliente.getLineaCredito();
//        Zona zona=miCliente.getZona();
//        PersonaContacto personaContacto = miCliente.getPersonaContacto();
        
//        personaContacto.setCargo("SECRETARIO");
//        miCliente.setPersonaContacto(personaContacto);
//        daoCliente.actualizar(miCliente);

//        Cartera cartera=miCliente.getCartera();
//        System.out.println("DETALLE DEL CLIENTE "+miCliente.getRuc());
//        System.out.println("==================================================================================");
//        System.out.println("Informacion: "+miCliente.getIdCliente()+" - "+miCliente.getRazonSocial()+" - "+miCliente.getDireccion()+" - "+sdf.format(miCliente.getFechaRegistro()));
//        System.out.println("Persona Contacto: "+personaContacto.getNombre()+" "+personaContacto.getApellidoPaterno()+" "+personaContacto.getApellidoMaterno()+" "+personaContacto.getCargo());
//        if(lineaCredito.getIdLineaCredito()>0)
//            System.out.println("Linea de Credito: "+lineaCredito.getIdLineaCredito()+" - "+lineaCredito.getMontoLineaCredito()+" - "+lineaCredito.getMotivo()+
//            " - Respomsable: "+lineaCredito.getResponsable().getNombre()+" - "+lineaCredito.getResponsable().getApellidoPaterno());
//        if(zona.getIdZona()>0)
//            System.out.println("Zona: "+zona.getIdZona()+" - "+zona.getNombre());
//        System.out.println("\n");
        
    }
        
    private static void gestionarEmpleados(){
//        Cargo cargo=new Cargo("JEFE DE VENTAS");
//        Cargo cargo=new Cargo(1, "EMPLEADO");
//
//        Empleado empleado1= new Empleado(cargo,"71421991","Keiko","Montez","Monterroso",'F',"985745102","","keipoper@gmail.com");
//        empleado1.setUsuario("keikomontmont");
//        empleado1.setContraseña("matangalachanga");
//        int idJefe=daoEmpleado.insertar(empleado1);
//        empleado1.setIdEmpleado(idJefe);
//        
//        Empleado empleado2= new Empleado(cargo2,"75625816","Javier","Altuna","Rodriguez",'M',"990368741","","starkiller66@hotmail.com");
//        empleado2.setJefe(empleado1);
//        empleado2.setUsuario("javieraltrod");
//        empleado2.setContraseña("bancopichincha");
//        empleado2.setObjetivoVentas(3500.00);
//        daoEmpleado.insertar(empleado2);
        
//        Empleado emp1=new Empleado();

//        miEmpleado.setUsuario("keikomontmont");
//        miEmpleado.setContraseña("matangalachanga");
        Empleado miEmpleado = daoEmpleado.permitirAccesoEmpleado("rauljl1","rauljl1");
        
        if(miEmpleado.getIdEmpleado()!=0){
            System.out.println("==================================================================================");
            if(miEmpleado.getGenero()=='M') System.out.println("BIENVENIDO "+miEmpleado.getNombre()+" "+miEmpleado.getApellidoPaterno());
            else System.out.println("BIENVENIDA "+miEmpleado.getNombre()+" "+miEmpleado.getApellidoPaterno());
            System.out.println("==================================================================================");
            
            if(miEmpleado.getCargo().getIdCargo()==1){
                System.out.println("DATOS: "+miEmpleado.getNombre()+" "+miEmpleado.getApellidoPaterno()+" "+miEmpleado.getApellidoMaterno());
                System.out.println("SUMA DE VENTAS: "+miEmpleado.getSumVentas());
                System.out.println("OBJETIVO DE VENTAS: "+miEmpleado.getObjetivoVentas());
                
                daoZona.mostrar(miEmpleado.getIdEmpleado());
                System.out.println("\nZONA DEL VENDEDOR");
                System.out.println("==================================================================================");
                System.out.println(miEmpleado.getZona().getIdZona()+" - "+miEmpleado.getZona().getNombre());
                
                misVisitas = daoVisita.listar(miEmpleado.getCartera().getIdCartera());
                System.out.println("\nLISTADO DE VISITAS DEL VENDEDOR");
                System.out.println("==================================================================================");
                for(Visita v : misVisitas)
                    System.out.println(v.getCliente().getIdCliente()+" - "+v.getCliente().getRazonSocial()+" - "+v.getFechaRegistro()+" - "+v.isEstado());
                                
//                String razonSocial="";
//                String grupo="";
//                misClientes=daoCliente.obtenerClientesPorCartera(miEmpleado.getCartera().getIdCartera(),razonSocial,grupo);
//                System.out.println("\nLISTADO DE CLIENTES");
//                System.out.println("==================================================================================");
//                System.out.println("RAZON SOCIAL: "+razonSocial);
//                System.out.println("GRUPO: "+grupo);
//                System.out.println("==================================================================================");
//                for(Cliente c:misClientes) 
//                    System.out.println(c.getIdCliente()+" - "+c.getRuc()+" - "+c.getRazonSocial()+" - "+c.getGrupo()+" - "+
//                    c.getTipoEmpresa()+" - "+c.getDireccion()+" - "+sdf.format(c.getFechaRegistro()));
                
                Cliente miCliente=misClientes.get(0);
                daoCliente.mostrar(miCliente);
                LineaCredito lineaCredito=miCliente.getLineaCredito();
                Zona zona=miCliente.getZona();
                PersonaContacto personaContacto = miCliente.getPersonaContacto();
                System.out.println("\nDETALLE DEL CLIENTE "+miCliente.getRuc());
                System.out.println("==================================================================================");
                System.out.println("Informacion: "+miCliente.getIdCliente()+" - "+miCliente.getRazonSocial()+" - "+miCliente.getDireccion()+" - "+sdf.format(miCliente.getFechaRegistro()));
                System.out.println("Persona Contacto: "+personaContacto.getNombre()+" "+personaContacto.getApellidoPaterno()+" "+personaContacto.getApellidoMaterno()+" "+personaContacto.getCargo());
                if(lineaCredito.getIdLineaCredito()>0)
                    System.out.println("Linea de Credito: "+lineaCredito.getIdLineaCredito()+" - "+lineaCredito.getMontoLineaCredito()+" - "+lineaCredito.getMotivo()+
                    " - Respomsable: "+lineaCredito.getResponsable().getNombre()+" - "+lineaCredito.getResponsable().getApellidoPaterno());
                if(zona.getIdZona()>0)
                    System.out.println("Zona: "+zona.getIdZona()+" - "+zona.getNombre());
                System.out.println("\n");
            }
            else{
                String nombre="";
                String apellidoPaterno="";
                String apellidoMaterno="";
                int idZona=138;
                misEmpleados=daoEmpleado.listarPorJefeVentas(miEmpleado.getIdEmpleado(),nombre,apellidoPaterno,apellidoMaterno);
                System.out.println("LISTADO DE VENDEDORES A CARGO");
                System.out.println("==================================================================================");
                System.out.println("Nombre: "+nombre);
                System.out.println("Apellido Paterno: "+apellidoPaterno);
                System.out.println("Apellido Materno: "+apellidoMaterno);
                System.out.println("==================================================================================");
                for(Empleado e:misEmpleados){
                    System.out.print(e.getIdEmpleado()+" - "+e.getDni()+" - "+e.getNombre()+" - "+e.getApellidoPaterno()+" - "+e.getApellidoMaterno()+" - "+e.getGenero()+" - "+e.getCargo().getNombre()+" - "+e.getSumVentas()+" - "+e.getObjetivoVentas());
                    if(e.getZona().getIdZona()>0) System.out.println(" - "+e.getZona().getNombre());
                    else System.out.println("");
                }
                System.out.println("\n");
                System.out.println("==================================================================================");
                 misEmpleados=daoEmpleado.listarPorJefeVentasYZona(miEmpleado.getIdEmpleado(),nombre,apellidoPaterno,apellidoMaterno,idZona);
                System.out.println("LISTADO DE VENDEDORES A CARGO POR ZONA");
                System.out.println("==================================================================================");
                System.out.println("Nombre: "+nombre);
                System.out.println("Apellido Paterno: "+apellidoPaterno);
                System.out.println("Apellido Materno: "+apellidoMaterno);
                System.out.println("==================================================================================");
                for(Empleado e:misEmpleados){
                    System.out.print(e.getIdEmpleado()+" - "+e.getDni()+" - "+e.getNombre()+" - "+e.getApellidoPaterno()+" - "+e.getApellidoMaterno()+" - "+e.getGenero()+" - "+e.getCargo().getNombre()+" - "+e.getSumVentas()+" - "+e.getObjetivoVentas());
                    if(e.getZona().getIdZona()>0) System.out.println(" - "+e.getZona().getNombre());
                    else System.out.println("");
                }
                System.out.println("\n");
            }    
            
            //CARTERAS
            //INSERTAR CARTERA
//            misClientes = daoCliente.listar();
//            Cartera cartera = new Cartera();
//            Empleado empleado = new Empleado();
//            empleado.setIdEmpleado(12);
//            daoEmpleado.getEmpleado(empleado);
////            Empleado empleado = misEmpleados.get(0);
//            cartera.setEmpleado(empleado);
//            cartera.setId(6);
//            
//            Visita visita1 = new Visita();
//            visita1.setCliente(misClientes.get(0));
//            visita1.setIdVisita(7);
//            cartera.getListaVisita().add(visita1);
//            
//            Visita visita2 = new Visita();
//            visita2.setCliente(misClientes.get(1));
//            cartera.getListaVisita().add(visita2);
//            try {
//                cartera.setFechaFin(sdf.parse("31-10-2020"));
//            } catch (ParseException ex) {
//                System.out.println(ex.getMessage());
//            }
            //daoCartera.insertar(cartera);

//            daoCartera.actualizar(cartera);
            //MOSTRAR DETALLES DE UN VENDEDOR
//            daoZona.mostrar(empleado);
//            System.out.println("ZONA DEL VENDEDOR "+empleado.getNombre()+" "+empleado.getApellidoPaterno()+" "+empleado.getApellidoMaterno());
//            System.out.println("==================================================================================");
//            System.out.println(empleado.getZona().getIdZona()+" - "+empleado.getZona().getNombre());
//            misVisitas = daoVisita.listarVisitasPorVendedor(empleado);
//            System.out.println("LISTADO DE VISITAS DEL VENDEDOR "+empleado.getNombre()+" "+empleado.getApellidoPaterno()+" "+empleado.getApellidoMaterno());
//            System.out.println("==================================================================================");
//            for(Visita v : misVisitas){
//                System.out.println(v.getCliente().getIdCliente()+" - "+v.getCliente().getRazonSocial()+" - "+v.getFechaRegistro()+" - "+v.isEstado());
//            }
//            System.out.println("\n");
        }
        else System.out.println("Datos incorrectos");
    }
    
    private static void gestionarProductos(){
        misMarcas=daoMarca.listar();
        misSubFamilias=daoSubFamilia.listar("");
        Producto prod1 = new Producto(misMarcas.get(0),misSubFamilias.get(0),"Lollipop", 400, "gr", 2.7,45000);
//        daoProducto.insertar(prod1);
        //Producto prod = new Producto();
        daoProducto.actualizar(prod1);
        
        String nombre="";
        String familia="";
        String subFamilia="";
        String marca="";
        
        misProductos=daoProducto.listar(nombre,familia,subFamilia,marca);
        System.out.println("LISTADO DE PRODUCTOS");
        System.out.println("==================================================================================");
        System.out.println("Nombre: "+nombre);
        System.out.println("Familia: "+familia);
        System.out.println("Subfamilia: "+subFamilia);
        System.out.println("Marca: "+marca);
        System.out.println("==================================================================================");
        for(Producto p:misProductos) 
            System.out.println(p.getIdProducto()+" - "+p.getNombre()+" - "+p.getCantUnidad()+" - "+p.getUnidades()+" - "+
            p.getPrecioSugerido()+" - "+p.getSubFamilia().getDescripcionSubFamilia()+" - "+p.getSubFamilia().getFamilia().getDescripcion()+" - "+p.getMarca().getNombre());
        System.out.println("\n");
    }
    
    private static void gestionarProductoXZona(){
        misProductos=daoProducto.listar("","", "", "");
        misZonas=daoZona.listar();
        
        ProductoXZona pxz1=new ProductoXZona(misProductos.get(2), misZonas.get(2), 9.30);
        daoProductoXZona.insertar(pxz1);
        
        int idZona=1;
            String nombre="";
        String familia="";
        String subFamilia="";
        String marca="";
        misProductosXZonas=daoProductoXZona.listar(nombre,familia,subFamilia,marca,idZona);
        System.out.println("LISTADO DE PRODUCTOS POR ZONA");
        System.out.println("==================================================================================");
        System.out.println("==================================================================================");
        for(ProductoXZona pxz:misProductosXZonas) 
            System.out.println(pxz.getIdProductoXZona()+" - "+pxz.getProducto().getIdProducto()+" - "+pxz.getProducto().getNombre()+" - "+
            pxz.getZona().getIdZona()+" - "+pxz.getZona().getNombre()+" - "+pxz.getPrecioReal()+" - "+pxz.getProducto().getPrecioSugerido()); 
        System.out.println("\n");
    }
    
    private static void gestionarPromociones(){
//        Promocion promocion = new Promocion("FIN DE SEMANA DE LOCURA", "NO SE REPETIRA!!!");
//        try{
//            promocion.setFechaInicio(sdf.parse("23-09-2020"));
//            promocion.setFechaFin(sdf.parse("07-10-2020"));
//        }catch(Exception e){
//            System.out.println("Error");
//        }
//        daoPromocion.insertar(promocion);
//        Promocion promocion2 = new Promocion("PRECIAZOS POTUS", "LLEVE CASERO QUE SE ACABAN", 0);
//        promocion2.setIdPromocion(0);
//        try{
//            promocion2.setFechaInicio(sdf.parse("16-09-2020"));
//            promocion2.setFechaFin(sdf.parse("26-10-2020"));
//        }catch(Exception e){
//            System.out.println("Error");
//        }
//        daoPromocion.actualizar(promocion2);
//        Promocion promocion=new Promocion();
//        promocion.setIdPromocion(3);
//        daoPromocion.eliminar(3);
        
        String nombre="";
        Date fechaIni=null;
        Date fechaFin=null;
        try{
            fechaIni=sdf.parse("10-09-2020");
            fechaFin=sdf.parse("26-12-2021");
        } catch(Exception e){
            System.out.println("Error en Gestionar Promociones");
        }
        misPromociones=daoPromocion.listar(nombre,fechaIni,fechaFin);
        System.out.println("LISTADO DE PROMOCIONES");
        System.out.println("==================================================================================");
        System.out.println("Nombre: "+nombre);
        System.out.print("Fecha Inicio: ");
        if(fechaIni==null) System.out.println("");
        else System.out.println(sdf.format(fechaIni));
        System.out.print("Fecha Fin: ");
        if(fechaFin==null) System.out.println("");
        else System.out.println(sdf.format(fechaFin));
        System.out.println("==================================================================================");
        for(Promocion promo:misPromociones) 
            System.out.println(promo.getIdPromocion()+" - "+promo.getNombre()+" - "+promo.getDescripcion()); 
        System.out.println("\n");
    }
    
    private static void gestionarPromocionXProducto(){
//        misPromociones=daoPromocion.listar();
//        misProductos=daoProducto.listar("", "", "");
//        PromocionXProducto miPromoXProd=new PromocionXProducto(misPromociones.get(0), misProductos.get(0), 17,5000);
//        daoPromocionXProducto.insertar(miPromoXProd);

//        PromocionXProducto pxp2=new PromocionXProducto(misPromociones.get(0), misProductos.get(1), 5000);
//        pxp2.setIdPromocionXProducto(0);
//        pxp2.setCantidad(3000);
//        daoPromocionXProducto.actualizar(pxp2);
//        daoPromocionXProducto.eliminar(0);
        misPromocionXProducto=daoPromocionXProducto.listar(6);
        System.out.println("LISTADO DE PROMOCION POR PRODUCTO");
        System.out.println("==================================================================================");
        for(PromocionXProducto pxp:misPromocionXProducto) 
            System.out.println(pxp.getIdPromocionXProducto()+" - "+pxp.getProducto().getNombre()+" - "+pxp.getDescuento()+" - "+pxp.getStock()); 
        System.out.println("\n");
    }
    
    private static void gestionarPedidos(){
        //INGRESAR UN PEDIDO COMO BORRADOR
//        misClientes = daoCliente.listar();
//        Cliente cliente1 = misClientes.get(0);
//        misEmpleados = daoEmpleado.listarPorJefeVentas(18,"","","");
//        Empleado empleado1 = misEmpleados.get(0);
//        Pedido pedido1= new Pedido(cliente1,empleado1,"Almacen N°1, Fabrica PULLPA");

        ProductoXZona pxz1 = new ProductoXZona();
        pxz1.setIdProductoXZona(68);
        LineaPedido linea1 = new LineaPedido(3,pxz1);
//        ProductoXZona pxz2 = new ProductoXZona();
//        pxz2.setIdProductoXZona(69);
//        LineaPedido linea2 = new LineaPedido(7,pxz2);
//        pedido1.getLineasPedidos().add(linea1);
//        pedido1.getLineasPedidos().add(linea2);
//        daoPedido.insertar(pedido1);
        
        //APROBAR EL PEDIDO
//        pedido1.setIdPedido(42);
//        SimpleDateFormat formato=new SimpleDateFormat("dd-MM-yyyy");
//        try{
//            pedido1.setFechaEstim(formato.parse("05-11-2020"));
//        }catch(Exception ex){
//            System.out.println("ARA");
//        }
        
//        daoPedido.aprobarBorrador(pedido1);
//        daoPedido.insertar(pedido1);

        //misPedidos=daoPedido.listar();
        Pedido pedido1 = misPedidos.get(0);
        linea1.setPedido(pedido1);
        System.out.println("LISTADO DE PEDIDOS");
        System.out.println("==================================================================================");
        for(Pedido p:misPedidos){
            daoCliente.obtenerCliente(p.getCliente().getIdCliente());
            System.out.println(p.getIdPedido()+" - "+p.getFechaRegistro()+" - "+p.getCliente().getRuc()+" - "+p.getMontoTotal()+" - "+p.getMontoPagar()+" - "+String.valueOf(p.getTipoPedido())+" - "+String.valueOf(p.getEstadoPedido()));
        }
        System.out.println("\n");
//        daoPedido.culminarPedido(pedido1);
//        daoPedido.anular(pedido1);
        misLineasDePedido = daoLineaPedido.listar(42);
        pedido1.setLineasPedidos(misLineasDePedido);
        System.out.println("LISTADO DE LINEAS PEDIDO");
        System.out.println("==================================================================================");
        int cant;
        for(LineaPedido p:misLineasDePedido){
            cant = p.getCantidad()+p.getCantidadPromo();
            System.out.println(p.getIdLineaPedido()+" - "+p.getProductoXZona().getIdProductoXZona()+" - "+p.getMontoSubTotal()+" - "+cant);
        }
        System.out.println("\n");
//        pedido1.getLineasPedidos().add(linea1);
        pedido1.getLineasPedidos().get(0).setCantidad(6);
        daoPedido.actualizar(pedido1);
        misLineasDePedido = daoLineaPedido.listar(42);
        System.out.println("LISTADO DE LINEAS PEDIDO");
        System.out.println("==================================================================================");
        for(LineaPedido p:misLineasDePedido){
            cant = p.getCantidad()+p.getCantidadPromo();
            System.out.println(p.getIdLineaPedido()+" - "+p.getProductoXZona().getIdProductoXZona()+" - "+p.getMontoSubTotal()+" - "+cant);
        }
        System.out.println("\n");
    }
    
    private static void gestionarLineasDePedido(){
//        LineaPedido lineaPedido1= new LineaPedido(20,pxz1);
//        daoLineaPedido.insertar(pedido1.getIdPedido(),lineaPedido1);
//        misLineasDePedido = daoLineaPedido.listar(pedido1.getIdPedido());
//        System.out.println("LISTADO DE LINEAS PEDIDO");
//        System.out.println("==================================================================================");
//        for(LineaPedido p:misLineasDePedido) System.out.println(p.getIdLineaPedido()+" - "+p.getMontoSubTotal()+" - "+p.getCantidad());
//        System.out.println("\n");
    }
    
    private static void gestionarFacturas(){
        //misPedidos=daoPedido.listar();
//        try{
//            Date fechaVencimiento=sdf.parse("13-12-2020");
//            Factura factura=new Factura(misPedidos.get(0),50.00, "TODO OK", 0.18,fechaVencimiento);
//            daoFactura.insertar(factura);
//        } catch(Exception e){
//            System.out.println("Error al insertar la fecha en gestionar facturas");
//        }

        misFacturas=daoFactura.listar(misPedidos.get(0).getIdPedido());
        
//        Factura factura=misFacturas.get(0);
//        double monto=daoFactura.eliminar(factura);
//        misPedidos.get(0).setMontoPagar(misPedidos.get(0).getMontoPagar()+monto);
//        daoPedido.actualizarSubtotal(misPedidos.get(0));
        System.out.println("LISTADO DE FACTURAS DEL PEDIDO "+misPedidos.get(0).getIdPedido());
        System.out.println("==================================================================================");
        for(Factura f:misFacturas){
            System.out.print(f.getIdFactura()+" - "+f.getPedido().getIdPedido()+" - "+f.getObservacion()+" - "+f.getMonto()+" - "+
            f.getFechaEmision()+" - "+f.getFechaVencimiento()+" - ");
            if(f.getEstadoPagar()) System.out.println("PAGADO");
            else System.out.println("FALTA PAGAR");
        } 
            
        System.out.println("\n");
    }
    
    private static void gestionarNotasDeCredito(){
        //misPedidos=daoPedido.listar();
        misNotasDeCredito=daoNotaDeCredito.listar(0);        
        System.out.println("LISTADO DE NOTAS DE CREDITO DEL PEDIDO "+misPedidos.get(0).getIdPedido());
        System.out.println("==================================================================================");
        for(NotaDeCredito ndc:misNotasDeCredito) 
            System.out.println(ndc.getIdNotaDeCredito()+" - "+ndc.getMonto()+" - "+ndc.getFechaCreacion());
        System.out.println("\n");
    }
    
    private static void gestionarGuiasDeRemision(){
        //misPedidos=daoPedido.listar();
        
//        GuiaRemision guiaRemision1= new GuiaRemision(misPedidos.get(0),"Por trasladar");
//        guiaRemision1.setFechaRegistro(new Date());
//        try{
//            guiaRemision1.setFechaTraslado(sdf.parse("23-11-2020"));
//            daoGuiaRemision.insertar(guiaRemision1);    
//            guiaRemision1.setFechaTraslado(sdf.parse("25-11-2020"));
//            daoGuiaRemision.actualizar(guiaRemision1);
//        } catch(Exception e){
//            System.out.println("Error en el insertar Guia de remision");
//        }

        ArrayList<GuiaRemision> misGuias = daoGuiaRemision.listar(misPedidos.get(0).getIdPedido());    
        System.out.println("LISTADO DE GUIAS DE REMISION DEL PEDIDO "+misPedidos.get(0).getIdPedido());
        System.out.println("==================================================================================");
        for(GuiaRemision g:misGuias) 
            System.out.println(g.getIdGuiaRemision()+ " - "+g.getMotivoTraslado()+" - "+g.getFechaRegistro()+" - "+g.getFechaTraslado());
        System.out.println("\n");
    }
    
    private static void gestionarQuejas(){
        //misPedidos=daoPedido.listar();
        Queja queja1= new Queja(misPedidos.get(0),"El pedido llego retrasado");
//        daoQueja.insertar(queja1);
        misQuejas = daoQueja.listar(misPedidos.get(0).getIdPedido());
        System.out.println("LISTADO DE QUEJAS DEL PEDIDO "+misPedidos.get(0).getIdPedido());
        System.out.println("==================================================================================");
        for(Queja p:misQuejas) 
            System.out.println(p.getIdQueja()+ " - "+p.getDescripcion()+" - "+p.getFechaCreacion());
        System.out.println("\n");
    }

}
