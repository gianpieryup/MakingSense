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
            CarCRUD bd = new CarCRUD();

            Console.WriteLine("\nAGREGANDO nuevo carro");
            Car carNew = new Car("Ford", "K21", 4, "ROJO");
            Console.WriteLine(carNew.printear());
            bd.Create(carNew);

            Console.WriteLine("\nGET ID = 0");
            Car carGet = bd.get(0);
            Console.WriteLine(carGet.printear());

            Console.WriteLine("\nUPDAPTEAR el carro con id = 1");
            Car carUpdate = new Car("Chevrolet", "U90", 2, "AZUL");
            carUpdate.id = 1;
            bd.Update(carUpdate);

            Console.WriteLine("\nDELETEAR el carro con id = 0");
            bd.Delete(0);
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
            string name = string.Format("Carro: {0} {1} {2}", Marca, Modelo, Color);
            return name;
        }
    }
}
