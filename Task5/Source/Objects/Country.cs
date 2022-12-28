using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source.Objects
{
    public class Country
    {
        private readonly string _title;
        private readonly int _ID;

        public Country(int id, string title)
        {
            _ID = id;
            _title = title;
        }

        public string Title { get { return _title; } }
        public int ID { get { return _ID; } }
    }
}
