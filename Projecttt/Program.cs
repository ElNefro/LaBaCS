using System;
using System.Collections.Generic;
using System.Linq;

namespace Projecttt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Media> library = new Library<Media>();

            try
            {
                library.Add(new Book("1954", "Дж. Р. Р. Толкин", 1954, true, 752, "Властелин колец"));
                library.Add(new Movie("Гарри Поттер 1", "Джоан Роулинг", 2001, true, TimeSpan.FromHours(2.32), "Джоан Роулинг"));
                library.Add(new MusicAlbum("Театр демона", "КиШ", 2010, true, "КиШ", 9));

                library.PrintAll();

                var availableMedia = library.GetAllAvailable();
                Console.WriteLine("\nДоступная медия:");
                foreach (var media in availableMedia)
                {
                    Console.WriteLine($"{media.Title} by {media.Author} ({media.YearPublished})");
                }

                library.Borrow("\n1999");
                Console.WriteLine("\nПосле '1999':");
                library.PrintAll();

                library.Return("\n1999");
                Console.WriteLine("\nпосле возвращения '1999':");
                library.PrintAll();

                var filteredMedia = library.FilterByYear(2010);
                Console.WriteLine("\nМедия выпущенная в 2010:");
                foreach (var media in filteredMedia)
                {
                    Console.WriteLine($"{media.Title} by {media.Author} ({media.YearPublished})");
                }

                library.Remove("\nПервая встречная");
                Console.WriteLine("\nПосле 'Первая встречная':");
                library.PrintAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}");
            }
        }
    }
}
