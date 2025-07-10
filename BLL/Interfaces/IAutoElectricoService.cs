using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAutoElectricoService<T> where T : class
    {
        void Add(T entity);

        void ConectarCorriente(T entity, int algo);

        void Arrancar(T entity);
    }
}
