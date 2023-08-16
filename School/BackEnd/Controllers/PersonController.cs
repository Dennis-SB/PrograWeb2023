using BackEnd.Models;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private IPersonDAL personDAL;

        private PersonModel Convertir(Person person)
        {
            return new PersonModel
            {
                PersonId = person.PersonId,
                LastName = person.LastName,
                FirstName = person.FirstName,
                HireDate = person.HireDate,
                EnrollmentDate = person.EnrollmentDate,
                Discriminator = person.Discriminator
            };
        }
        
        private Person Convertir(PersonModel person)
        {
            return new Person
            {
                PersonId = person.PersonId,
                LastName = person.LastName,
                FirstName = person.FirstName,
                HireDate = person.HireDate,
                EnrollmentDate = person.EnrollmentDate,
                Discriminator = person.Discriminator
            };
        }

        #region Constructores

        public PersonController()
        {
            personDAL = new PersonDALImpl();
        }

        #endregion


        #region Consultas

        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Person> persons = personDAL.GetAll();
            List<PersonModel> models = new List<PersonModel>();

            foreach (var person in persons)
            {

                models.Add(Convertir(person));

            }

            return new JsonResult(models);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Person person = personDAL.Get(id);
            return new JsonResult(Convertir(person));
        }
        #endregion

        #region Agregar


        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] PersonModel person)
        {

            personDAL.Add(Convertir(person));
            return new JsonResult(person);
        }

        #endregion

        #region Modificar


        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] PersonModel person)
        {
            personDAL.Update(Convertir(person));
            return new JsonResult(person);
        }
        #endregion


        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Person person = new Person
            {
                PersonId = id
            };

            personDAL.Remove(person);

        }
        #endregion
    }
}
