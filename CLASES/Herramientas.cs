﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CLASES
{
    public class Herramientas
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public Herramientas()
        {
            con.ConnectionString = x.Conexion;
        }
        public int consecutuvivo(string campo, string tabla)
        {
            int id = 0;
            string consulta = $"select isnull(max({campo})+1,1) maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                id = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return id;
        }
    }
}
