using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecttt
{
    public class Movie : Media
    {
        public TimeSpan Duration { get; set; }
        public string Director { get; set; }

        public Movie(string title, string author, int yearPublished, bool isAvailable, TimeSpan duration, string director) : base(title, author, yearPublished, isAvailable)
        {
            Duration = duration;
            Director = director;
        }
    }
}
