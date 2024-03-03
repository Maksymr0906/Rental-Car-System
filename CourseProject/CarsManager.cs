using System;
using System.Collections.Generic;
using System.IO;

namespace CourseProject
{
    public static class CarsManager
    {
        private static readonly string CARS_FILENAME;
        public static List<Car> Cars { get; set; }

        static CarsManager()
        {
            CARS_FILENAME = "cars.txt";

            if (!File.Exists(CARS_FILENAME))
            {
                File.Create(CARS_FILENAME).Close();
            }

            ReadCarsFromFile();
        }

        private static void ReadCarsFromFile()
        {
            Cars = new List<Car>();

            string[] lines = File.ReadAllLines(CARS_FILENAME);

            foreach (var line in lines)
            {
                var car = new Car();
                car.ReadFromFile(line);
                Cars.Add(car);
            }
        }

        public static void WriteCarsToFile()
        {
            using (var writer = new StreamWriter(CARS_FILENAME, false))
            {
                foreach (var car in Cars)
                {
                    car.WriteToFile(writer);
                }
            }
        }

        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public static void UpdateCar(Car car)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Id == car.Id)
                {
                    Cars[i] = car;
                }
            }
        }
    }
}
