﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;
            Console.WriteLine("There once was man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            
            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            


            Console.ReadLine();
        }
    }
}
