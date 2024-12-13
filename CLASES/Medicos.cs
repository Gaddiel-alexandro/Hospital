using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Medicos
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Nombre;
        public string Especialidad;
        public string Uni;
        public string Telefono;
        public int idDepartamento;

        public Medicos()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Medico (id, Nombre, Especialidad, Egre_Uni, Telefono, Dep_Medico) values ({id}, '{Nombre}', '{Especialidad}', '{Uni}', '{Telefono}', {idDepartamento})";
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
            string consulta = $"update Medico set Nombre = '{Nombre}', Especialidad = '{Especialidad}', Egre_Uni = '{Uni}', Telefono = '{Telefono}', Dep_Medico = {idDepartamento}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteReader();
            con.Close();
            msj = "se ejecuto el metodo";
            return msj;
        }

        public string eliminar()
        {
            string msj = "";
            string consulta = $"delete from Medico where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro bro";
            return msj;
        }
    }
}
