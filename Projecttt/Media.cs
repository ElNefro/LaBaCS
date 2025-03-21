using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecttt
{
    public class Media
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public bool IsAvailable { get; set; }

        public Media(string title, string author, int yearPublished, bool isAvailable)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            IsAvailable = isAvailable;
        }
    }
}
