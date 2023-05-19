using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace GuardiasAPI.Datos
{
    public class Conexion
    {


        public static ArrayList CargarPreferencias()
        {
            ArrayList datos = new ArrayList();
            string direccion = ConfigurationManager.AppSettings["Ruta_conexion"];
            try
            {
                if (File.Exists(direccion))
                {
                    XmlDocument Conexiones = new XmlDocument();

                    Conexiones.Load(direccion);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/SERVER").InnerText);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/DATABASE").InnerText);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/USER").InnerText);
                    datos.Add(Conexiones.SelectSingleNode("/CONEXION/PASSWORD").InnerText);
                }
                else
                {

                }
            }
            catch
            {

            }
            return datos;
        }

        public string conexion()
        {
            ArrayList Conexion = new ArrayList();
            Console.WriteLine(CargarPreferencias().ToString());
            Conexion = CargarPreferencias();

            return "Data Source=" + "guardias.database.windows.net,1433" +
            ";Initial Catalog=" + "BD_GUARDIAS" +
            ";User ID=" + "as" +
            ";Password=" + "M13954#L";
        }





    }
}