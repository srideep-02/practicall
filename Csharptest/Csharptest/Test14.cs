using System;
using System.Net.Security;

sealed class SecuritySystem
{
    public static void Mainn(string[] args)
    {
        Authenticate();
    }
    public static void Authenticate()
    {
        Console.WriteLine("Authentication Successful!");
    }
}

