using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Task4.Source;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? text = "1";
            Console.WriteLine(text.UInt32TryPrase());
        }
    }
}