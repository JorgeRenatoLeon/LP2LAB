package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class ItemVenta implements Serializable{
    
    private int idItemVenta;
    private TipoItem tipoItem;
    public float precioUnitario;

    public ItemVenta(){
        tipoItem = new TipoItem();
    }
    
    public int getIdItemVenta() {
        return idItemVenta;
    }

    public void setIdItemVenta(int idItemVenta) {
        this.idItemVenta = idItemVenta;
    }

    public TipoItem getTipoItem() {
        return tipoItem;
    }

    public void setTipoItem(TipoItem tipoItem) {
        this.tipoItem = tipoItem;
    }

    public float getPrecioUnitario() {
        return precioUnitario;
    }

    public void setPrecioUnitario(float precioUnitario) {
        this.precioUnitario = precioUnitario;
    }
    
}
