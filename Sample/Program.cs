using System;
using MSINet;
using System.Text;

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
                Console.Out.WriteLine("{0}\r\n-------------------------------------------------------------\r\n{1}", p.GUID, PrintProduct(p));
            }
        }

        static string PrintProduct(InstalledProduct product)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var p in product.GetType().GetProperties())
                try
                {
                    sb.AppendFormat("{0}: {1}\r\n", p.Name, p.GetValue(product));
                }
                catch
                { }

            return sb.ToString();
        }
    }
}
