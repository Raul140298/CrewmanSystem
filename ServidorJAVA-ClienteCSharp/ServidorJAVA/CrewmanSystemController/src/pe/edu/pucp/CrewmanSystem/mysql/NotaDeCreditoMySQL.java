package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.NotaDeCreditoDAO;
import pe.edu.pucp.CrewmanSystem.model.NotaDeCredito;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.model.Factura;

public class NotaDeCreditoMySQL implements NotaDeCreditoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(NotaDeCredito notaCredito){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_NOTADECREDITO(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_NOTA_DE_CREDITO", java.sql.Types.INTEGER);
            cs.setInt("_ID_FACTURA", notaCredito.getFactura().getIdFactura());
            cs.setDate("_FECHA_CREACION", new java.sql.Date(new Date().getTime()));
            cs.setDouble("_MONTO", notaCredito.getMonto());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_NOTA_DE_CREDITO");
            notaCredito.setIdNotaDeCredito(resultado);
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
    public ArrayList<NotaDeCredito>listar(int idPedido)
    {
        ArrayList<NotaDeCredito> notaDeCreditos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_NOTADECREDITO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", idPedido);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                NotaDeCredito notaDeCredito=new NotaDeCredito();
                Factura factura = new Factura();
                
                notaDeCredito.setIdNotaDeCredito(rs.getInt("ID_NOTA_DE_CREDITO"));
                
                factura.setIdFactura(rs.getInt("ID_FACTURA"));
                notaDeCredito.setFactura(factura);
                
                notaDeCredito.setFechaCreacion(rs.getDate("FECHA_CREACION"));
                notaDeCredito.setMonto(rs.getDouble("MONTO"));
                notaDeCreditos.add(notaDeCredito);
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
        return notaDeCreditos;
    }
    
}
