using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ProveedorHelper
    {
        ServiceRepository repository;

        public ProveedorHelper()
        {
            repository = new ServiceRepository();
        }

        #region  GetALL
        public List<ProveedorViewModel> GetAll()
        {
            List<ProveedorViewModel> lista = new List<ProveedorViewModel>();
            HttpResponseMessage responseMessage = repository.GetResponse("api/Proveedor/");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ProveedorViewModel>>(content);
            }
            return lista;
        }
        #endregion

        #region GetByID
        public ProveedorViewModel GetByID(int id)
        {
            ProveedorViewModel proveedor = new ProveedorViewModel();

            HttpResponseMessage responseMessage = repository.GetResponse("api/proveedor/" + id);
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            proveedor = JsonConvert.DeserializeObject<ProveedorViewModel>(content);
            return proveedor;
        }
        #endregion

        #region Update
        public ProveedorViewModel Edit(ProveedorViewModel proveedor)
        {
            HttpResponseMessage responseMessage = repository.PutResponse("api/proveedor/", proveedor);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ProveedorViewModel proveedorAPI = JsonConvert.DeserializeObject<ProveedorViewModel>(content);
            return proveedorAPI;
        }
        #endregion

        #region Create
        public ProveedorViewModel Add(ProveedorViewModel proveedor)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/proveedor/", proveedor);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ProveedorViewModel proveedorAPI = JsonConvert.DeserializeObject<ProveedorViewModel>(content);
            return proveedorAPI;
        }
        #endregion


        #region GetByID
        public ProveedorViewModel Delete(int id)
        {
            ProveedorViewModel proveedor = new ProveedorViewModel();

            HttpResponseMessage responseMessage = repository.DeleteResponse("api/proveedor/" + id);
            return proveedor;
        }
        #endregion
    }
}