using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Facturas
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public int idpaciente;
        public string fechafactura;
        public decimal total;
        public int idproducto;
        public string descripcion;
        public int cantidad;

        public Facturas()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Facturas (id, id_Pacientes, Fecha_Factura, total, idProducto, Descripcion, Cantidad) values ({id}, {idpaciente}, '{fechafactura}', {total}, {idproducto}, '{descripcion}', {cantidad})";
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
            string consulta = $"update Facturas set Descripcion = '{descripcion}', id_Pacientes = {idpaciente}, Fecha_Factura = '{fechafactura}', total = {total}, idProducto = {idproducto}, Cantidad = {cantidad} where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteReader();
            con.Close();
            msj = "Se Actualizo En La Base De Datos";
            return msj;
        }

        public string eliminar()
        {
            string msj = " ";
            string consulta = $"delete from Facturas where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro de la base de datos bro";
            return msj;
        }
    }
}
