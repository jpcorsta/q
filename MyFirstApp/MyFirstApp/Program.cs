﻿    using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("i am a argument and am called from a method");
            Console.Read();
        }
        // acces modifier (static) return type, method name (parameter1 parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}



    

