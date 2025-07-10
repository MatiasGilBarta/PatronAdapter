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
    public class AutoElectricoService : IAutoElectricoService<AutoElectrico>
    {
        private readonly AutoElectricoRepository autoElectricoRepository;

        public AutoElectricoService() 
        {
            autoElectricoRepository = new AutoElectricoRepository();
        }

        public void Add(AutoElectrico autoElectrico)
        {
            autoElectricoRepository.Add(autoElectrico);
        }

        public void Arrancar(AutoElectrico autoElectrico)
        {
            autoElectricoRepository.Arrancar(autoElectrico);
        }

        public void ConectarCorriente(AutoElectrico autoElectrico, int cantidadBateria)
        {
            if (cantidadBateria >= 1)
            { autoElectricoRepository.ConectarCorriente(autoElectrico, cantidadBateria); }
            else
            { Console.WriteLine("La cantidad cargada de bateria es invalida"); }
        }
    }
}
