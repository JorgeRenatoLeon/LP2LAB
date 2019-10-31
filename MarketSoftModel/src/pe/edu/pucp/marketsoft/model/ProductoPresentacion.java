package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class ProductoPresentacion extends ItemVenta implements Serializable{
    
    private Producto producto;
    private Presentacion presentacion;

    public ProductoPresentacion(){
        this.producto = new Producto();
        this.presentacion = new Presentacion();
    }
    
    public Producto getProducto() {
        return producto;
    }

    public void setProducto(Producto producto) {
        this.producto = producto;
    }

    public Presentacion getPresentacion() {
        return presentacion;
    }

    public void setPresentacion(Presentacion presentacion) {
        this.presentacion = presentacion;
    }
    
    @Override
    public String toString() {
        return this.getProducto().getNombre()+" - "+this.getPresentacion().getUnidadMedida();
    }
    
}
