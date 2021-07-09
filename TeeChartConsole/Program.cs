using System;
using TeeChartLibrary;

namespace TeeChartConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new TeeChartLicenseChecker();
            Console.WriteLine($"IsLicensed: {checker.IsLicensed()}");
        }
    }
}
