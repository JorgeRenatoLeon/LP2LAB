package pe.edu.pucp.musicsoft.config;

import java.util.ArrayList;
import pe.edu.pucp.musicsoft.model.AlbumMusical;
import pe.edu.pucp.musicsoft.model.Artista;
import pe.edu.pucp.musicsoft.model.EmpresaDiscografica;
import pe.edu.pucp.musicsoft.model.GeneroMusical;

public abstract class DBController {
    private static final DAOFactory daoFactory = DAOFactory.getDAOFactory();
    
     public static ArrayList<Artista> listarArtistas(String nombre){
        return daoFactory.getArtistaDAO().listar(nombre);
    }
     
     public static ArrayList<GeneroMusical> listarGenerosMusicales(){
         return daoFactory.getGeneroMusicalDAO().listar();
     }
     
     public static ArrayList<EmpresaDiscografica> listarEmpresasDiscograficas(String nombre){
         return daoFactory.getEmpresaDiscograficaDAO().listar(nombre);
     }
     
     public static ArrayList<AlbumMusical> listarAlbumesMusicales(String nombre){
         return daoFactory.getAlbumMusicalDAO().listar(nombre);
     }
     
     public static int insertarAlbum(AlbumMusical albumMusical){
         return daoFactory.getAlbumMusicalDAO().insertar(albumMusical);
     }
}
