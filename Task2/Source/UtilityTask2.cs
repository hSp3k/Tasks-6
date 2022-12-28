using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Source.ConsoleTable;

namespace Task2.Source
{
    public class UtilityTask2
    {
        private string[]? _arrayWords;
        private Dictionary<string, uint>? _mapWords;

        public void DataInput()
        {
            Console.WriteLine("Введите текст: ");
            _arrayWords = Console.ReadLine()?.Split(new char[] { '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public void DataOutput()
        {
            if (_arrayWords != null && _mapWords != null)
            {
                uint number = 1;
                var table = new Table("Номер", "Слова", "Частота");
                foreach (var item in _mapWords)
                {
                    table.AddRow(number, item.Key, (item.Value / (double)_arrayWords.Length));
                    number++;
                }
                table.Write();
            }
            else
            {
                Console.WriteLine("Словарь пуст!");
            }
        }

        public void DataExtraction()
        {
            if (_arrayWords != null)
            {
                _mapWords = new Dictionary<string, uint>(StringComparer.OrdinalIgnoreCase);
                foreach (var obj in _arrayWords)
                {
                    if (obj != null)
                    {
                        if (_mapWords.ContainsKey(obj) == false)
                        {
                            _mapWords.Add(obj, 1);
                        }
                        else
                        {
                            _mapWords[obj] += 1;
                        }
                    }
                }
            }
        }
    }
}
