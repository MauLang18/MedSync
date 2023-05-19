using GuardiasAPI.Models;
using GuardiasAPI.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Antlr.Runtime.Misc;
using System.Runtime.Remoting.Messaging;

namespace GuardiasAPI.Datos
{
    public class EmpleadoDatos
    {
        public static List<EmpleadoModel> obtenerEmpleados(EmpleadoModel pempleado)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "DRAINSA.PA_CON_TBL_GUA_EMPLEADO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (pempleado == null)
                {
                    pempleado = new EmpleadoModel();
                }

                cmd.Parameters.AddWithValue("@P_OPCION ", pempleado.OPCION);
                cmd.Parameters.AddWithValue("@P_USUARIO", pempleado.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_PK_TBL_GUA_EMPLEADO ", pempleado.PK_TBL_GUA_EMPLEADO);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACION ", pempleado.IDENTIFICACION);


                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<EmpleadoModel> lista = new List<EmpleadoModel>();

                while (reader.Read())
                {
                    EmpleadoModel obj = new EmpleadoModel();
                    obj.PK_TBL_GUA_EMPLEADO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_GUA_EMPLEADO");
                    obj.IDENTIFICACION = UtilitarioDatos.ObtieneString(reader, "IDENTIFICACION");
                    obj.NOMBRE = UtilitarioDatos.ObtieneString(reader, "NOMBRE");
                    obj.APELLIDO1 = UtilitarioDatos.ObtieneString(reader, "APELLIDO1");
                    obj.APELLIDO2 = UtilitarioDatos.ObtieneString(reader, "APELLIDO2");
                    obj.TELEFONO = UtilitarioDatos.ObtieneString(reader, "TELEFONO");
                    obj.DIRECCION = UtilitarioDatos.ObtieneString(reader, "DIRECCION");
                    obj.CORREO = UtilitarioDatos.ObtieneString(reader, "CORREO");

                    lista.Add(obj);
                }
                reader.Dispose();
                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos la obtener los empleado \n" + ex.Message);
            }
        }

        public static List<EmpleadoModel> agregarEmpleados(EmpleadoModel pempleado)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "DRAINSA.PA_MAN_TBL_GUA_EMPLEADO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (pempleado == null)
                {
                    pempleado = new EmpleadoModel();
                }

                
                cmd.Parameters.AddWithValue("@P_USUARIO", pempleado.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", pempleado.OPCION);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", pempleado.OPCION);
                cmd.Parameters.AddWithValue("@P_PK_TBL_GUA_EMPLEADO ", pempleado.PK_TBL_GUA_EMPLEADO);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACION  ", pempleado.IDENTIFICACION);
                cmd.Parameters.AddWithValue("@P_NOMBRE ", pempleado.NOMBRE);
                cmd.Parameters.AddWithValue("@P_APELLIDO1 ",pempleado.APELLIDO1);
                cmd.Parameters.AddWithValue("@P_APELLIDO2 ", pempleado.APELLIDO2);
                cmd.Parameters.AddWithValue("@P_TELEFONO ", pempleado.TELEFONO); 
                cmd.Parameters.AddWithValue("@P_CORREO ", pempleado.CORREO);
                cmd.Parameters.AddWithValue("@P_DIRECCION ", pempleado.DIRECCION);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<EmpleadoModel> lista = new List<EmpleadoModel>();

                while (reader.Read())
                {
                    EmpleadoModel obj = new EmpleadoModel();
                    obj.PK_TBL_GUA_EMPLEADO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_GUA_EMPLEADO");
                    obj.IDENTIFICACION = UtilitarioDatos.ObtieneString(reader, "IDENTIFICACION");
                    obj.NOMBRE = UtilitarioDatos.ObtieneString(reader, "NOMBRE");
                    obj.APELLIDO1 = UtilitarioDatos.ObtieneString(reader, "APELLIDO1");
                    obj.APELLIDO2 = UtilitarioDatos.ObtieneString(reader, "APELLIDO2");
                    obj.TELEFONO = UtilitarioDatos.ObtieneString(reader, "TELEFONO");
                    obj.DIRECCION = UtilitarioDatos.ObtieneString(reader, "DIRECCION");
                    obj.CORREO = UtilitarioDatos.ObtieneString(reader, "CORREO");

                    lista.Add(obj);
                }
                reader.Dispose();

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos la obtener los empleado \n" + ex.Message);
            }
        }

        public static List<EmpleadoModel> modificarEmpleados(EmpleadoModel pempleado)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "DRAINSA.PA_MAN_TBL_GUA_EMPLEADO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (pempleado == null)
                {
                    pempleado = new EmpleadoModel();
                }


                cmd.Parameters.AddWithValue("@P_USUARIO", pempleado.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", pempleado.OPCION);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACODR_EXTERNO ", pempleado.OPCION);
                cmd.Parameters.AddWithValue("@P_PK_TBL_GUA_EMPLEADO ", pempleado.PK_TBL_GUA_EMPLEADO);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACION  ", pempleado.IDENTIFICACION);
                cmd.Parameters.AddWithValue("@P_NOMBRE ", pempleado.NOMBRE);
                cmd.Parameters.AddWithValue("@P_APELLIDO1 ", pempleado.APELLIDO1);
                cmd.Parameters.AddWithValue("@P_APELLIDO2 ", pempleado.APELLIDO2);
                cmd.Parameters.AddWithValue("@P_TELEFONO ", pempleado.TELEFONO);
                cmd.Parameters.AddWithValue("@P_DIRECCION ", pempleado.DIRECCION);
                cmd.Parameters.AddWithValue("@P_CORREO ", pempleado.CORREO);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<EmpleadoModel> lista = new List<EmpleadoModel>();

                while (reader.Read())
                {
                    EmpleadoModel obj = new EmpleadoModel();
                    obj.PK_TBL_GUA_EMPLEADO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_GUA_EMPLEADO");
                    obj.IDENTIFICACION = UtilitarioDatos.ObtieneString(reader, "IDENTIFICACION");
                    obj.NOMBRE = UtilitarioDatos.ObtieneString(reader, "NOMBRE");
                    obj.APELLIDO1 = UtilitarioDatos.ObtieneString(reader, "APELLIDO1");
                    obj.APELLIDO2 = UtilitarioDatos.ObtieneString(reader, "APELLIDO2");
                    obj.TELEFONO = UtilitarioDatos.ObtieneString(reader, "TELEFONO");
                    obj.DIRECCION = UtilitarioDatos.ObtieneString(reader, "DIRECCION");
                    obj.CORREO = UtilitarioDatos.ObtieneString(reader, "CORREO");

                    lista.Add(obj);
                }
                reader.Dispose();

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos la obtener los empleado \n" + ex.Message);
            }
        }

        public static List<EmpleadoModel> eliminarEmpleados(EmpleadoModel pempleado)
        {
            Conexion con = new Conexion();
            SqlConnection myConexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                myConexion = new SqlConnection(con.conexion().ToString());
                string Sql = "DRAINSA.PA_MAN_TBL_GUA_EMPLEADO";
                cmd = new SqlCommand(Sql, myConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (pempleado == null)
                {
                    pempleado = new EmpleadoModel();
                }


                cmd.Parameters.AddWithValue("@P_USUARIO", pempleado.USUARIO);
                cmd.Parameters.AddWithValue("@P_MODO_EJECUCION", 0);
                cmd.Parameters.AddWithValue("@P_OPCION ", pempleado.OPCION);
                cmd.Parameters.AddWithValue("@P_PK_TBL_GUA_EMPLEADO ", pempleado.PK_TBL_GUA_EMPLEADO);
                cmd.Parameters.AddWithValue("@P_IDENTIFICACION  ", pempleado.IDENTIFICACION);

                myConexion.Open();
                reader = cmd.ExecuteReader();

                List<EmpleadoModel> lista = new List<EmpleadoModel>();

                while (reader.Read())
                {
                    EmpleadoModel obj = new EmpleadoModel();
                    obj.PK_TBL_GUA_EMPLEADO = UtilitarioDatos.ObtieneInt(reader, "PK_TBL_GUA_EMPLEADO");
                    obj.IDENTIFICACION = UtilitarioDatos.ObtieneString(reader, "IDENTIFICACION");
                    obj.NOMBRE = UtilitarioDatos.ObtieneString(reader, "NOMBRE");
                    obj.APELLIDO1 = UtilitarioDatos.ObtieneString(reader, "APELLIDO1");
                    obj.APELLIDO2 = UtilitarioDatos.ObtieneString(reader, "APELLIDO2");
                    obj.TELEFONO = UtilitarioDatos.ObtieneString(reader, "TELEFONO");
                    obj.DIRECCION = UtilitarioDatos.ObtieneString(reader, "DIRECCION");
                    obj.CORREO = UtilitarioDatos.ObtieneString(reader, "CORREO");

                    lista.Add(obj);
                }
                reader.Dispose();

                cmd.Dispose();
                myConexion.Close();
                myConexion.Dispose();
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error en Base de Datos la obtener los empleado \n" + ex.Message);
            }
        }
    }
}