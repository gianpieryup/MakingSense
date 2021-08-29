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

            Car carrito = new Car("Ford", "K21", 4, "ROJO");
            //Console.WriteLine(carrito.printear())
            Console.WriteLine("Carrito = " + carrito.Marca + " " + carrito.Modelo + " " + carrito.Color);
            Console.WriteLine("Persistiendo en el JSON");
            
            CarCRUD bd = new CarCRUD();
            bd.Create(carrito);

            Console.WriteLine("GET ID=1");
            Car carget = bd.get(1);
            Console.WriteLine("Carrito = " + carget.Marca + " " + carget.Modelo + " " + carget.Color);
        }
    }

    class Car
    {
        // Valores de persistencia que me los dara la BD
        public int id { get; set; }
        public DateTime fecha_creacion { get; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Puertas { get; set; }
        public string Color { get; set; }
        //public bool Es_manual;

        public Car(string marca, string modelo, int puertas, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Puertas = puertas;
            Color = color;
            // [TODO] Cuando tienes que decidir guardar cual es la mejor opcion en un caso bool
            // Obviamente la BD no te guarda un "true" o un "False" podria mandar 0 - 1 como int
            //Es_manual = es_manual;
        }

        public string printear(){
            string name = string.Format("Carro: {0} {1} {2}",self.Marca,self.Modelo,self.Color);
            return name;
        }
    }
}
