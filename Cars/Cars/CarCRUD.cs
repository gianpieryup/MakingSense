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

        string filename = @"../../../Cars.json";
        public List<Car> LeerListaCars()
        {        
            string jsonString = File.ReadAllText(filename);
            List<Car> listaCars = JsonSerializer.Deserialize<List<Car>>(jsonString);
            return listaCars;
        }

        public void ActualizarJSON(List<Car> cars)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };// Opcion con IDENTACION
            string CarsSerializado = JsonSerializer.Serialize(cars, options);
            File.WriteAllText(filename, CarsSerializado);
        }

        public int IndicePorID(int id)
        {
            List<Car> listaCars = LeerListaCars();
            int i;
            for (i = 0; i < listaCars.Count; i++)
            {
                if (listaCars[i].id == id)
                    break;
            }
            return i;
        }

        public void Create(Car car)
        {
            List<Car> listaCars = LeerListaCars();

            // Asignacion de campos de la BD : ID, Fecha_creacion ,etc| SOL Momentania
            if (listaCars.Count >= 1)  // NO vacia
                car.id = listaCars[listaCars.Count - 1].id + 1; // id ultimo + 1
            else
                car.id = 0;
            
            listaCars.Add(car);
            ActualizarJSON(listaCars);
        }

        public Car get(int id)
        {
            List<Car> listaCars = LeerListaCars();
            foreach (var c in listaCars)
            {
                if (c.id == id)
                    return c;
            }

            return null;
        }

        public void Update(Car car)
        {
            List<Car> listaCars = LeerListaCars();
            int indice = IndicePorID(car.id);

            Car antiguo = listaCars[indice];
            antiguo.Marca = car.Marca;
            antiguo.Modelo = car.Modelo;
            antiguo.Puertas = car.Puertas;
            antiguo.Color = car.Color;

            ActualizarJSON(listaCars);
        }

        public void Delete(int id)
        {
            List<Car> listaCars = LeerListaCars();
            int indice = IndicePorID(id);
            listaCars.RemoveAt(indice);
            ActualizarJSON(listaCars);
        }

    }
}


