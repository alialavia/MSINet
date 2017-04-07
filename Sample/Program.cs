using System;
using MSINet;

namespace Sample
{
    class Program
    {
        /// <summary>
        /// Look for installed applications with names containing 'Word' and showing their properties (installed location, version, ...)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (var p in InstalledProduct.EnumerateInstalledProducts())
            {
                if (p.InstalledProductName != null && p.InstalledProductName.Contains("Word"))
                    Console.Out.WriteLine("{0}\r\n-------------------------------------------------------------\r\n{1}", p.GUID, p.ToString());
            }
        }
    }
}
