package pe.edu.pucp.musicsoft.config;

import pe.edu.pucp.musicsoft.dao.AlbumMusicalDAO;
import pe.edu.pucp.musicsoft.dao.ArtistaDAO;
import pe.edu.pucp.musicsoft.dao.EmpresaDiscograficaDAO;
import pe.edu.pucp.musicsoft.dao.GeneroMusicalDAO;

public abstract class DAOFactory {
    public abstract ArtistaDAO getArtistaDAO();
    public abstract GeneroMusicalDAO getGeneroMusicalDAO();
    public abstract EmpresaDiscograficaDAO getEmpresaDiscograficaDAO();
    public abstract AlbumMusicalDAO getAlbumMusicalDAO();
    
    public static DAOFactory getDAOFactory(){
        return new MySQLDAOFactory();
    }
    
}
