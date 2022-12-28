using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Source;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = new UtilityTask2();
            obj.DataInput();
            obj.DataExtraction();
            obj.DataOutput();
        }
    }
}