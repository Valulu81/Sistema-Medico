using PrototipoPED.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.ConexionBD
{
    public class Conexion
    {
        //    private string ConecStr = "data source=localhost; initial catalog=Clinica;" +
        //    " persist security info=True; Integrated Security=SSPI; ";

        //    public void AgregarPaciente(string pnom, string snom, string pape, string sape, string dir, string tel, string sex, DateTime fecha, string dui, string nit)
        //    {
        //        string query = "exec administracion.InscribirPaciente " +
        //            "@pnom, @snom, @pape, @sape, @dir, @tel, @sex, @fecha, @dui, @nit";

        //        using (SqlConnection cnn = new SqlConnection(ConecStr))
        //        {
        //            try
        //            {
        //                cnn.Open();
        //                SqlCommand cmd = new SqlCommand(query, cnn);

        //                cmd.Parameters.AddWithValue("@pnom", pnom);
        //                cmd.Parameters.AddWithValue("@snom", snom);
        //                cmd.Parameters.AddWithValue("@pape", pape);
        //                cmd.Parameters.AddWithValue("@sape", sape);
        //                cmd.Parameters.AddWithValue("@dir", dir);
        //                cmd.Parameters.AddWithValue("@tel", tel);
        //                cmd.Parameters.AddWithValue("@sex", sex);
        //                cmd.Parameters.AddWithValue("@fecha",fecha);
        //                cmd.Parameters.AddWithValue("@dui", dui);
        //                cmd.Parameters.AddWithValue("@nit", nit);

        //                cmd.ExecuteNonQuery();
        //                cnn.Close();
        //            }
        //            catch (Exception ex) { throw new Exception("Error en la bd: " + ex.Message); }
        //        }
        //    }


        //    public Paciente DatosPaciente(string nomb)
        //    {
        //        string query = "select codPaciente, primerNombre, primerApellido,edad from personas" +
        //            " where id=@id";

        //        using (SqlConnection conn = new SqlConnection(ConecStr))
        //        {
        //            SqlCommand cmd = new SqlCommand(query, conn);

        //            cmd.Parameters.AddWithValue("@id", id);

        //            try
        //            {
        //                conn.Open();
        //                SqlDataReader reader = cmd.ExecuteReader();

        //                Paciente per = new Paciente();
        //                reader.Read();

        //                per.Id = reader.GetInt32(0);
        //                per.Nombre = reader.GetString(1);
        //                per.Apellido = reader.GetString(2);
        //                per.Edad = reader.GetInt32(3);

        //                reader.Close();
        //                conn.Close();

        //                return per;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Hay un error en la bd: " + ex.Message);
        //            }

        //        }
        //    }
        
    }
}
