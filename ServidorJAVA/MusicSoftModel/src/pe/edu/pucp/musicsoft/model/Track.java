package pe.edu.pucp.musicsoft.model;

import java.io.Serializable;
import java.sql.Time;

public class Track implements Serializable{
    private int idTrack;
    private int posicionAlbum;
    private String nombreTrack;
    private Time duracion;

    public int getIdTrack() {
        return idTrack;
    }

    public void setIdTrack(int idTrack) {
        this.idTrack = idTrack;
    }

    public int getPosicionAlbum() {
        return posicionAlbum;
    }

    public void setPosicionAlbum(int posicionAlbum) {
        this.posicionAlbum = posicionAlbum;
    }

    public String getNombreTrack() {
        return nombreTrack;
    }

    public void setNombreTrack(String nombreTrack) {
        this.nombreTrack = nombreTrack;
    }

    public Time getDuracion() {
        return duracion;
    }

    public void setDuracion(Time duracion) {
        this.duracion = duracion;
    }
    
}
