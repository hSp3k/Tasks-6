using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source.Objects
{
    public class City
    {
        private readonly string _title;
        private readonly int _countryID;
        private readonly int _ID;

        public City(int id, int countryID, string title)
        {
            _title = title;
            _countryID = countryID;
            _ID = id;
        }


        public string Title { get { return _title; } }
        public int CountryID { get { return _countryID; } }
        public int ID { get { return _ID; } }
    }
}
