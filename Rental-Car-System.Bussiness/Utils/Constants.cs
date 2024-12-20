﻿namespace Rental_Car_System.Bussiness.Utils
{
    public static class Constants
    {
        public static readonly double coefficientForCarDamage = 30.0;
        public static readonly int minYearOfManufacture = 2000;
        public static readonly int maxYearOfManufacture;
        public static readonly int minPrice = 1000;
        public static readonly int maxPrice = 1000000;
        public static readonly double minFuelConsumption = 1;
        public static readonly double maxFuelConsumption = 100;
        public static readonly double priceDivisor = 100.0;
        public static readonly int daysToSkip = 2;
        public static readonly int maxNumberOfLetters = 25;
        public static readonly int maxMonthToRent = 1;
        public static readonly string pathToCarImages = "../../../Assets/";
        public static readonly int numberOfCarsCards = 3;
        public static readonly int startingClientBalance = 100000;
        public static readonly int pageSize = 12;
        static Constants()
        {
            maxYearOfManufacture = DateTime.Now.Year;
        }
    }
}
