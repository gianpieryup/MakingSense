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

            if (listaCars)  // NO vacia
                car.id = listaCars[listaCars.Count - 1].id + 1; // id ultimo + 1
            else    // []
                car.id = 0;
            
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

        public Car Update(Car car)
        {
            string jsonstring = File.ReadAllText(filename);// ISSUE : dejar arriba
            List<Car> listacars = JsonSerializer.Deserialize<List<Car>>(jsonstring);

            Car antiguo = self.get(car.id);// NONO 4,8,9
            antiguo.Marca = car.Marca;
            antiguo.Modelo = car.Modelo;
            antiguo.Puertas = car.Puertas;
            antiguo.Color = car.Color;

            var options = new JsonSerializerOptions { WriteIndented = true };// Opcion con IDENTACION
            string CarsSerializado = JsonSerializer.Serialize(listaCars, options);
            File.WriteAllText(filename, CarsSerializado);
        }

        public void Delete(int id)
        {
            string jsonstring = File.ReadAllText(filename);// ISSUE : dejar arriba
            List<Car> listacars = JsonSerializer.Deserialize<List<Car>>(jsonstring);

            int i;
            for(i=0; i < listacars.Count;i++){
                if (listacars[i].id == id)
                    break;
            }
            Console.WriteLine("Valor del indice"+i);
            //listacars.RemoveAt(i); // ese i es la pos en la lista

        }
    }
}


