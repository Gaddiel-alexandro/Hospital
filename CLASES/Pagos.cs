using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Pagos
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public int idfactura;
        public string fechapago;
        public decimal monto;

        public Pagos()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Pagos (id, id_Factura, fecha_pago, monto) values ({id}, {idfactura}, '{fechapago}', {monto})";
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
            string consulta = $"update Pagos set id_Factura = {idfactura}, fecha_pago = '{fechapago}', monto = {monto} where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteReader();
            con.Close();
            msj = "Se Actualizo En La Base De Datos";
            return msj;
        }

        public string eliminar()
        {
            string msj = "";
            string consulta = $"delet from Pagos where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro de la base de datos bro";
            return msj;
        }

        public string pago()
        {
            string msj = "";
            string consulta = $"delete from Facturas where id = {idfactura}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Pago exitoso";
            return msj;
        }
    }
}
