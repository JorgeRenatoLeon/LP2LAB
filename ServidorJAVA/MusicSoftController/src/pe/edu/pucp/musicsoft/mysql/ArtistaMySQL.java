package pe.edu.pucp.musicsoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.musicsoft.config.DBManager;
import pe.edu.pucp.musicsoft.dao.ArtistaDAO;
import pe.edu.pucp.musicsoft.model.Artista;

public class ArtistaMySQL implements ArtistaDAO{

    Connection con;
    CallableStatement cs;
    
    @Override
    public ArrayList<Artista> listar(String nombre) {
        ArrayList<Artista> artistas = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ARTISTAS(?)}");
            cs.setString("_NOMBRE_ARTISTA", nombre);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Artista artista = new Artista();
                artista.setIdArtista(rs.getInt("ID_ARTISTA"));
                artista.setNombreArtista(rs.getString("NOMBRE_ARTISTA"));
                artista.setNacionalidad(rs.getString("NACIONALIDAD"));
                artistas.add(artista);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return artistas;
    }
    
}
