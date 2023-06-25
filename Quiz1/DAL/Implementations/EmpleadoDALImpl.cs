using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EmpleadoDALImpl : IEmpleadoDAL
    {
        private QuizContext _quizContext;
        private UnidadDeTrabajo<Empleado> unidad;

        public bool Add(Empleado entity)
        {
            try
            {
                using (unidad = new UnidadDeTrabajo<Empleado>(new QuizContext()))
                {
                    unidad.genericDAL.Add(entity);
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AddRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> Find(Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Empleado Get(int id)
        {
            Empleado empleado = null;
            using (unidad = new UnidadDeTrabajo<Empleado>(new QuizContext()))
            {
                empleado = unidad.genericDAL.Get(id);
            }
            return empleado;
        }

        public IEnumerable<Empleado> GetAll()
        {
            IEnumerable<Empleado> empleado = null;
            using (unidad = new UnidadDeTrabajo<Empleado>(new QuizContext()))
            {
                empleado = unidad.genericDAL.GetAll();
            }
            return empleado;
        }

        public bool Remove(Empleado entity)
        {
            try
            {
                using (unidad = new UnidadDeTrabajo<Empleado>(new QuizContext()))
                {
                    unidad.genericDAL.Remove(entity);
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void RemoveRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        public Empleado SingleOrDefault(Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entity)
        {
            try
            {
                using (unidad = new UnidadDeTrabajo<Empleado>(new QuizContext()))
                {
                    unidad.genericDAL.Update(entity);
                    unidad.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}