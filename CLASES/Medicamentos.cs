using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Medicamentos
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos
        public int id;
        public string Nombre;
        public string Tipo;
        public int Cantidad;
        public decimal Precio;

        public Medicamentos()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Medicamentos (id, Nombre, Tipo, Cantidad, Precio) values ({id}, '{Nombre}', '{Tipo}', {Cantidad}, {Precio} )";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Proceso Exitoso";

            return msj;
        }

        public String actualizar()
        {
            string msj = "";
            string consulta = $"update Medicamentos set Nombre = '{Nombre}', Tipo = '{Tipo}', Cantidad = {Cantidad}, Precio = {Precio} where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteReader();
            con.Close();
            msj = "Se actualizo en la base de datos";

            return msj;
        }

        public string eliminar()
        {
            string msj = "";
            string consulta = $"delete from Medicamentos where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino de la base de datos";
            return msj;
        }
    }
}