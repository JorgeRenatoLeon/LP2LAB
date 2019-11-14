package pe.edu.pucp.musicsoft.model;

public class Artista {
    private int idArtista;
    private String nombreArtista;
    private String nacionalidad;

    public Artista() {
    }

    public Artista(int idArtista, String nombreArtista) {
        this.idArtista = idArtista;
        this.nombreArtista = nombreArtista;
    }

    public int getIdArtista() {
        return idArtista;
    }

    public void setIdArtista(int idArtista) {
        this.idArtista = idArtista;
    }

    public String getNombreArtista() {
        return nombreArtista;
    }

    public void setNombreArtista(String nombreArtista) {
        this.nombreArtista = nombreArtista;
    }

    public String getNacionalidad() {
        return nacionalidad;
    }

    public void setNacionalidad(String nacionalidad) {
        this.nacionalidad = nacionalidad;
    }
    
}
