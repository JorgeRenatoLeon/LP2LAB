package pe.edu.pucp.marketsoft.config;

import pe.edu.pucp.marketsoft.dao.ProductoPresentacionDAO;
import pe.edu.pucp.marketsoft.dao.PromocionDAO;

public abstract class DAOFactory {
    
    public abstract ProductoPresentacionDAO getProductoPresentacionDAO();
    public abstract PromocionDAO getPromocionDAO();
    
    public static DAOFactory getDAOFactory(){
        if(DBManager.url.contains("mysql"))
            return new MySQLDAOFactory();
        else
            return new MSSQLDAOFactory();
    }
}
