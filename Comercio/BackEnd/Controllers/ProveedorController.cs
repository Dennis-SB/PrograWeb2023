using BackEnd.Models;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {

        private IProveedorDAL proveedorDAL;

        private ProveedorModel Convertir(Proveedore proveedor)
        {
            return new ProveedorModel
            {
                CodProveedor = proveedor.CodProveedor,
                NombreProveedor = proveedor.NombreProveedor,
                Telefono = proveedor.Telefono,
                Direccion = proveedor.Direccion,
                CodigoArchivo = proveedor.CodigoArchivo
            };
        }

        private Proveedore Convertir(ProveedorModel proveedor)
        {
            return new Proveedore
            {
                CodProveedor = proveedor.CodProveedor,
                NombreProveedor = proveedor.NombreProveedor,
                Telefono = proveedor.Telefono,
                Direccion = proveedor.Direccion,
                CodigoArchivo = proveedor.CodigoArchivo
            };
        }

        #region Constructores
        public ProveedorController()
        {
            proveedorDAL = new ProveedorDALImpl();
        }
        #endregion

        #region Consultas
        // GET: api/<ProveedorController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Proveedore> proveedores = proveedorDAL.GetAll();
            List<ProveedorModel> models = new List<ProveedorModel>();
            foreach (var proveedor in proveedores)
            {
                models.Add(Convertir(proveedor));
            }
            return new JsonResult(models);
        }

        // GET api/<ProveedorController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Proveedore proveedor = proveedorDAL.Get(id);
            return new JsonResult(Convertir(proveedor));
        }
        #endregion

        #region Agregar
        // POST api/<ProveedorController>
        [HttpPost]
        public JsonResult Post([FromBody] ProveedorModel proveedor)
        {
            proveedorDAL.Add(Convertir(proveedor));
            return new JsonResult(proveedor);
        }
        #endregion

        #region Modificar
        // PUT api/<ProveedorController>/5
        [HttpPut]
        public JsonResult Put([FromBody] ProveedorModel proveedor)
        {
            proveedorDAL.Update(Convertir(proveedor));
            return new JsonResult(proveedor);
        }
        #endregion

        #region Eliminar
        // DELETE api/<ProveedorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Proveedore proveedor = new Proveedore
            {
                CodProveedor = id
            };
            proveedorDAL.Remove(proveedor);
        }
        #endregion
    }
}