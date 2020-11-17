package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.LineaPedidoDAO;
import pe.edu.pucp.CrewmanSystem.model.LineaPedido;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.model.ProductoXZona;
import pe.edu.pucp.CrewmanSystem.model.PromocionXProducto;

public class LineaPedidoMySQL implements LineaPedidoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(LineaPedido lineaPedido)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_LINEAPEDIDO(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_LINEA_PEDIDO", java.sql.Types.INTEGER);
            cs.setDouble("_SUBTOTAL", lineaPedido.getMontoSubTotal());
            cs.setInt("_ID_PEDIDO", lineaPedido.getPedido().getIdPedido());
            cs.setInt("_ID_PRODUCTOXZONA", lineaPedido.getProductoXZona().getIdProductoXZona());
            cs.setInt("_CANTIDAD", lineaPedido.getCantidad());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_LINEA_PEDIDO");
            lineaPedido.setIdLineaPedido(resultado);
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
    public int actualizar(LineaPedido lineaPedido)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ACTUALIZAR_LINEAPEDIDO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEA_PEDIDO", lineaPedido.getIdLineaPedido());
            cs.setInt("_CANTIDAD", lineaPedido.getCantidad());
            resultado=cs.executeUpdate();
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
    public int eliminar(int idLineaPedido)
    {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_LINEAPEDIDO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEA_PEDIDO", idLineaPedido);
            cs.executeUpdate();
            resultado = 1;
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
    public ArrayList<LineaPedido> listar(int idPedido){
        ArrayList<LineaPedido> lineaPedidos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_LINEAPEDIDO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PEDIDO", idPedido);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                LineaPedido lp=new LineaPedido();
                lp.setIdLineaPedido(rs.getInt("ID_LINEA_PEDIDO"));
                ProductoXZona pz=new ProductoXZona();
                pz.setIdProductoXZona(rs.getInt("ID_PRODUCTOXZONA"));
                lp.setProductoXZona(pz);
                PromocionXProducto pp= new PromocionXProducto();
                lp.setCantidadPromo(rs.getInt("CANTIDAD_PROMO"));
                if(lp.getCantidadPromo()!=0)pp.setIdPromocionXProducto(rs.getInt("ID_PROMOCIONXPRODUCTO"));
                lp.setPromocionXProducto(pp);
                lp.setCantidad(rs.getInt("CANTIDAD"));
                lp.setMontoSubTotal(rs.getDouble("SUB_TOTAL"));
                lineaPedidos.add(lp);
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
        return lineaPedidos;
    }
}
