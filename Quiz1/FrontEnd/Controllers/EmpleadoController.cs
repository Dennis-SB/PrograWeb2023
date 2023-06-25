using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoHelper empleadoHelper;

        // GET: CategoryController
        public ActionResult Index()
        {
            empleadoHelper = new EmpleadoHelper();
            List<EmpleadoViewModel> list = empleadoHelper.GetAll();
            return View(list);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            empleadoHelper = new EmpleadoHelper();
            EmpleadoViewModel empleado = empleadoHelper.GetByID(id);
            return View(empleado);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoViewModel empleado)
        {
            try
            {
                empleadoHelper = new EmpleadoHelper();
                empleado = empleadoHelper.Add(empleado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            empleadoHelper = new EmpleadoHelper();
            EmpleadoViewModel empleado = empleadoHelper.GetByID(id);
            return View(empleado);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoViewModel empleado)
        {
            try
            {
                empleadoHelper = new EmpleadoHelper();
                empleado = empleadoHelper.Edit(empleado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            empleadoHelper = new EmpleadoHelper();
            EmpleadoViewModel empleado = empleadoHelper.GetByID(id);
            return View(empleado);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmpleadoViewModel empleado)
        {
            try
            {
                empleadoHelper = new EmpleadoHelper();
                empleadoHelper.Delete(empleado.EmpleadoId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}