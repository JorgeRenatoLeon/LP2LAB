package pe.edu.pucp.musicsoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.musicsoft.config.DBManager;
import pe.edu.pucp.musicsoft.dao.EmpresaDiscograficaDAO;
import pe.edu.pucp.musicsoft.model.EmpresaDiscografica;

public class EmpresaDiscograficaMySQL implements EmpresaDiscograficaDAO{

    Connection con;
    CallableStatement cs;
    
    @Override
    public ArrayList<EmpresaDiscografica> listar(String nombre) {
        ArrayList<EmpresaDiscografica> empresas = new ArrayList<>();
        try{
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_EMPRESAS_DISCOGRAFICAS(?)}");
            cs.setString("_NOMBRE_EMPRESA", nombre);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                EmpresaDiscografica empresa = new EmpresaDiscografica();
                empresa.setIdEmpresa(rs.getInt("ID_EMPRESA_DISCOGRAFICA"));
                empresa.setNombreEmpresa(rs.getString("NOMBRE_EMPRESA"));
                empresas.add(empresa);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return empresas;
    }
}