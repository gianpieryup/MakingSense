using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum kind { Manual, Automatico };

    class Car
    {
        // Valores de persistencia que me los dara la BD
        public int id { get; set; }
        public string fecha_creacion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Puertas { get; set; }
        public string Color { get; set; }
        public kind KindCar { get; set; }

        public Car(string marca, string modelo, int puertas, string color, kind kindCar)
        {
            Marca = marca;
            Modelo = modelo;
            Puertas = puertas;
            Color = color;
            KindCar = kindCar;
        }

        public string printear()
        {
            string name = string.Format("{0,-3} | {1,-11} | {2,-8} | {3,-8}",id, Marca, Modelo, Color);
            return name;
        }

    }
}
