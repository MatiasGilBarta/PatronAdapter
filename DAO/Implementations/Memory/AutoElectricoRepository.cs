using DAO.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.Memory
{
    public class AutoElectricoRepository
    {
        List<AutoElectrico> _list = new List<AutoElectrico>();

        public AutoElectricoRepository() 
        {
            
        }

        public void Add(AutoElectrico entity) 
        {
            foreach (AutoElectrico autoElectrico in _list)
            {
                if(autoElectrico.IdAuto == entity.IdAuto)
                { return; }
            }
            int IdUsuario = _list.Count + 1;
            _list.Add(entity);
        }

        public void Arrancar(AutoElectrico autoElectrico)
        {
            autoElectrico.Encendido = true; 
        }

        public void ConectarCorriente(AutoElectrico autoElectrico, int cantidadBateria) //este es el que no se llama igual a CargarTanque
        {
            autoElectrico.Bateria = cantidadBateria;
        }
    }
}
