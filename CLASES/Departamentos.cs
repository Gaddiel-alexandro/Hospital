using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Departamentos
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos
        public int id;
        public string Nombre;
        public string Descripcion;

        public Departamentos()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Departamentos (id, Nombre, Descripcion) values ({id}, '{Nombre}', '{Descripcion}')";
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
            string consulta = $"update Departamentos set Nombre = '{Nombre}', Descripcion = '{Descripcion}' where id = {id}";
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
            string consulta = $"delete from Departamentos where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();

            msj = "se elimino el registro de la base de datos";
            return msj;
        }
    }
}
