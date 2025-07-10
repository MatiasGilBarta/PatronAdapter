using DAO.Implementations.Memory;
using DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Security.Cryptography.X509Certificates;

namespace DAO.Implementations.Interfaces
{
    public abstract class AdapterElectrico : IVehiculoRepository<AutoElectrico>
    {
        AutoElectricoRepository autoElectricoRepository = new AutoElectricoRepository();

        public override void Add(AutoElectrico entity)
        {
            autoElectricoRepository.Add(entity);
        }

        public override void Arrancar(AutoElectrico entity)
        { 
            autoElectricoRepository.Arrancar(entity);
        }

        public override void CargarTanque(AutoElectrico entity, int algo)
        {
            autoElectricoRepository.ConectarCorriente(entity, algo);
        }
    }
}
