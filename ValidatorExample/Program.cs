using System;
using System.Collections.Generic;
using System.Linq;
using ValidatorExample.Validators;

namespace ValidatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordOne = "YusufArslan"; // Rakam eksik
            string passwordTwo = "yusufa2rslan"; // Büyük harf ve rakam eksik
            string passwordThree = "YusufArslan42"; // Her şey tamam


            IRules[] rules = new IRules[] { 
                new ValidForIsDigit(),
                new ValidForIsUpper(),
                new ValidForIsLower()
            };
            Console.WriteLine(passwordOne.IsValid(rules));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(passwordTwo.IsValid(rules));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(passwordThree.IsValid(rules));

        }
    }
}
