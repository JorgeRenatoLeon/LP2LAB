package pe.edu.pucp.musicsoft.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Date;

public class AlbumMusical implements Serializable{
    private int idAlbum;
    private GeneroMusical generoMusical;
    private ArrayList<Track> tracks;
    private String nombreAlbum;
    private Date fechaLanzamiento;
    private byte[] portada;
    private EmpresaDiscografica empresaDiscografica;
    private Artista artista;
    private String descripcion;
    
    public AlbumMusical(){
        this.generoMusical = new GeneroMusical();
        this.tracks = new ArrayList<>();
        this.empresaDiscografica = new EmpresaDiscografica();
        this.artista = new Artista();
    }

    public int getIdAlbum() {
        return idAlbum;
    }

    public void setIdAlbum(int idAlbum) {
        this.idAlbum = idAlbum;
    }

    public GeneroMusical getGeneroMusical() {
        return generoMusical;
    }

    public void setGeneroMusical(GeneroMusical generoMusical) {
        this.generoMusical = generoMusical;
    }

    public ArrayList<Track> getTracks() {
        return tracks;
    }

    public void setTracks(ArrayList<Track> tracks) {
        this.tracks = tracks;
    }

    public String getNombreAlbum() {
        return nombreAlbum;
    }

    public void setNombreAlbum(String nombreAlbum) {
        this.nombreAlbum = nombreAlbum;
    }

    public Date getFechaLanzamiento() {
        return fechaLanzamiento;
    }

    public void setFechaLanzamiento(Date fechaLanzamiento) {
        this.fechaLanzamiento = fechaLanzamiento;
    }

    public byte[] getPortada() {
        return portada;
    }

    public void setPortada(byte[] portada) {
        this.portada = portada;
    }

    public EmpresaDiscografica getEmpresaDiscografica() {
        return empresaDiscografica;
    }

    public void setEmpresaDiscografica(EmpresaDiscografica empresaDiscografica) {
        this.empresaDiscografica = empresaDiscografica;
    }

    public Artista getArtista() {
        return artista;
    }

    public void setArtista(Artista artista) {
        this.artista = artista;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
}
