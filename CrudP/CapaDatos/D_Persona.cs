using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Persona
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Persona>ConsultarPersonas(E_Persona persona)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_CONSULTARPERSONA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
           
            leerFilas = cmd.ExecuteReader();

            List<E_Persona> listar = new List<E_Persona>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Persona
                {
                    IdPersona = leerFilas.GetInt32(0),
                    NombrePersona = leerFilas.GetString(1),
                    ApellidosPersona = leerFilas.GetString(2),
                    FechaNacimientoPersona = leerFilas.GetDateTime(3),
                    TipoIdentificacionPersona = leerFilas.GetString(4),
                    NumeroIdentificacion = leerFilas.GetInt32(5)

                });
            }
            conexion.Close();
                leerFilas.Close();
            return listar;
        }
        public List<E_Persona> ListarPersonas(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARPERSONA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            leerFilas = cmd.ExecuteReader();

            List<E_Persona> listar = new List<E_Persona>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Persona
                {
                    IdPersona = leerFilas.GetInt32(0),
                    NombrePersona = leerFilas.GetString(1),
                    ApellidosPersona = leerFilas.GetString(2),
                    FechaNacimientoPersona = leerFilas.GetDateTime(3),
                    TipoIdentificacionPersona = leerFilas.GetString(4),
                    NumeroIdentificacion = leerFilas.GetInt32(5)
                  


                });
            }
            conexion.Close();
            leerFilas.Close();
            return listar;
        }
        public void InsertarPersona(E_Persona Persona)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARPERSONA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@NOMBRES", Persona.NombrePersona);
            cmd.Parameters.AddWithValue("@APELLIDOS", Persona.ApellidosPersona);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", Persona.FechaNacimientoPersona);
            cmd.Parameters.AddWithValue("@TIPO_IDENTIFICACION", Persona.TipoIdentificacionPersona);
            cmd.Parameters.AddWithValue("@NUMERO_IDENTIFICACION", Persona.NumeroIdentificacion);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void EditarPersona(E_Persona Persona)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARPERSONA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDPERSONA", Persona.IdPersona);
            cmd.Parameters.AddWithValue("@NOMBRES", Persona.NombrePersona);
            cmd.Parameters.AddWithValue("@APELLIDOS", Persona.ApellidosPersona);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", Persona.FechaNacimientoPersona);
            cmd.Parameters.AddWithValue("@TIPO_IDENTIFICACION", Persona.TipoIdentificacionPersona);
            cmd.Parameters.AddWithValue("@NUMERO_IDENTIFICACION", Persona.NumeroIdentificacion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarPersona(E_Persona Persona)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARPERSONA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDPERSONA", Persona.IdPersona);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}


