package pe.edu.pucp.marketsoft.config;

import pe.edu.pucp.marketsoft.dao.ProductoPresentacionDAO;
import pe.edu.pucp.marketsoft.dao.PromocionDAO;
import pe.edu.pucp.marketsoft.mysql.ProductoPresentacionMySQL;
import pe.edu.pucp.marketsoft.mysql.PromocionMySQL;

public class MySQLDAOFactory extends DAOFactory{

    @Override
    public ProductoPresentacionDAO getProductoPresentacionDAO() {
        return new ProductoPresentacionMySQL();
    }

    @Override
    public PromocionDAO getPromocionDAO() {
        return new PromocionMySQL();
    }
    
}
