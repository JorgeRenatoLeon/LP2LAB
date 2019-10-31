package pe.edu.pucp.marketsoft.dao;
import java.util.ArrayList;
import pe.edu.pucp.marketsoft.model.Promocion;

public interface PromocionDAO {
    public int insertar(Promocion promocion);
    public int actualizar(Promocion promocion);
    public int eliminar(int idPromocion);
    public ArrayList<Promocion> listar(String nombre);
}
