/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.marketsoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.marketsoft.config.DBController;
import pe.edu.pucp.marketsoft.model.Promocion;

/**
 *
 * @author alulab14
 */
@WebService(serviceName = "Servicio")
public class Servicio {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "insertarPromociones")
    public int insertarPromociones(@WebParam(name = "Promocion") Promocion promocion){
        return DBController.insertarPromocion(promocion);
    }
    
    @WebMethod(operationName = "actualizarPromociones")
    public int actualizarPromociones(@WebParam(name = "Promocion") Promocion promocion){
        return DBController.actualizarPromocion(promocion);
    }
    
    @WebMethod(operationName = "eliminarPromociones")
    public int eliminarPromociones(@WebParam(name = "id_promocion") int id_promocion){
        return DBController.eliminarPromocion(id_promocion);
    }
    
    @WebMethod(operationName = "listarPromociones")
    public ArrayList<Promocion> listarPromociones(@WebParam(name = "nombre") String nombre){
        return DBController.listarPromociones(nombre);
    }
}
