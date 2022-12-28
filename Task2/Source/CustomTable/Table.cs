using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Source.ConsoleTable
{
    public class Table
    {
        public List<object> Columns { get; set; }
        public List<object[]> Rows { get; set; }


        public Table(params string[] names)
        {
            Columns = new List<object>(names);
            Rows = new List<object[]>();
        }


        public Table AddRow(params object[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            if (!Columns.Any())
            {
                throw new Exception("Пожалуйста, сначала установите столбцы");
            }
            if (Columns.Count != values.Length)
            {
                throw new Exception($"Числовые столбцы в строке ({Columns.Count}) не соответствует значениям ({values.Length})");
            }
            Rows.Add(values);
            return this;
        }

        public Table AddColumn(params object[] names)
        {
            foreach (var item in names)
            {
                Columns.Add(item);
            }
            return this;
        }

        public void Write()
        {
            var maxLength = GetMaxLength();

            WriteLineTabel(Columns, maxLength);
            foreach (var item in Rows)
            {
                WriteLineTabel(item, maxLength);
            }
        }


        private void WriteLineTabel(IList<object> collection, List<int> maxLength)
        {
            Console.Write(" | ");
            for (int i = 0; i < Columns.Count; i++)
            {
                var item = collection[i].ToString();
                if(item != null)
                {
                    Console.Write(item.PadRight(maxLength[i]) + " | ");
                }
            }
            Console.WriteLine();
        }

        private List<int> GetMaxLength()
        {
            var listMaxLength = new List<int>(new int[Columns.Count]);

            string? item;
            for (int i = 0; i < Columns.Count; i++)
            {
                foreach (var obj in Rows)
                {
                    item = obj[i].ToString();
                    if(item != null)
                    {
                        listMaxLength[i] = Math.Max(listMaxLength[i], item.Length);
                    }
                }
                item = Columns[i].ToString();
                if (item != null)
                {
                    listMaxLength[i] = Math.Max(listMaxLength[i], item.Length);
                }
            }
            return listMaxLength;
        }
    }
}
