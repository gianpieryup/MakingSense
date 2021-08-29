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
            Car carNew = new Car("Ford", "K21", 4, "ROJO",0); 
            Console.WriteLine(carNew.printear());
            bd.Create(carNew);
            
            Console.WriteLine("\nGET ID = 0");
            Car carGet = bd.get(2); // Verificar que exista TODO : atraparlo con un exepcion
            Console.WriteLine(carGet.printear());
            
            Console.WriteLine("\nUPDAPTEAR el carro con id = 1");
            Car carUpdate = new Car("Chevrolet", "U90", 2, "AZUL",1);
            carUpdate.id = 1;
            bd.Update(carUpdate);
            /*
            Console.WriteLine("\nDELETEAR el carro con id = 0"); // Verificar que exista TODO : atraparlo con un exepcion
            bd.Delete(4);*/
        }
    }

    class Car
    {
        // Valores de persistencia que me los dara la BD
        public int id { get; set; }
        public string fecha_creacion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Puertas { get; set; }
        public string Color { get; set; }
        public int Manual { get; set; } // 1 = Manual | 0 = Automatico

        public Car(string marca, string modelo, int puertas, string color, int manual)
        {
            Marca = marca;
            Modelo = modelo;
            Puertas = puertas;
            Color = color;
            // [TODO] Cuando tienes que decidir guardar cual es la mejor opcion en un caso bool
            // Obviamente la BD no te guarda un "true" o un "False" podria mandar 0 - 1 como int
            Manual = manual;
        }

        public string printear(){
            string name = string.Format("Carro: {0} {1} {2}", Marca, Modelo, Color);
            return name;
        }
    }
}
