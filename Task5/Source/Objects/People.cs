using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Source.Objects
{
    public class People
    {
        private readonly int _ID;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly DateTime _birthDay;
        private readonly int _registrationID;
        private readonly int? _liveID;

        public People(int ID, string firstName, string lastName, DateTime birthDay, int registrationID, int? liveID)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDay = birthDay;
            _ID = ID;
            _registrationID = registrationID;
            _liveID = liveID;
        }

        public int ID { get { return _ID; } }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public DateTime BirthDay { get { return _birthDay; } }
        public int RegistrationID { get { return _registrationID; } }
        public int? LiveID { get { return _liveID; } }
    }
}
