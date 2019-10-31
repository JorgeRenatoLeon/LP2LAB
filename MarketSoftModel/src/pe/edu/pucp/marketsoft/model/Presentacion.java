package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;

public class Presentacion implements Serializable{
    
    private int idPresentacion;
    private String unidadMedida;

    public int getIdPresentacion() {
        return idPresentacion;
    }

    public void setIdPresentacion(int idPresentacion) {
        this.idPresentacion = idPresentacion;
    }

    public String getUnidadMedida() {
        return unidadMedida;
    }

    public void setUnidadMedida(String unidadMedida) {
        this.unidadMedida = unidadMedida;
    }
    
    
}
