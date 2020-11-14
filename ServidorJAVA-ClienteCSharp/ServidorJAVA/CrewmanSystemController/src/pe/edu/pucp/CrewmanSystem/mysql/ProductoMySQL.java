package pe.edu.pucp.CrewmanSystem.mysql;

import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.ProductoDAO;
import pe.edu.pucp.CrewmanSystem.model.Producto;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.CrewmanSystem.model.Familia;
import pe.edu.pucp.CrewmanSystem.model.Marca;
import pe.edu.pucp.CrewmanSystem.model.SubFamilia;

public class ProductoMySQL implements ProductoDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(Producto producto){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_PRODUCTO(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PRODUCTO", java.sql.Types.INTEGER);
            cs.setInt("_ID_MARCA", producto.getMarca().getIdMarca());
            cs.setInt("_ID_SUBFAMILIA", producto.getSubFamilia().getIdSubFamilia());
            cs.setDouble("_PRECIO_SUGERIDO", producto.getPrecioSugerido());
            cs.setString("_NOMBRE", producto.getNombre());
            cs.setString("_UNIDADES", producto.getUnidades());
            cs.setDouble("_CANT_UNIDADES", producto.getCantUnidad());
            cs.setInt("_STOCK", producto.getStock());
            cs.setInt("_STOCK_RESERVADO", producto.getStockReservado());
            cs.setBoolean("_ACTIVO", producto.getActivo());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_PRODUCTO");
            producto.setIdProducto(resultado);
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
    public int actualizar(Producto producto){
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql = "{ CALL ACTUALIZAR_PRODUCTO(?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PRODUCTO", producto.getIdProducto());
            cs.setDouble("_PRECIO_SUGERIDO", producto.getPrecioSugerido());
            cs.setString("_NOMBRES", producto.getNombre());
            cs.setString("_UNIDADES", producto.getUnidades());
            cs.setDouble("_CANT_UNIDADES", producto.getCantUnidad());
            cs.setInt("_STOCK", producto.getStock());
            cs.setInt("_STOCK_RESERVADO", producto.getStockReservado());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                rs.close();
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idProducto){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_PRODUCTO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PRODUCTO", idProducto);
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
    public ArrayList<Producto>listar(String nombre,String familiaStr,String subFamiliaStr,String marcaStr){
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_PRODUCTO (?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setString("_NOMBRE", nombre);
            cs.setString("_F_DESCRIPCION", familiaStr);
            cs.setString("_S_DESCRIPCION", subFamiliaStr);
            cs.setString("_M_NOMBRE", marcaStr);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                Producto producto=new Producto();
                Marca marca=new Marca();
                SubFamilia subFamilia=new SubFamilia();
                Familia familia=new Familia();
                producto.setIdProducto(rs.getInt("ID_PRODUCTO"));
                producto.setPrecioSugerido(rs.getDouble("PRECIO_SUGERIDO"));
                producto.setNombre(rs.getString("NOMBRE"));
                producto.setUnidades(rs.getString("UNIDADES"));
                producto.setCantUnidad(rs.getDouble("CANT_UNIDADES"));
                producto.setStock(rs.getInt("STOCK"));
                producto.setStockReservado(rs.getInt("STOCK_RESERVADO"));
                producto.setActivo(rs.getBoolean("ACTIVO"));
                
                marca.setIdMarca(rs.getInt("ID_MARCA"));
                marca.setNombre(rs.getString("M_NOMBRE"));
                producto.setMarca(marca);
                
                subFamilia.setIdSubFamilia(rs.getInt("ID_SUBFAMILIA"));
                subFamilia.setDescripcionSubFamilia(rs.getString("S_DESCRIPCION"));
                
                familia.setIdFamilia(rs.getInt("ID_FAMILIA"));
                familia.setDescripcion(rs.getString("F_DESCRIPCION"));
                subFamilia.setFamilia(familia);
                producto.setSubFamilia(subFamilia);
                productos.add(producto);
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
        return productos;
    }

    @Override
    public Producto mostrar(int idProducto) {
        Producto producto = new Producto();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call MOSTRAR_PRODUCTO (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PRODUCTO", idProducto);
            cs.executeUpdate();
            rs = cs.getResultSet();
            rs.next();
            Marca marca=new Marca();
            SubFamilia subFamilia=new SubFamilia();
            Familia familia=new Familia();
            producto.setIdProducto(rs.getInt("ID_PRODUCTO"));
            producto.setPrecioSugerido(rs.getDouble("PRECIO_SUGERIDO"));
            producto.setNombre(rs.getString("NOMBRE"));
            producto.setUnidades(rs.getString("UNIDADES"));
            producto.setCantUnidad(rs.getDouble("CANT_UNIDADES"));
            producto.setStock(rs.getInt("STOCK"));
            producto.setStockReservado(rs.getInt("STOCK_RESERVADO"));
            producto.setActivo(rs.getBoolean("ACTIVO"));            

            marca.setIdMarca(rs.getInt("ID_MARCA"));
            producto.setMarca(marca);

            subFamilia.setIdSubFamilia(rs.getInt("ID_SUBFAMILIA"));
            producto.setSubFamilia(subFamilia);

        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return producto;
    }
}