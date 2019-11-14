package pe.edu.pucp.musicsoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.musicsoft.model.AlbumMusical;

public interface AlbumMusicalDAO {
    ArrayList<AlbumMusical> listar(String nombre);
    int insertar(AlbumMusical albumMusical);
}
