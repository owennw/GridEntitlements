﻿using Microsoft.Owin.Hosting;
using System;

namespace ShoppingAppEntitlements
{
    public class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:52560/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Server is running on {baseAddress}");
                Console.WriteLine("Press <enter> to stop server");
                Console.ReadLine();
            }
        }
    }
}