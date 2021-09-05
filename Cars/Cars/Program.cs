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
            Car carNew = new Car("Ford", "K21", 4, "ROJO",kind.Manual); 
            Console.WriteLine(carNew.printear());
            bd.Create(carNew);
            
            /*
            Console.WriteLine("\nGET ID = 0");
            Car carGet = bd.get(2); // Verificar que exista TODO : atraparlo con un exepcion
            Console.WriteLine(carGet.printear());
            
            Console.WriteLine("\nUPDAPTEAR el carro con id = 1");
            Car carUpdate = new Car("Chevrolet", "U90", 2, "AZUL",kind.LU);
            carUpdate.id = 1;
            bd.Update(carUpdate);
            
            Console.WriteLine("\nDELETEAR el carro con id = 0"); // Verificar que exista TODO : atraparlo con un exepcion
            bd.Delete(4);*/
        }
    }
    
    
}
