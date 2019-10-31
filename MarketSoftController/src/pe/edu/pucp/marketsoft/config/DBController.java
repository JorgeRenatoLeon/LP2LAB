package pe.edu.pucp.marketsoft.config;

import java.util.ArrayList;
import pe.edu.pucp.marketsoft.model.ProductoPresentacion;
import pe.edu.pucp.marketsoft.model.Promocion;

public abstract class DBController {
    private static final DAOFactory daoFactory = DAOFactory.getDAOFactory();
    
    public static ArrayList<ProductoPresentacion> listarProductosPresentacionPorNombre(String nombre){
        return daoFactory.getProductoPresentacionDAO().listarProductosPresentacionPorNombre(nombre);
    }
    
    public static int insertarPromocion(Promocion promocion){
        return daoFactory.getPromocionDAO().insertar(promocion);
    }
    
    public static ArrayList<Promocion> listarPromociones(String nombre){
        return daoFactory.getPromocionDAO().listar(nombre);
    }
    
    public static int actualizarPromocion(Promocion promocion){
        return daoFactory.getPromocionDAO().actualizar(promocion);
    }
    
    public static int eliminarPromocion(int idPromocion){
        return daoFactory.getPromocionDAO().eliminar(idPromocion);
    }
}