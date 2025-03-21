using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecttt
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        private List<T> mediaCollection = new List<T>();
        private Dictionary<string, T> mediaDictionary = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (mediaDictionary.ContainsKey(item.Title))
            {
                throw new InvalidOperationException("Элемент с таким названием уже существует в коллекции.");
            }
            mediaCollection.Add(item);
            mediaDictionary[item.Title] = item;
        }

        public bool Remove(string title)
        {
            if (!mediaDictionary.ContainsKey(title))
            {
                throw new KeyNotFoundException("Элемент с таким названием не найден в коллекции.");
            }

            T item = mediaDictionary[title];
            mediaCollection.Remove(item);
            mediaDictionary.Remove(title);
            return true;
        }

        public T FindByTitle(string title)
        {
            if (!mediaDictionary.TryGetValue(title, out T item))
            {
                throw new KeyNotFoundException("Элемента с таким названием нету.");
            }
            return item;
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            return mediaCollection.Where(media => media.YearPublished == year);
        }

        public IEnumerable<T> GetAllAvailable()
        {
            return mediaCollection.Where(media => media.IsAvailable);
        }

        public void PrintAll()
        {
            foreach (var media in mediaCollection)
            {
                Console.WriteLine($"{media.GetType().Name}: {media.Title}, Автор: {media.Author}, Год: {media.YearPublished}, Доступно: {media.IsAvailable}");
            }
        }

        public void Borrow(string title)
        {
            T item = FindByTitle(title);
            if (!item.IsAvailable)
                throw new InvalidOperationException("Элемент нельзя выдать.");

            item.IsAvailable = false;
            Console.WriteLine($"Выдан элемент: {title}");
        }

        public void Return(string title)
        {
            T item = FindByTitle(title);
            if (item.IsAvailable)
                throw new InvalidOperationException("Элемент уже возвращен.");

            item.IsAvailable = true;
            Console.WriteLine($"Возвращен элемент: {title}");
        }
    }
}
