package pe.edu.pucp.marketsoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.marketsoft.model.ProductoPresentacion;

public interface ProductoPresentacionDAO {
    public ArrayList<ProductoPresentacion> listarProductosPresentacionPorNombre(String nombre);
}
