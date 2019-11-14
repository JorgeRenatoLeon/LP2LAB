package pe.edu.pucp.musicsoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.musicsoft.config.DBManager;
import pe.edu.pucp.musicsoft.dao.GeneroMusicalDAO;
import pe.edu.pucp.musicsoft.model.GeneroMusical;

public class GeneroMusicalMySQL implements GeneroMusicalDAO{

    Connection con;
    CallableStatement cs;
    
    @Override
    public ArrayList<GeneroMusical> listar() {
        ArrayList<GeneroMusical> generosMusicales = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_GENEROS_MUSICALES()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                GeneroMusical generoMusical = new GeneroMusical();
                generoMusical.setIdGenero(rs.getInt("ID_GENERO_MUSICAL"));
                generoMusical.setNombreGenero(rs.getString("NOMBRE_GENERO"));
                generosMusicales.add(generoMusical);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return generosMusicales;
    }
    
}
