using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuardiasAPI.Models
{
    public class EmpleadoModel : BaseModel
    {
        public int PK_TBL_GUA_EMPLEADO { set; get; }
        public string NOMBRE { set; get; }
        public string APELLIDO1 { set; get; }
        public string APELLIDO2 { set; get; }
        public string IDENTIFICACION { set; get; }
        public string TELEFONO { set; get; }
        public string DIRECCION { set; get; }
        public string CORREO { set; get; }
    }
}