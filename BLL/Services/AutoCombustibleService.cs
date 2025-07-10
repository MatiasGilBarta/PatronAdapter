using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAO.Implementations.Memory;
using DAO.Interfaces;
using Domain;

namespace BLL.Services
{
    public class AutoCombustibleService : IAutoCobustibleService<AutoCombustible>
    {
        private readonly AutoCombustibleRepository autoCombustibleRepository;

        public AutoCombustibleService()
        {
            autoCombustibleRepository = new AutoCombustibleRepository();
        }

        public void Add(AutoCombustible autoElectrico)
        {
            autoCombustibleRepository.Add(autoElectrico);
        }

        public void Arrancar(AutoCombustible autoElectrico)
        {
            autoCombustibleRepository.Arrancar(autoElectrico);
        }

        public void CargarTanque(AutoCombustible autoElectrico, int cantidadCombustible)
        {
            if (cantidadCombustible >= 1)
            { autoCombustibleRepository.CargarTanque(autoElectrico, cantidadCombustible);  }
            else
            { Console.WriteLine("La cantidad cargada de combustible es invalida"); }
        }
    }
}
