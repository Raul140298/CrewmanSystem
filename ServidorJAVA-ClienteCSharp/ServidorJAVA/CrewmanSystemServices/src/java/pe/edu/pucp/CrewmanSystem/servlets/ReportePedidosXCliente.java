/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.CrewmanSystem.servlets;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.Date;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.CrewmanSystem.config.DBManager;

public class ReportePedidosXCliente extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
//        response.setContentType("text/html;charset=UTF-8");
        try{
            JasperReport reporte = (JasperReport)
                    JRLoader.loadObjectFromFile(ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/R_PEDIDOSXCLIENTE.jasper").getFile());

            //Obtener la ruta del subreporte1
            String rutaSubreporte1 = 
               ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/SR_PEDIDOS.jasper")
                    .getPath();
            
            //Obtener la ruta del subreporte2
            String rutaSubreporte2 = 
               ReportePedidosXCliente.class.getResource("/pe/edu/pucp/CrewmanSystem/reportes/SR_DETALLES.jasper")
                    .getPath();

            //Obtener logo
            String rutaLogo = ReporteMejoresEmpleados.class.getResource("/pe/edu/pucp/CrewmanSystem/images/icono.jpg").getPath();
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
            
            //Mostramos el reporte a nivel web
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
                    
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
