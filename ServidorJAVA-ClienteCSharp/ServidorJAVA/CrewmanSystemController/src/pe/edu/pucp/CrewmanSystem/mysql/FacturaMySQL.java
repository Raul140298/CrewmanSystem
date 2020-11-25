package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.Array;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.FacturaDAO;
import pe.edu.pucp.CrewmanSystem.model.Factura;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.dao.NotaDeCreditoDAO;
import pe.edu.pucp.CrewmanSystem.model.NotaDeCredito;
import pe.edu.pucp.CrewmanSystem.model.Pedido;

public class FacturaMySQL implements FacturaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Factura factura){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_FACTURA(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_FACTURA", java.sql.Types.INTEGER);
            cs.setInt("_ID_PEDIDO", factura.getPedido().getIdPedido());
            cs.setDouble("_MONTO", factura.getMonto());
            cs.setString("_OBSERVACION", factura.getObservacion());
            cs.setDate("_FECHA_EMISION", new java.sql.Date(new Date().getTime()));
            cs.setDate("_FECHA_VENCIMIENTO", new java.sql.Date(factura.getFechaVencimiento().getTime()));
            cs.setDouble("_IMPUESTOS", factura.getImpuestos());
            cs.setBoolean("_ESTADO_PAGAR", factura.getEstadoPagar());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_FACTURA");
            factura.setIdFactura(resultado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Factura factura){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_FACTURA(?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_FACTURA", factura.getIdFactura());
            cs.setDouble("_MONTO", factura.getMonto());
            cs.setString("_OBSERVACION", factura.getObservacion());
            cs.setDate("_FECHA_VENCIMIENTO", new java.sql.Date(factura.getFechaVencimiento().getTime()));
            cs.setDouble("_IMPUESTOS", factura.getImpuestos());
            cs.setBoolean("_ESTADO_PAGAR", factura.getAnulado());
            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado; 
    }
    
    @Override
    public int eliminar(Factura factura){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_FACTURA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_FACTURA", factura.getIdFactura());
            resultado=cs.executeUpdate();
            
            NotaDeCreditoDAO daoNotaDeCredito = new NotaDeCreditoMySQL();
            NotaDeCredito notaDeCredito = new NotaDeCredito(factura);
            daoNotaDeCredito.insertar(notaDeCredito);
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public ArrayList<Factura>listar(int idPedido)
    {
        ArrayList<Factura> facturas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_FACTURA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", idPedido);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Factura factura = new Factura();
                Pedido pedido = new Pedido();
                
                factura.setIdFactura(rs.getInt("ID_FACTURA"));
                
                pedido.setIdPedido(rs.getInt("ID_PEDIDO"));
                factura.setPedido(pedido);
                
                factura.setMonto(rs.getDouble("MONTO"));
                factura.setObservacion(rs.getString("OBSERVACION"));
                factura.setFechaEmision(rs.getDate("FECHA_EMISION"));
                factura.setFechaVencimiento(rs.getDate("FECHA_VENCIMIENTO"));
                factura.setImpuestos(rs.getDouble("IMPUESTOS"));
                factura.setAnulado(rs.getBoolean("ANULADO"));
                factura.setEstadoPagar(rs.getBoolean("ESTADO_PAGAR"));

                facturas.add(factura);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return facturas;
    }
}
