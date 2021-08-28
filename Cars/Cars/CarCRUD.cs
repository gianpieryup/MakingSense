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
        public void Create(Car car)
        {
            string jsonString = File.ReadAllText(filename);
            List<Car> listaCars = JsonSerializer.Deserialize<List<Car>>(jsonString);

            car.id = listaCars[listaCars.Count - 1].id + 1; // id ultimo + 1
            listaCars.Add(car);

            var options = new JsonSerializerOptions { WriteIndented = true };// Opcion con IDENTACION
            string CarsSerializado = JsonSerializer.Serialize(listaCars, options);
            File.WriteAllText(filename, CarsSerializado);

            // Asignacion de campos de la BD : ID, Fecha_creacion ,etc Pero eso persistido
        }

        public Car get(int id)
        {
            string jsonstring = File.ReadAllText(filename);
            List<Car> listacars = JsonSerializer.Deserialize<List<Car>>(jsonstring);
            
            foreach (var c in listacars)
            {
                if (c.id == id)
                    return c;
            }

            return null;
        }

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


