using System;

namespace Architecture.Core.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            SharedLibrary.InterfaceSegregation.TestUseSettings.Test();
            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
