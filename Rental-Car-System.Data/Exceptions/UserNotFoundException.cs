﻿namespace Rental_Car_System.Data.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message) 
        {

        }
    }
}