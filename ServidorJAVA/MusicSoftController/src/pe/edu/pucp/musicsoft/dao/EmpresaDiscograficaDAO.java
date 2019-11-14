package pe.edu.pucp.musicsoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.musicsoft.model.EmpresaDiscografica;

public interface EmpresaDiscograficaDAO {
    ArrayList<EmpresaDiscografica> listar(String nombre);
}
