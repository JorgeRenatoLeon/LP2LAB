package pe.edu.pucp.musicsoft.model;

import java.io.Serializable;

public class GeneroMusical implements Serializable{
    private int idGenero;
    private String nombreGenero;

    public GeneroMusical() {
    }

    public GeneroMusical(int idGenero, String nombreGenero) {
        this.idGenero = idGenero;
        this.nombreGenero = nombreGenero;
    }

    public int getIdGenero() {
        return idGenero;
    }

    public void setIdGenero(int idGenero) {
        this.idGenero = idGenero;
    }

    public String getNombreGenero() {
        return nombreGenero;
    }

    public void setNombreGenero(String nombreGenero) {
        this.nombreGenero = nombreGenero;
    }
    
    @Override
    public String toString(){
        return nombreGenero;
    }
}
