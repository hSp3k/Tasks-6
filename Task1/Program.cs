using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = new UtilityTask1();
            obj.DataInput();
            obj.StartAlgorithm();
            obj.DataOutput();
        }
    }
}