using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Source.Objects;

namespace Task5.Source
{
    public static class UtilityTask5
    {
        // Первое задание
        public static List<string> Task1(Database database)
        {
            List<string> result = new List<string>();

            database.Peoples.FindAll(people => DateTime.Today.Year - people.BirthDay.Year >= 18).
                ForEach(people => result.Add(people.FirstName + " " + people.LastName));

            return result;
        }

        // Второе задание
        public static List<string> Task2(Database database)
        {
            List<string> result = new List<string>();

            database.Peoples.FindAll(people => 
                database.HomeAddresses.Any(homeAddress => homeAddress.ID == people.RegistrationID && 
                database.Streets.Any(street => street.ID == homeAddress.StreetID && 
                database.Cities.Any(city => city.ID == street.CityID && city.Title.Contains("Саратов"))))).
                    ForEach(obj => result.Add(obj.FirstName + " " + obj.LastName));

            return result;
        }

        // Третье задание
        public static List<string> Task3(Database database)
        {
            List<string> result = new List<string>();

            database.Cities.FindAll(city => 
                database.Streets.Any(street => street.CityID == city.ID && street.Title.Contains("Садовая"))).
                    ForEach(obj => result.Add(obj.Title));

            return result;
        }

        // Четвертое задание
        public static List<string> Task4(Database database)
        {
            List<string> result = new List<string>();

            database.Countries.ForEach(country =>
                database.Cities.FindAll(city => city.CountryID == country.ID).ForEach(city =>
                database.Streets.FindAll(street => street.CityID == city.ID).ForEach(street =>
                database.HomeAddresses.FindAll(address => address.StreetID == street.ID).ForEach(address =>
                database.Peoples.FindAll(people => people.RegistrationID == address.ID).ForEach(people =>
                    result.Add(country.Title + " " +
                            city.Title + " " +
                            street.Title + " " +
                            address.HomeNumber + " " +
                            address.Apartment + " " +
                            people.FirstName + " " +
                            people.LastName))))));

            return result;
        }

        // Пятое задание
        public static double Task5(Database database)
        {
            List<People> result =
                database.Peoples.FindAll(people =>
                    database.HomeAddresses.Any(homeAddress => homeAddress.ID == people.RegistrationID && homeAddress.HomeNumber.Contains("№17") &&
                    database.Streets.Any(street => street.ID == homeAddress.StreetID && street.Title.Contains("ул. 2-я Садовая") &&
                    database.Cities.Any(city => city.ID == street.CityID && city.Title.Contains("Саратов") &&
                    database.Countries.Any(country => country.ID == city.CountryID && country.Title.Contains("Россия"))))));

            return result.Sum(obj => obj.BirthDay.Year) / result.Count;
        }
    }
}
