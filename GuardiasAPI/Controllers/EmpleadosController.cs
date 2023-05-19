using GuardiasAPI.Datos;
using GuardiasAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace GuardiasAPI.Controllers
{
    public class EmpleadoController : ApiController
    {

        [HttpPost]
        [Route("api/empleados/obtener")]
        public HttpResponseMessage obtenerEmpleados([FromBody] EmpleadoModel empleado)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            try
            {
                response.Content = new StringContent(JsonConvert.SerializeObject(EmpleadoDatos.obtenerEmpleados(empleado)), Encoding.UTF8, "application/json");
            }
            catch (Exception e)
            {
                response = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);

            }
            return response;
        }

        [HttpPost]
        [Route("api/empleados/agregar")]
        public HttpResponseMessage agregarEmpleados([FromBody] EmpleadoModel empleado)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            try
            {
                response.Content = new StringContent(JsonConvert.SerializeObject(EmpleadoDatos.agregarEmpleados(empleado)), Encoding.UTF8, "application/json");
            }
            catch (Exception e)
            {
                response = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);

            }
            return response;
        }

        [HttpPut]
        [Route("api/empleados/modificar")]
        public HttpResponseMessage modificarEmpleados([FromBody] EmpleadoModel empleado)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            try
            {
                response.Content = new StringContent(JsonConvert.SerializeObject(EmpleadoDatos.modificarEmpleados(empleado)), Encoding.UTF8, "application/json");
            }
            catch (Exception e)
            {
                response = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);

            }
            return response;
        }

        [HttpDelete]
        [Route("api/empleados/eliminar")]
        public HttpResponseMessage eliminarEmpleados([FromBody] EmpleadoModel empleado)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            try
            {
                response.Content = new StringContent(JsonConvert.SerializeObject(EmpleadoDatos.eliminarEmpleados(empleado)), Encoding.UTF8, "application/json");
            }
            catch (Exception e)
            {
                response = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);

            }
            return response;
        }
    }
}