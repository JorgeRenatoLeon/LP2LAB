package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class Producto implements Serializable{
    
    private int idProducto;
    private String nombre;

    public int getIdProducto() {
        return idProducto;
    }

    public void setIdProducto(int idProducto) {
        this.idProducto = idProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
}
