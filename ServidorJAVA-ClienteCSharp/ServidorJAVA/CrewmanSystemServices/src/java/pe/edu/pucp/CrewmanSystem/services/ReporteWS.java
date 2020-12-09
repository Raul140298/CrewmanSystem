/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
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
import pe.edu.pucp.CrewmanSystem.servlets.ReporteMejoresEmpleados;

/**
 *
 * @author raul1
 */
@WebService(serviceName = "ReporteWS")
public class ReporteWS
{
    @WebMethod(operationName = "generarReporte")
    public byte[] generarReporte(@WebParam(name = "nombre") String nombre) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(
            ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/MejoresEmpleados.jasper")
                    .getFile());
        
            //Referencia a la ruta de la imagen
            String rutaLogo = 
               ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/images/portada2.jpg")
                    .getPath();
            //Generamos el objeto Image
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
}
