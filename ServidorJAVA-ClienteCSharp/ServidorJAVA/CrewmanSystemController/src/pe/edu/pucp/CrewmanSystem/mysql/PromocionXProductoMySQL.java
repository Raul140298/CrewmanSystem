package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ProductoDAO;
import pe.edu.pucp.CrewmanSystem.dao.PromocionXProductoDAO;
import pe.edu.pucp.CrewmanSystem.model.Producto;
import pe.edu.pucp.CrewmanSystem.model.PromocionXProducto;

public class PromocionXProductoMySQL implements PromocionXProductoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(PromocionXProducto promocionXProducto) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_PROMOCIONXPRODUCTO(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PROMOCIONXPRODUCTO", java.sql.Types.INTEGER);
            cs.setInt("_ID_PROMOCION", promocionXProducto.getPromocion().getIdPromocion());
            cs.setInt("_ID_PRODUCTO", promocionXProducto.getProducto().getIdProducto());
            cs.setInt("_DESCUENTO", promocionXProducto.getDescuento());
            cs.setInt("_STOCK", promocionXProducto.getStock());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_PROMOCIONXPRODUCTO");
            promocionXProducto.setIdPromocionXProducto(resultado);
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
    public ArrayList<PromocionXProducto> listar(int idPromocion) {
        ArrayList<PromocionXProducto> promocionesXProducto = new ArrayList<>();
        ProductoDAO daoProducto = new ProductoMySQL();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_PROMOCIONXPRODUCTO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROMOCION", idPromocion);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                PromocionXProducto promocionXProducto=new PromocionXProducto();
                Producto producto= new Producto();
                promocionXProducto.setIdPromocionXProducto(rs.getInt("ID_PROMOCIONXPRODUCTO"));
                
                producto=daoProducto.mostrar(rs.getInt("ID_PRODUCTO"));
                promocionXProducto.setProducto(producto);
                
                promocionXProducto.setDescuento(rs.getInt("DESCUENTO"));
                promocionXProducto.setStock(rs.getInt("STOCK"));
                promocionXProducto.setStockReservado(rs.getInt("STOCK_RESERVADO"));
                
                promocionesXProducto.add(promocionXProducto);
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
        return promocionesXProducto;
    }    
}
