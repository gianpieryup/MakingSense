using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cars
{
    class CarCRUD
    {
        // Empienza -> C:\Users\User\Desktop\MakingSense\Cars\Cars\bin\Debug\net5.0
        public string filename = @"../../../Cars.json";
        public Car Create(Car car)
        {
            string jsonString = File.ReadAllText(filename);
            List<Car> listaCars = JsonSerializer.Deserialize<List<Car>>(jsonString);
            Console.WriteLine("LISTA ACTUAL");
            foreach (var c in listaCars)
            {
                Console.WriteLine("Elem" + c.Marca);
            }

            Console.WriteLine("AGREGANDO ...");
            listaCars.Add(car);

            string CarsSerializado = JsonSerializer.Serialize(listaCars);
            File.WriteAllText(filename, CarsSerializado); // Escriba al final no TOdo

            // Asignacion de campos de la BD : ID, Fecha_creacion ,etc
            return car;
        }

        //public Car Get(int id)
        //{
        //    // Code here
        //}

        //public Car Update(Car car)
        //{
        //    // Code here
        //}
        public void Delete(int id)
        {
            // Code here
        }
    }
}


