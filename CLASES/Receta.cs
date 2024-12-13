using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Receta
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos
        public int id;
        public int medicamento;
        public int paciente;
        public int factura;
        public int cita;

        public Receta()
        {
            con.ConnectionString = x.Conexion;
        }

        public String guardar()
        {
            string msj = "";
            string consulta = $"insert into Receta (id, id_Medicamento, id_Paciente, id_Factura, id_DetalleC) values ({id}, {medicamento}, {paciente}, {factura}, {cita})";
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
            string consulta = $"update Receta set id_Medicamento = {medicamento}, id_Paciente = {paciente}, id_Factura = {factura}, id_DetalleC = {cita} where id = {id}";
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
            string consulta = $"delete from Receta where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro de la base de datos bro";
            return msj;
        }
    }
}
