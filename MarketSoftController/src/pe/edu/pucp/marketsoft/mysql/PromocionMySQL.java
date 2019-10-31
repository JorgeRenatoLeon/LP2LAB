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
import pe.edu.pucp.marketsoft.dao.PromocionDAO;
import pe.edu.pucp.marketsoft.model.LineaDetallePromocion;
import pe.edu.pucp.marketsoft.model.Promocion;

public class PromocionMySQL implements PromocionDAO{

    Connection con;
    CallableStatement cs;
    
    @Override
    public int insertar(Promocion promocion) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            cs = con.prepareCall("{call INSERTAR_PROMOCION(?,?,?)}");
            cs.setFloat("_PRECIO_UNITARIO", promocion.getPrecioUnitario());
            cs.setString("_NOMBRE_PROMOCION", promocion.getNombre());
            cs.registerOutParameter("_ID_ITEM_VENTA", java.sql.Types.INTEGER);
            cs.executeUpdate();
            promocion.setIdItemVenta(cs.getInt("_ID_ITEM_VENTA"));
            for(LineaDetallePromocion dp : promocion.getLineasDetallePromocion()){
                cs = con.prepareCall("{call INSERTAR_LINEA_DETALLE_PROMOCION(?,?,?)}");
                cs.setInt("_FID_PROMOCION", promocion.getIdItemVenta());
                cs.setInt("_FID_PRODUCTO_PRESENTACION", dp.getProductoPresentacion().getIdItemVenta());
                cs.setInt("_CANTIDAD",dp.getCantidad());
                cs.executeUpdate();
            }
            con.commit();
            resultado = 1;
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
            try{con.rollback();}catch(SQLException exe){System.out.println(exe.getMessage());}
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(PromocionMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }finally{
            try{con.setAutoCommit(true);cs.close();con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(Promocion promocion) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            cs = con.prepareCall("{call ACTUALIZAR_PROMOCION(?,?,?)}");
            cs.setInt("_ID_PROMOCION", promocion.getIdItemVenta());
            cs.setString("_NOMBRE_PROMOCION", promocion.getNombre());
            cs.setFloat("_PRECIO_UNITARIO", promocion.getPrecioUnitario());
            cs.executeUpdate();
            for(LineaDetallePromocion dp : promocion.getLineasDetallePromocion()){
                cs = con.prepareCall("{call INSERTAR_LINEA_DETALLE_PROMOCION(?,?,?)}");
                cs.setInt("_FID_PROMOCION", promocion.getIdItemVenta());
                cs.setInt("_FID_PRODUCTO_PRESENTACION", dp.getProductoPresentacion().getIdItemVenta());
                cs.setInt("_CANTIDAD",dp.getCantidad());
                cs.executeUpdate();
            }
            con.commit();
            resultado = 1;
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
            try{con.rollback();}catch(SQLException exe){System.out.println(exe.getMessage());}
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(PromocionMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }finally{
            try{con.setAutoCommit(true);cs.close();con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idPromocion) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_PROMOCION(?)}");
            cs.setInt("_ID_PROMOCION", idPromocion);
            resultado = cs.executeUpdate();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(PromocionMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }
        return resultado;
    }

    @Override
    public ArrayList<Promocion> listar(String nombre) {
        ArrayList<Promocion> promociones = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PROMOCIONES(?)}");
            cs.setString("_NOMBRE_PROMOCION", nombre);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Promocion p = new Promocion();
                p.setIdItemVenta(rs.getInt("ID_ITEM_VENTA"));
                p.setNombre(rs.getString("NOMBRE_PROMOCION"));
                p.setPrecioUnitario(rs.getFloat("PRECIO_UNITARIO"));
                promociones.add(p);
            }
            for(Promocion p : promociones){
                cs = con.prepareCall("{call LISTAR_LINEAS_DETALLE_PROMOCION(?)}");
                cs.setInt("_ID_PROMOCION", p.getIdItemVenta());
                rs = cs.executeQuery();
                while(rs.next()){
                    LineaDetallePromocion ldp = new LineaDetallePromocion();
                    ldp.setIdLineaDetallePromocion(rs.getInt("ID_LINEA_DETALLE_PROMOCION"));
                    ldp.setCantidad(rs.getInt("CANTIDAD"));
                    ldp.getProductoPresentacion().setIdItemVenta(rs.getInt("ID_PRODUCTO_PRESENTACION"));
                    ldp.getProductoPresentacion().getProducto().setIdProducto(rs.getInt("ID_PRODUCTO"));
                    ldp.getProductoPresentacion().getProducto().setNombre(rs.getString("NOMBRE_PRODUCTO"));
                    ldp.getProductoPresentacion().getPresentacion().setIdPresentacion(rs.getInt("ID_PRESENTACION"));
                    ldp.getProductoPresentacion().getPresentacion().setUnidadMedida(rs.getString("UNIDAD_MEDIDA"));
                    ldp.getProductoPresentacion().setPrecioUnitario(rs.getFloat("PRECIO_UNITARIO"));
                    p.getLineasDetallePromocion().add(ldp);
                }
            }
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(PromocionMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return promociones;
    }
}
