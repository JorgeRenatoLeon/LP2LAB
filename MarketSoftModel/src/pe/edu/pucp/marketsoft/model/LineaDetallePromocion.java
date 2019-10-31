package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class LineaDetallePromocion implements Serializable{
    
    private int idLineaDetallePromocion;
    private ProductoPresentacion productoPresentacion;
    private int cantidad;

    public LineaDetallePromocion(){
        productoPresentacion = new ProductoPresentacion();
    }
    
    public int getIdLineaDetallePromocion() {
        return idLineaDetallePromocion;
    }

    public void setIdLineaDetallePromocion(int idLineaDetallePromocion) {
        this.idLineaDetallePromocion = idLineaDetallePromocion;
    }

    public ProductoPresentacion getProductoPresentacion() {
        return productoPresentacion;
    }

    public void setProductoPresentacion(ProductoPresentacion productoPresentacion) {
        this.productoPresentacion = productoPresentacion;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }
    
    
}
