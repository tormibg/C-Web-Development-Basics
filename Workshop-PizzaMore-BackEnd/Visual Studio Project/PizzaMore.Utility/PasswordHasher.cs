﻿namespace PizzaMore.Utility
{
    public static class PasswordHasher
    {
        public static string Hash(string password)
        {
            return "SECRET" + password;
        }
    }
}