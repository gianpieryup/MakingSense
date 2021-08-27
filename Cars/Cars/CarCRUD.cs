using System;
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
        public Car Create(Car car)
        {
            string jsonString = JsonSerializer.Serialize(car);
            Console.WriteLine(jsonString);
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


