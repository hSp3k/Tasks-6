using Task5.Source.Objects;
using Task5.Source;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var database = new Database();

            database.Add(new Country(1, "Россия"));
            database.Add(new Country(2, "США"));
            database.Add(new Country(3, "Франция"));

            database.Add(new City(1, 1, "Саратов"));
            database.Add(new City(2, 1, "Москва"));
            database.Add(new City(3, 2, "Нью Йорк"));
            database.Add(new City(4, 2, "Вашингтон"));
            database.Add(new City(5, 3, "Париж"));

            database.Add(new Street(1, 1, "2 Садовая"));
            database.Add(new Street(2, 2, "Большая Садовая"));
            database.Add(new Street(3, 2, "Ленинградская"));
            database.Add(new Street(4, 3, "Таймс-сквер"));
            database.Add(new Street(5, 4, "Пенсильвания-авеню"));
            database.Add(new Street(6, 5, "Елисейские поля"));

            database.Add(new HomeAddress(1, 1, "31-35", 1));
            database.Add(new HomeAddress(2, 1, "17", 11));
            database.Add(new HomeAddress(3, 2, "21", 2));
            database.Add(new HomeAddress(4, 3, "31", 3));
            database.Add(new HomeAddress(5, 4, "41", 4));
            database.Add(new HomeAddress(6, 5, "51", 5));
            database.Add(new HomeAddress(7, 6, "61", 6));

            database.Add(new People(1, "Илья", "Гардин", new DateTime(1985, 1, 1), 1, 2));
            database.Add(new People(2, "Ульяна", "Кукушкина", new DateTime(1987, 2, 2), 2, 4));
            database.Add(new People(3, "Алена", "Байкова", new DateTime(1970, 3, 3), 5, null));
            database.Add(new People(4, "Михаил", "Павлычев", new DateTime(2000, 1, 5), 7, 3));
            database.Add(new People(5, "Яна", "Кочергина", new DateTime(2005, 3, 7), 6, 3));
            database.Add(new People(6, "Анастасия", "Асташева", new DateTime(1998, 4, 4), 3, null));
            database.Add(new People(7, "Дмитрий", "Гирко", new DateTime(1991, 2, 1), 3, 7));
            database.Add(new People(8, "Данил", "Макаркин", new DateTime(1978, 3, 5), 4, null));
            database.Add(new People(9, "Данил", "Шмелев", new DateTime(1985, 3, 1), 3, 5));
            database.Add(new People(10, "Ринат", "Хайрулин", new DateTime(2010, 3, 7), 7, 3));
            database.Add(new People(11, "Руслан", "Акпасов", new DateTime(1999, 3, 5), 2, 3));
            database.Add(new People(12, "Алексей", "Андреев", new DateTime(1990, 3, 2), 6, 3));

            UtilityTask5.Task4(database).
                ForEach(obj => Console.WriteLine(obj));
        }
    }
}