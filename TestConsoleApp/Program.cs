using System;
//Author: 
namespace TestConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WhatAClass wat = new WhatAClass();
            Console.WriteLine(wat.getTheString());
        }
    }
/// <summary>
/// Class holds a constant attribute, and a method for returning said attribute.
/// </summary>
    class WhatAClass
    {
        private String theString = "The one string";
        
        public String getTheString()
        {
            return theString;
        }
    }
}