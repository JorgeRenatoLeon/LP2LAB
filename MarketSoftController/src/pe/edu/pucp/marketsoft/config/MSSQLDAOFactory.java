package pe.edu.pucp.marketsoft.config;

import pe.edu.pucp.marketsoft.dao.ProductoPresentacionDAO;
import pe.edu.pucp.marketsoft.dao.PromocionDAO;


public class MSSQLDAOFactory extends DAOFactory{

    @Override
    public ProductoPresentacionDAO getProductoPresentacionDAO() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public PromocionDAO getPromocionDAO() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
