﻿namespace MaximumProblemusingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!! WELCOME Maximum Problem using Generics !!!!!");
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = MaxFloatsNo.maxFloatsNo(111.2, 22.45, 78.56);
             Console.WriteLine(doubleoutput);
        }
    }
}