using System;
using System.IO;

namespace Cars
{
    class Configuraciones
    {
        public string path { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(CurrentDirectory);
            CarCRUD bd = new CarCRUD();

            bd.getAllPrint();

            Console.WriteLine("\nAGREGANDO nuevo carro");
            Car car1 = new Car("Chevrolet", "K21 X20", 4, "Rojo",kind.Manual);
            Car car2 = new Car("Volkswagen", "Z34-22", 2, "Azul", kind.Automatico);
            bd.Create(car1);
            //bd.Create(car2);

           
            Console.WriteLine("\nGET Id = 2");
            Car carGet = bd.get(2); // Verificar que exista TODO : atraparlo con un exepcion
            Console.WriteLine(carGet.printear());
            
            Console.WriteLine("\nUPDAPTEAR el carro con id = 1");
            Car carUpdate = new Car("Chevrolet", "U90", 2, "AZUL",kind.Automatico);
            carUpdate.id = 1;
            bd.Update(carUpdate);
            /*
            Console.WriteLine("\nDELETEAR el carro con id = 0"); // Verificar que exista TODO : atraparlo con un exepcion
            bd.Delete(2);*/
        }
    }
    
    
}
