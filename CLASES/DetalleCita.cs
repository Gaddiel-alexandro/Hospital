using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class DetalleCita
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();


        public int id;
        public int cita;
        public int tratamiento;
        public int estado;

        public DetalleCita()
        {
            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Detalle_Citas (id, id_Cita, id_Tratamiento, id_estado) values ({id}, {cita}, {tratamiento}, {estado})";
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
            string consulta = $"update Detalle_Citas set id_Cita = {cita}, id_Tratamiento = {tratamiento}, id_estado = {estado} where id = {id}";
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

            string consulta = $"delete from Detalle_Citas where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro de la base de datos bro";
            return msj;
        }
    }
}
