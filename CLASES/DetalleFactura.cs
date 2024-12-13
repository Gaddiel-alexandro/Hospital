using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class DetalleFactura
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public int idfactura;
        public int idtratamientos;
        public int cantidad;

        public DetalleFactura()
        {
            con.ConnectionString = x.Conexion;
        }

        public  string guardar()
        {
            string msj = "";
            string consulta = $"insert into Detalle_Factura (id, id_Factura, id_Tratamientos, cantidad) values ({id}, {idfactura}, {idtratamientos}, {cantidad})";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Proceso Exitoso";

            return msj;
        }

        public string actualizar()
        {
            string msj = "";
            string consulta = $"update Detalle_Factura set id_Factura = {idfactura}, id_Tratamientos = {idtratamientos}, cantidad = {cantidad} where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteReader();
            con.Close();
            msj = "se actualizo en el centro de datos";
            return msj;
        }

        public string eliminar()
        {
            string msj = "";
            string consulta = $"delete from Detalle_Factura where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro de la base de datos bro";
            return msj;
        }
    }
}
