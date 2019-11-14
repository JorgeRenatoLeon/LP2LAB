package pe.edu.pucp.musicsoft.config;

import pe.edu.pucp.musicsoft.dao.AlbumMusicalDAO;
import pe.edu.pucp.musicsoft.dao.ArtistaDAO;
import pe.edu.pucp.musicsoft.dao.EmpresaDiscograficaDAO;
import pe.edu.pucp.musicsoft.dao.GeneroMusicalDAO;
import pe.edu.pucp.musicsoft.mysql.AlbumMusicalMySQL;
import pe.edu.pucp.musicsoft.mysql.ArtistaMySQL;
import pe.edu.pucp.musicsoft.mysql.EmpresaDiscograficaMySQL;
import pe.edu.pucp.musicsoft.mysql.GeneroMusicalMySQL;

public class MySQLDAOFactory extends DAOFactory{
    public MySQLDAOFactory(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
        }catch(ClassNotFoundException ex){
            System.out.println(ex.getMessage());
        }
    }
    
    @Override
    public ArtistaDAO getArtistaDAO() {
        return new ArtistaMySQL();
    }

    @Override
    public GeneroMusicalDAO getGeneroMusicalDAO() {
        return new GeneroMusicalMySQL();
    }

    @Override
    public EmpresaDiscograficaDAO getEmpresaDiscograficaDAO() {
        return new EmpresaDiscograficaMySQL();
    }

    @Override
    public AlbumMusicalDAO getAlbumMusicalDAO() {
        return new AlbumMusicalMySQL();
    }

}
