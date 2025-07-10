using DAO.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.Memory
{
    public class AutoCombustibleRepository : IVehiculoRepository<AutoCombustible>
    {
        List<AutoCombustible> _list = new List<AutoCombustible>();

        public AutoCombustibleRepository()
        {

        }

        public override void Add(AutoCombustible entity)
        {
            foreach (AutoCombustible autoCombustible in _list)
            {
                if (autoCombustible.IdAuto == entity.IdAuto)
                { return; }
            }
            int IdAuto = _list.Count + 1;
            _list.Add(entity);
        }

        public override void Arrancar(AutoCombustible autoCombustible)
        {
            autoCombustible.Encendido = true;
        }

        public override void CargarTanque(AutoCombustible autoCombustible, int cantidadCombustible)
        {
            autoCombustible.TanqueCombustible = cantidadCombustible;
        }
    }
}
