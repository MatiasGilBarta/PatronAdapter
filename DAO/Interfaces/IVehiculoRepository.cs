using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public abstract class IVehiculoRepository<T> where T : class
    {
        public abstract void Add(T entity);

        //public abstract void Update(T entity);

        //public abstract void Delete(int id);

        //public abstract T GetById(int id);

        //public abstract IEnumerable<T> GetAll();

        public abstract void CargarTanque(T entity, int algo);
        public abstract void Arrancar(T entity);

    }
}
