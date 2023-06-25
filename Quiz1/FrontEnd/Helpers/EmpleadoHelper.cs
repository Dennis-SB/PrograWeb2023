using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class EmpleadoHelper
    {
        ServiceRepository repository;

        public EmpleadoHelper()
        {
            repository = new ServiceRepository();
        }

        #region  GetALL
        public List<EmpleadoViewModel> GetAll()
        {
            List<EmpleadoViewModel> lista = new List<EmpleadoViewModel>();
            HttpResponseMessage responseMessage = repository.GetResponse("api/Empleado/");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(content);
            }
            return lista;
        }
        #endregion

        #region GetByID
        /// <summary>
        /// Obtener Categoria por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EmpleadoViewModel GetByID(int id)
        {
            EmpleadoViewModel category = new EmpleadoViewModel();
            HttpResponseMessage responseMessage = repository.GetResponse("api/empleado/" + id);
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            category = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);
            return category;
        }
        #endregion

        #region Update
        public EmpleadoViewModel Edit(EmpleadoViewModel category)
        {
            HttpResponseMessage responseMessage = repository.PutResponse("api/empleado/", category);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EmpleadoViewModel categoryAPI = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);
            return categoryAPI;
        }
        #endregion

        #region Create
        public EmpleadoViewModel Add(EmpleadoViewModel category)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/empleado/", category);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EmpleadoViewModel categoryAPI = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);
            return categoryAPI;
        }
        #endregion

        #region Delete
        /// <summary>
        /// Obtener Categoria por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EmpleadoViewModel Delete(int id)
        {
            EmpleadoViewModel category = new EmpleadoViewModel();
            HttpResponseMessage responseMessage = repository.DeleteResponse("api/empleado/" + id);
            // string content = responseMessage.Content.ReadAsStringAsync().Result;
            // category = JsonConvert.DeserializeObject<CategoryViewModel>(content);
            return category;
        }
        #endregion
    }
}