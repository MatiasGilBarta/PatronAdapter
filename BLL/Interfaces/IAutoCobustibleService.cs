using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAutoCobustibleService<T> where T : class
    {
        void Add(T entity);

        void CargarTanque(T entity, int algo);

        void Arrancar(T entity);
    }
}
