﻿namespace Rental_Car_System.Data.Exceptions
{
    public class NoAvailableCarsException : Exception
    {
        public NoAvailableCarsException() : base("There are no available cars now.")
        {

        }
    }
}
