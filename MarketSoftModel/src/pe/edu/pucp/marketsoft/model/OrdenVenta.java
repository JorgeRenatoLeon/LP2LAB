package pe.edu.pucp.marketsoft.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Date;

public class OrdenVenta implements Serializable{
    
    private int idOrdenVenta;
    private Cliente cliente;
    private Date fecha;
    private float total;
    private ArrayList<LineaOrdenVenta> lineasOrdenVenta;

    public OrdenVenta(){
        lineasOrdenVenta = new ArrayList<>();
        cliente = new Cliente();
    }
    
    public int getIdOrdenVenta() {
        return idOrdenVenta;
    }

    public void setIdOrdenVenta(int idOrdenVenta) {
        this.idOrdenVenta = idOrdenVenta;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public float getTotal() {
        return total;
    }

    public void setTotal(float total) {
        this.total = total;
    }

    public ArrayList<LineaOrdenVenta> getLineasOrdenVenta() {
        return lineasOrdenVenta;
    }

    public void setLineasOrdenVenta(ArrayList<LineaOrdenVenta> lineasOrdenVenta) {
        this.lineasOrdenVenta = lineasOrdenVenta;
    }
    
}
