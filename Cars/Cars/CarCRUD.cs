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
        public string carsJson = @"../../../Cars.json";
        public Car Create(Car car)
        {
            string jsonString = JsonSerializer.Serialize(car);
            Console.WriteLine(jsonString);
            File.WriteAllText(carsJson, jsonString); // Escriba al final no TOdo
            car.id = 1;
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


