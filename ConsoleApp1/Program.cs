using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        
        public static void Main()
        {
            int number = 3;
            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Unknown"
            };
    }


    
}
