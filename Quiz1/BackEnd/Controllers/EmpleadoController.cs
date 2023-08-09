using BackEnd.Models;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private IEmpleadoDAL empleadoDAL;
        private EmpleadoModel Convertir(Empleado empleado)
        {
            return new EmpleadoModel
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Salario = empleado.Salario
            };
        }

        private Empleado Convertir(EmpleadoModel empleado)
        {
            return new Empleado
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Salario = empleado.Salario
            };
        }

        #region Constructores
        public CategoryController()
        {
            empleadoDAL = new EmpleadoDALImpl();
        }
        #endregion

        #region Consultas
        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Empleado> categories = empleadoDAL.GetAll();
            List<EmpleadoModel> models = new List<EmpleadoModel>();
            foreach (var category in categories)
            {
                models.Add(Convertir(category));
            }
            return new JsonResult(models);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Empleado category = empleadoDAL.Get(id);
            return new JsonResult(Convertir(category));
        }
        #endregion

        #region Agregar
        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] EmpleadoModel category)
        {
            empleadoDAL.Add(Convertir(category));
            return new JsonResult(category);
        }
        #endregion

        #region Modificar
        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] EmpleadoModel category)
        {
            empleadoDAL.Update(Convertir(category));
            return new JsonResult(category);
        }
        #endregion

        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Empleado empleado = new Empleado
            {
                EmpleadoId = id
            };
            empleadoDAL.Remove(empleado);
        }
        #endregion
    }
}