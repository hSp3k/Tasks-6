using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source.Objects
{
    public class Street
    {
        private readonly string _title;
        private readonly int _cityID;
        private readonly int _ID;

        public Street(int id, int cityID, string title)
        {
            _title = title;
            _cityID = cityID;
            _ID = id;
        }

        public string Title { get { return _title; } }
        public int CityID { get { return _cityID; } }
        public int ID { get { return _ID; } }
    }
}
