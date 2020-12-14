/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;
import java.util.TimeZone;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.servlets.ReporteMejoresClientes;
import pe.edu.pucp.CrewmanSystem.servlets.ReporteMejoresEmpleados;
import pe.edu.pucp.CrewmanSystem.servlets.ReportePedidos;
import pe.edu.pucp.CrewmanSystem.servlets.ReportePedidosXCliente;

@WebService(serviceName = "ReporteWS")
public class ReporteWS {
    private SimpleDateFormat sdf; 
    
    @WebMethod(operationName = "generarReporteMejoresEmpleados")
    public byte[] generarReporteMejoresEmpleados(@WebParam(name = "idJefe") int idJefe, @WebParam(name = "nombre") String nombre) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            String rutaReporte = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/MejoresEmpleados.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);
        
            //Referencia a la ruta de la imagen
            String rutaLogo = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();      
            
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.pass);
            
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            hm.put("LOGO", imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            hm.put("ID_JEFE", idJefe);
            
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            //Cerrar la conexion
            con.close();
            
            //Convertirlo a arreglo bytes
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReportePedidosXCliente")
    public byte[] generarReportePedidosXCliente(@WebParam(name = "tipoCliente") String tipoCliente,
            @WebParam(name = "estadoPedido") String estadoPedido, 
            @WebParam(name = "nombre") String nombre) {
        byte[] arreglo = null;
        
        try{
            String rutaReporte = ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/R_PEDIDOSXCLIENTE.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);

            //Obtener la ruta del subreporte1
            String rutaSubreporte1 = ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/SR_PEDIDOS.jasper").getPath();
            rutaSubreporte1 = rutaSubreporte1.replaceAll("%20", " ");
            
            //Obtener la ruta del subreporte2
            String rutaSubreporte2 = ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/SR_DETALLES.jasper").getPath();
            rutaSubreporte2 = rutaSubreporte2.replaceAll("%20", " ");

            //Obtener logo
            String rutaLogo = ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            HashMap hm = new HashMap();
            hm.put("RUTA_SUBREPORTE_PEDIDOS",rutaSubreporte1);
            hm.put("RUTA_SUBREPORTE_DETALLES", rutaSubreporte2);
            hm.put("PTIPO_CLIENTE",tipoCliente);
            hm.put("PESTADO_PEDIDO",estadoPedido);
            hm.put("LOGO", imagen);
            hm.put("PNOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
                    
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReportePedidos")
    public byte[] generarReportePedidos(@WebParam(name = "nombre") String nombre, @WebParam(name = "idJefe") int idJefe) {
        byte[] arreglo = null;
        
        try{
            String rutaReporte = ReportePedidos.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/ReportePedidos_PorJefe.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte= (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);
            
            String rutaSubReporte1 = ReportePedidos.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/ReportePedidos_SUBREPORTE1.jasper").getPath();
            rutaSubReporte1 = rutaSubReporte1.replaceAll("%20", " ");
            
            String rutaSubReporte2 = ReportePedidos.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/ReportePedidos_SUBREPORTE2.jasper").getPath();
            rutaSubReporte2 = rutaSubReporte2.replaceAll("%20", " ");
            
            //Obtener logo
            String rutaLogo = ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
                
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            HashMap hm = new HashMap();
            hm.put("RUTA_SUBREPORTE", rutaSubReporte1);
            hm.put("RUTA_SUBREPORTE2", rutaSubReporte2);
            hm.put("LOGO", imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            hm.put("ID_EMPLEADO", idJefe);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            
            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);        
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteMejoresClientes")
    public byte[] generarReporteMejoresClientes(@WebParam(name = "idJefe") int idJefe, @WebParam(name = "nombre") String nombre) {
        byte[] arreglo = null;

        try{
            String rutaReporte = ReporteMejoresClientes.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/MejoresClientes.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);

            String rutaLogo = ReporteMejoresClientes.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();

            String subreporte = ReporteMejoresClientes.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/MejoresClientes_Subreporte.jasper").getPath();
            subreporte = subreporte.replaceAll("%20", " ");
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            HashMap hm = new HashMap();
            hm.put("LOGO", imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            hm.put("RUTA_SUBREPORTE",subreporte);
            hm.put("ID_JEFE",idJefe);
            
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);

            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteQuejas")
    public byte[] generarReporteQuejas(@WebParam(name = "idJefe") int idJefe, 
            @WebParam(name = "nombre") String nombre) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            String rutaReporte = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/ReporteQuejas.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);
        
            //Referencia a la ruta de la imagen
            String rutaLogo = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();      
            
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            hm.put("LOGO", imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            hm.put("ID_JEFE", idJefe);
            
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            //Cerrar la conexion
            con.close();
            
            //Convertirlo a arreglo bytes
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReportePromocion")
    public byte[] generarReportePromocion(@WebParam(name = "nombre") String nombre, @WebParam(name = "idPromocion") int idPromocion) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            String rutaReporte = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/Promocion.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);
        
            //Referencia a la ruta de la imagen
            String rutaLogo = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();      
            
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            hm.put("LOGO",imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            hm.put("ID_PROMOCION", idPromocion);
            
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            //Cerrar la conexion
            con.close();
            
            //Convertirlo a arreglo bytes
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteVisitas")
    public byte[] generarReporteVisitas(@WebParam(name = "nombre") String nombre, @WebParam(name = "idEmpleado") int idEmpleado) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            String rutaReporte = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/Visitas.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);
        
            //Referencia a la ruta de la imagen
            String rutaLogo = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();      
            
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            hm.put("LOGO",imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));
            hm.put("ID_EMPLEADO", idEmpleado);
            
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            //Cerrar la conexion
            con.close();
            
            //Convertirlo a arreglo bytes
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
}

