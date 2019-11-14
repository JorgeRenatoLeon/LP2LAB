package pe.edu.pucp.musicsoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.musicsoft.config.DBManager;
import pe.edu.pucp.musicsoft.dao.AlbumMusicalDAO;
import pe.edu.pucp.musicsoft.model.AlbumMusical;
import pe.edu.pucp.musicsoft.model.Track;

public class AlbumMusicalMySQL implements AlbumMusicalDAO{

    Connection con;
    CallableStatement cs;
    
    @Override
    public ArrayList<AlbumMusical> listar(String nombre) {
        ArrayList<AlbumMusical> albumes = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ALBUMES(?)}");
            cs.setString("_NOMBRE_ALBUM", nombre);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                AlbumMusical albumMusical = new AlbumMusical();
                albumMusical.setIdAlbum(rs.getInt("ID_ALBUM"));
                albumMusical.setNombreAlbum(rs.getString("NOMBRE_ALBUM"));
                albumMusical.getArtista().setIdArtista(rs.getInt("ID_ARTISTA"));
                albumMusical.getArtista().setNombreArtista(rs.getString("NOMBRE_ARTISTA"));
                albumMusical.getArtista().setNacionalidad(rs.getString("NACIONALIDAD"));
                albumMusical.getGeneroMusical().setIdGenero(rs.getInt("ID_GENERO_MUSICAL"));
                albumMusical.getGeneroMusical().setNombreGenero(rs.getString("NOMBRE_GENERO"));
                albumMusical.getEmpresaDiscografica().setIdEmpresa(rs.getInt("ID_EMPRESA_DISCOGRAFICA"));
                albumMusical.getEmpresaDiscografica().setNombreEmpresa(rs.getString("NOMBRE_EMPRESA"));
                albumMusical.setFechaLanzamiento(rs.getDate("FECHA_LANZAMIENTO"));
                albumMusical.setPortada(rs.getBytes("PORTADA"));
                albumMusical.setDescripcion(rs.getString("DESCRIPCION"));
                albumes.add(albumMusical);
            }
            for(AlbumMusical albumMusical : albumes){
                cs = con.prepareCall("{call LISTAR_TRACKS_POR_ID_ALBUM(?)}");
                cs.setInt("_ID_ALBUM", albumMusical.getIdAlbum());
                rs = cs.executeQuery();
                while(rs.next()){
                    Track track = new Track();
                    track.setIdTrack(rs.getInt("ID_TRACK"));
                    track.setNombreTrack(rs.getString("NOMBRE_TRACK"));
                    track.setPosicionAlbum(rs.getInt("POSICION_TRACK"));
                    track.setDuracion(rs.getTime("DURACION_TRACK"));
                    albumMusical.getTracks().add(track);
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return albumes;
    }

    @Override
    public int insertar(AlbumMusical albumMusical) {
        int resultado = 0;
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            cs = con.prepareCall("{call INSERTAR_ALBUM(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_ID_ALBUM", java.sql.Types.INTEGER);
            cs.setInt("_FID_GENERO_MUSICAL", albumMusical.getGeneroMusical().getIdGenero());
            cs.setInt("_FID_EMPRESA_DISCOGRAFICA", albumMusical.getEmpresaDiscografica().getIdEmpresa());
            cs.setInt("_FID_ARTISTA", albumMusical.getArtista().getIdArtista());
            cs.setString("_NOMBRE_ALBUM", albumMusical.getNombreAlbum());
            cs.setString("_DESCRIPCION", albumMusical.getDescripcion());
            cs.setDate("_FECHA_LANZAMIENTO", new java.sql.Date(albumMusical.getFechaLanzamiento().getTime()));
            cs.setBytes("_PORTADA", albumMusical.getPortada());
            cs.executeUpdate();
            albumMusical.setIdAlbum(cs.getInt("_ID_ALBUM"));
            resultado = albumMusical.getIdAlbum();
            for(Track track : albumMusical.getTracks()){
                cs = con.prepareCall("{call INSERTAR_TRACK(?,?,?,?)}");
                cs.setInt("_POSICION_TRACK", track.getPosicionAlbum());
                cs.setInt("_FID_ALBUM",albumMusical.getIdAlbum());
                cs.setString("_NOMBRE_TRACK", track.getNombreTrack());
                cs.setTime("_DURACION_TRACK", track.getDuracion());
                cs.executeUpdate();
            }
            con.commit();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            try{con.rollback();}catch(Exception exe){System.out.println(exe.getMessage());}
        }finally{
            try{con.setAutoCommit(true);con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
