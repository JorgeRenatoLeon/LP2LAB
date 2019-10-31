package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class TipoItem implements Serializable{
    
    private int idTipoItem;
    private String tipo;

    public int getIdTipoItem() {
        return idTipoItem;
    }

    public void setIdTipoItem(int idTipoItem) {
        this.idTipoItem = idTipoItem;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    
}
