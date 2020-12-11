/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.Date;
import java.util.HashMap;
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
public class ReporteWS
{
    @WebMethod(operationName = "generarReporteMejoresEmpleados")
    public byte[] generarReporteMejoresEmpleados() {
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
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.pass);
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            hm.put("LOGO",imagen);
            
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
    public byte[] generarReportePedidosXCliente(@WebParam(name = "tipoCliente") String tipoCliente) {
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
            
            HashMap hm = new HashMap();
            hm.put("RUTA_SUBREPORTE_PEDIDOS",rutaSubreporte1);
            hm.put("RUTA_SUBREPORTE_DETALLES", rutaSubreporte2);
            hm.put("PTIPO_CLIENTE","");
            hm.put("LOGO", imagen);
            
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
                    
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReportePedidos")
    public byte[] generarReportePedidos() {
        byte[] arreglo = null;
        
        try{
            String rutaReporte = ReportePedidos.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/ReportePedidos.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte= (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
                        
            JasperPrint jp = JasperFillManager.fillReport(reporte, null, con);
            
            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);        
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteMejoresClientes")
    public byte[] generarReporteMejoresClientes(@WebParam(name = "nombre") String nombre) {
        byte[] arreglo = null;

        try{
            String rutaReporte = ReporteMejoresClientes.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/MejoresClientes.jasper").getPath();
            rutaReporte = rutaReporte.replaceAll("%20", " ");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(rutaReporte);

            String rutaLogo = ReporteMejoresClientes.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
            rutaLogo = rutaLogo.replaceAll("%20", " ");
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();

            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);

            HashMap hm = new HashMap();
            hm.put("LOGO", imagen);
            hm.put("NOMBRE", nombre);
            hm.put("FECHA", new java.sql.Date(new Date().getTime()));

            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);

            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return arreglo;
    }
}

