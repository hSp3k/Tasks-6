using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source.Objects
{
    public class Database
    {
        private List<Country> _countries;
        private List<City> _cities;
        private List<Street> _streets;
        private List<HomeAddress> _homeAddresses;
        private List<People> _peoples;

        public Database()
        {
            _countries = new List<Country>();
            _cities = new List<City>();
            _streets = new List<Street>();
            _homeAddresses = new List<HomeAddress>();
            _peoples = new List<People>();
        }

        public List<Country> Countries { get { return _countries; } }
        public List<City> Cities { get { return _cities; } }
        public List<Street> Streets { get { return _streets; } }
        public List<HomeAddress> HomeAddresses { get { return _homeAddresses; } }
        public List<People> Peoples { get { return _peoples; } }

        public void Add(object obj)
        {
            switch (obj)
            {
                case Country:
                    {
                        Countries.Add((Country)obj);
                        break;
                    }
                case City:
                    {
                        Cities.Add((City)obj);
                        break;
                    }
                case Street:
                    {
                        Streets.Add((Street)obj);
                        break;
                    }
                case HomeAddress:
                    {
                        HomeAddresses.Add((HomeAddress)obj);
                        break;
                    }
                case People:
                    {
                        Peoples.Add((People)obj);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
