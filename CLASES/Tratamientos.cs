using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Tratamientos
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Descripcion;
        public int Duracion;
        public int idEstado;

        public Tratamientos()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Tratamientos (id, Descripcion, Duracion, id_estado) values ({id}, '{Descripcion}', {Duracion}, {idEstado})";
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
            string consulta = $"update Tratamientos set Descripcion = '{Descripcion}', Duracion = {Duracion}, id_estado = {idEstado} where id = {id}";
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
            string consulta = $"delete from Tratamientos where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro de la base de datos bro";
            return msj;
        }
    }
}
