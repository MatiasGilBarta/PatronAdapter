using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;

namespace PatronAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de motivación
            //Profesor: Gastón Weingand

            //1) Se nos solicita adaptar un auto eléctrico a un sistema de abastecimiento de combustible
            //para autos. Siendo que el auto eléctrico utiliza como combustible energía eléctrica, y los
            //demás vehículos(Nafta, diésel y gas) utilizan combustibles derivados del petróleo.
            //Para ello generamos una clase abstracta llamada Vehículo que representará de forma
            //genérica un Auto: Esta interfaz contendrá dos métodos: CargarTanque() y Arrancar().
            //Al momento de implementar las clases nos damos cuenta de que el auto eléctrico
            //no coincide con la jerarquía propuesta.


            //a) ¿Qué patrón aplicaría para satisfacer el requerimiento sabiendo que la clase
            //AutoElectrico contiene el método ConectarCorriente() en lugar de CargarTanque()?

            //b) Modele el diagrama de clases.

            //c) Realice en código su solución propuesta. No hace falta realizar persistencia.

            //d) Ejecute algunos casos de prueba para testear su solución.

            AutoCombustible ac1 = new AutoCombustible();
            ac1.Marca = "Audi";
            ac1.Modelo = "A5";
            ac1.Color = "Gris";
            ac1.Encendido = false;
            ac1.TanqueCombustible = 0;

            AutoCombustibleService serviceCombustible = new AutoCombustibleService();
            serviceCombustible.Add(ac1);
            serviceCombustible.Arrancar(ac1);
            serviceCombustible.CargarTanque(ac1, 20);

            Console.WriteLine($"Datos: {ac1.Marca}, {ac1.Modelo}, {ac1.Color}, Encendido: {ac1.Encendido}, {ac1.TanqueCombustible} Litros");

            AutoElectrico ae1 = new AutoElectrico();
            ae1.Marca = "Alpine";
            ae1.Modelo = "Ni Arranca";
            ae1.Color = "Rosa";
            ae1.Encendido = false;
            ae1.Bateria = 0;

            AutoElectricoService serviceElectrico = new AutoElectricoService();
            serviceElectrico.Add(ae1);
            //serviceElectrico.Arrancar(ae1);
            serviceElectrico.ConectarCorriente(ae1, -20);
            serviceElectrico.ConectarCorriente(ae1, 10);

            Console.WriteLine($"Datos: {ae1.Marca}, {ae1.Modelo}, {ae1.Color}, Encendido: {ae1.Encendido}, {ae1.Bateria} Wats");            
            Console.ReadLine();
        }
    }
}
