using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();

            Console.WriteLine("Podaj rok urodzenia:");
            var yearOfBirth = GetBirthYear();

            Console.WriteLine("Podaj miesiąc urodzenia:");
            var monthOfBirth = GetBirthMonth();

            Console.WriteLine("Podaj dzień urodzenia:");
            var dayOfBirth = GetBirthDay(yearOfBirth, monthOfBirth);

            Console.WriteLine("Podaj miejsce urodzenia:");
            var placeOfBirth = Console.ReadLine();

            var birthTime = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

            var age = DateTime.Now.Year - birthTime.Year;

            if (DateTime.Now.DayOfYear < birthTime.DayOfYear)
                age--;


            Console.WriteLine($"Cześć {name}, urodziłeś się w {placeOfBirth} i masz {age} lat.");

        }

        private static int GetBirthYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Spróbuj ponownie!");
                    continue;
                }

                return year;
            }

        }

        private static int GetBirthMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Spróbuj ponownie!");
                    continue;
                }

                return month;
            }
        }

        private static int GetBirthDay(int yearOfBirth, int monthOfBirth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day < 1 || day > DateTime.DaysInMonth(yearOfBirth, monthOfBirth))
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Spróbuj ponownie!");
                    continue;
                }

                return day;
            }
        }
    }
}

