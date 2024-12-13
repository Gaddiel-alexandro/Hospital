using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Pacientes
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Nombre;
        public string A_Paterno;
        public string A_Materno;
        public string FechaNacimiento;
        public int edad;
        public int idGenero;
        public int idEnfermedad;
        public int idMedico;
        public int idCitaM;
        public int idMedicamento;

        public Pacientes()
        {

            con.ConnectionString = x.Conexion;
        }

        public string guardar()
        {
            string msj = "";
            string consulta = $"insert into Pacientes (id, Nombre, A_Paterno, A_Materno, FechaNacimiento, Edad, id_Genero, id_Enfermedad, id_Medico, id_CitaM, id_Medicamento) values ({id}, '{Nombre}', '{A_Paterno}', '{A_Materno}', '{FechaNacimiento}', {edad}, {idGenero}, {idEnfermedad}, {idMedico}, {idCitaM}, {idMedicamento})";
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
            string consulta = $"update Pacientes set Nombre = '{Nombre}', A_Paterno = '{A_Paterno}', A_Materno = '{A_Materno}', FechaNacimiento = '{FechaNacimiento}', Edad = {edad}, id_Genero = {idGenero}, id_Enfermedad = {idEnfermedad}, id_Medico =  {idMedico}, id_CitaM = {idCitaM}, id_Medicamento = {idMedicamento} where id {id}";
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
            string consulta = $"delete from Pacientes where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se elimino el registro bro";
            return msj;
        }
    }
}
