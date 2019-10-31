package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class LineaOrdenVenta implements Serializable{
    
    private int idLineaOrdenVenta;
    private ItemVenta itemVenta;
    private int cantidad;
    private float subtotal;

    public int getIdLineaOrdenVenta() {
        return idLineaOrdenVenta;
    }

    public void setIdLineaOrdenVenta(int idLineaOrdenVenta) {
        this.idLineaOrdenVenta = idLineaOrdenVenta;
    }

    public ItemVenta getItemVenta() {
        return itemVenta;
    }

    public void setItemVenta(ItemVenta itemVenta) {
        this.itemVenta = itemVenta;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public float getSubtotal() {
        return subtotal;
    }

    public void setSubtotal(float subtotal) {
        this.subtotal = subtotal;
    }
    
    
}
