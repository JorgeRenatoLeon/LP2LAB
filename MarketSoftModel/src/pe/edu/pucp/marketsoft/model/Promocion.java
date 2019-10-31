package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;
import java.util.ArrayList;

public class Promocion extends ItemVenta implements Serializable{
   
    private String nombre;
    private ArrayList<LineaDetallePromocion> lineasDetallePromocion;

    public Promocion(){
        lineasDetallePromocion = new ArrayList<>();
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public ArrayList<LineaDetallePromocion> getLineasDetallePromocion() {
        return lineasDetallePromocion;
    }

    public void setLineasDetallePromocion(ArrayList<LineaDetallePromocion> lineasDetallePromocion) {
        this.lineasDetallePromocion = lineasDetallePromocion;
    }

    
}
