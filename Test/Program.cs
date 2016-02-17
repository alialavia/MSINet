using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInstallerNET;
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
            foreach (var p in InstalledProduct.Enumerate())
            {
                try
                {
                    if (p.InstalledProductName.Contains("Word"))                     
                        Console.Out.WriteLine("{0}\r\n-------------------------------------------------------------\r\n{1}", p.GUID, p.ToString());                    
                }
                catch (Exception ex)
                {
                    // Some products might throw an exception trying to access InstalledProductName propoerty.
                }
            }
        }
    }
}
