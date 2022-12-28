using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source.Objects
{
    public class HomeAddress
    {
        private readonly int _apartment;
        private readonly string _homeNumber;
        private readonly int _streetID;
        private readonly int _ID;

        public HomeAddress(int id, int streetID, string homeNumber, int apartment)
        {
            _apartment = apartment;
            _homeNumber = homeNumber;
            _streetID = streetID;
            _ID = id;
        }

        public int Apartment { get { return _apartment; } }
        public string HomeNumber { get { return _homeNumber; } }
        public int StreetID { get { return _streetID; } }
        public int ID { get { return _ID; } }
    }
}
