package pe.edu.pucp.marketsoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.marketsoft.config.DBManager;
import pe.edu.pucp.marketsoft.dao.ProductoPresentacionDAO;
import pe.edu.pucp.marketsoft.model.ProductoPresentacion;

public class ProductoPresentacionMySQL implements ProductoPresentacionDAO{

    Connection con;
    CallableStatement cs;
    
    @Override
    public ArrayList<ProductoPresentacion> listarProductosPresentacionPorNombre(String nombre) {
        ArrayList<ProductoPresentacion> productosPresentacion = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_PRESENTACION(?)}");
            cs.setString("_NOMBRE_PRODUCTO", nombre);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                ProductoPresentacion pp = new ProductoPresentacion();
                pp.getProducto().setIdProducto(rs.getInt("ID_PRODUCTO"));
                pp.getProducto().setNombre(rs.getString("NOMBRE_PRODUCTO"));
                pp.getPresentacion().setIdPresentacion(rs.getInt("ID_PRESENTACION"));
                pp.getPresentacion().setUnidadMedida(rs.getString("UNIDAD_MEDIDA"));
                pp.setPrecioUnitario(rs.getFloat("PRECIO_UNITARIO"));
                pp.setIdItemVenta(rs.getInt("ID_ITEM_VENTA"));
                productosPresentacion.add(pp);
            }
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(ProductoPresentacionMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return productosPresentacion;
    }
}
