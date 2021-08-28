using System;
using System.IO;

namespace Cars
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var CurrentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(CurrentDirectory);

            Car carrito = new Car("Volvo", "F99", 4, "ROJO", true);
            Console.WriteLine("Carrito = " + carrito.Marca + " " + carrito.Modelo);
            Console.WriteLine("Persistiendo en el JSON");
            
            CarCRUD bd = new CarCRUD();
            Car carritob = bd.Create(carrito);


        }
    }

    class Car
    {
        // Valores de persistencia que me los dara la BD
        public int id { get; set; }
        public DateTime fecha_creacion { get; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cant_puertas { get; set; }
        public string Color { get; set; }
        public bool Es_manual;

        public Car(string marca, string modelo, int cant_puertas, string color, bool es_manual)
        {
            Marca = marca;
            Modelo = modelo;
            Cant_puertas = cant_puertas;
            Color = color;
            Es_manual = es_manual;
        }
    }
}
