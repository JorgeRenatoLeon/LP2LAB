package pe.edu.pucp.musicsoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.musicsoft.model.Artista;

public interface ArtistaDAO {
    ArrayList<Artista> listar(String nombre);
}
