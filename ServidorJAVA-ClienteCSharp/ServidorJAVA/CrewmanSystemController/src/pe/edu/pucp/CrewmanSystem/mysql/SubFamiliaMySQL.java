package pe.edu.pucp.CrewmanSystem.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.CrewmanSystem.config.DBManager;
import pe.edu.pucp.CrewmanSystem.dao.SubFamiliaDAO;
import pe.edu.pucp.CrewmanSystem.model.Familia;
import pe.edu.pucp.CrewmanSystem.model.SubFamilia;

public class SubFamiliaMySQL implements SubFamiliaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertar(SubFamilia subFamilia) { 
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call INSERTAR_SUBFAMILIA(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_SUBFAMILIA", java.sql.Types.INTEGER);
            cs.setString("_DESCRIPCION", subFamilia.getDescripcionSubFamilia());
            cs.setInt("_ID_FAMILIA", subFamilia.getFamilia().getIdFamilia());
            cs.executeUpdate();
            resultado = cs.getInt("_ID_SUBFAMILIA");
            subFamilia.setIdSubFamilia(resultado);
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
    public int actualizar(SubFamilia subFamilia) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql="{ call ACTUALIZAR_SUBFAMILIA(?,?) }";
            cs=con.prepareCall(sql);
            cs.setInt("_ID_SUBFAMILIA", subFamilia.getIdSubFamilia());
            cs.setString("_DESCRIPCION", subFamilia.getDescripcionSubFamilia());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idSubFamilia) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call ELIMINAR_SUBFAMILIA (?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_SUBFAMILIA", idSubFamilia);
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
    public ArrayList<SubFamilia>listar(String txtFamilia)
    {
        ArrayList<SubFamilia> subFamilias = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.pass);
            String sql ="{ call LISTAR_SUBFAMILIA (?)}";
            cs = con.prepareCall(sql);
            cs.setString("_FAMILIA", txtFamilia);
            cs.executeUpdate();
            rs = cs.getResultSet();
            while(rs.next()){
                SubFamilia subFamilia=new SubFamilia();
                Familia familia=new Familia();
                subFamilia.setIdSubFamilia(rs.getInt("ID_SUBFAMILIA"));
                subFamilia.setDescripcionSubFamilia(rs.getString("DESCRIPCION"));
                familia.setIdFamilia(rs.getInt("ID_FAMILIA"));
                familia.setDescripcion(rs.getString("F_DESCRIPCION"));
                subFamilia.setFamilia(familia);
                subFamilias.add(subFamilia);
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
        return subFamilias;
    }
}
