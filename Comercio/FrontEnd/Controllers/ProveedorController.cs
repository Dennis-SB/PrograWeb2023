using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ProveedorController : Controller
    {
        ProveedorHelper proveedorHelper;

        // GET: ProveedorController
        public ActionResult Index()
        {
            proveedorHelper = new ProveedorHelper();
            List<ProveedorViewModel> list = proveedorHelper.GetAll();

            return View(list);
        }

        // GET: ProveedorController/Details/5
        public ActionResult Details(int id)
        {
            proveedorHelper = new ProveedorHelper();
            ProveedorViewModel proveedor = proveedorHelper.GetByID(id);
            return View(proveedor);
        }

        // GET: ProveedorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProveedorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProveedorViewModel proveedor)
        {
            try
            {
                proveedorHelper = new ProveedorHelper();
                proveedor = proveedorHelper.Add(proveedor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProveedorController/Edit/5
        public ActionResult Edit(int id)
        {
            proveedorHelper = new ProveedorHelper();
            ProveedorViewModel proveedor = proveedorHelper.GetByID(id);
            return View(proveedor);
        }

        // POST: ProveedorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProveedorViewModel proveedor)
        {
            try
            {
                proveedorHelper = new ProveedorHelper();
                proveedor = proveedorHelper.Edit(proveedor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProveedorController/Delete/5
        public ActionResult Delete(int id)
        {
            proveedorHelper = new ProveedorHelper();
            ProveedorViewModel proveedor = proveedorHelper.GetByID(id);
            return View(proveedor);
        }

        // POST: ProveedorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProveedorViewModel proveedor)
        {
            try
            {
                proveedorHelper = new ProveedorHelper();
                proveedorHelper.Delete(proveedor.CodProveedor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}