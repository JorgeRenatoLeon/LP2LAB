/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.musicsoft.services;

import java.util.ArrayList;
import java.util.TimeZone;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.musicsoft.config.DBController;
import pe.edu.pucp.musicsoft.model.AlbumMusical;
import pe.edu.pucp.musicsoft.model.Artista;
import pe.edu.pucp.musicsoft.model.EmpresaDiscografica;
import pe.edu.pucp.musicsoft.model.GeneroMusical;

/**
 *
 * @author alulab14
 */
@WebService(serviceName = "Servicio")
public class Servicio {

    public Servicio(){
        TimeZone.setDefault(TimeZone.getTimeZone("UTC"));
    }
    
    @WebMethod(operationName = "listarAlbums")
    public ArrayList<AlbumMusical> listarAlbums(@WebParam(name = "nombre") String nombre){
        return DBController.listarAlbumesMusicales(nombre);
    }
    
    @WebMethod(operationName = "listarEmpresas")
    public ArrayList<EmpresaDiscografica> listarEmpresas(@WebParam(name = "nombre")String nombre){
        return DBController.listarEmpresasDiscograficas(nombre);
    }
    
    @WebMethod(operationName = "listarGeneros")
    public ArrayList<GeneroMusical> listarGeneros(){
        return DBController.listarGenerosMusicales();
    }
    
    @WebMethod(operationName = "listarArtistas")
    public ArrayList<Artista> listarArtistas(@WebParam(name = "nombre")String nombre){
        return DBController.listarArtistas(nombre);
    }
    
    @WebMethod(operationName = "insertarAlbum")
    public int insertarAlbum(@WebParam(name = "album")AlbumMusical album){
        return DBController.insertarAlbum(album);
    }
    
}
