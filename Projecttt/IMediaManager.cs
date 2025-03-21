using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecttt
{
    public interface IMediaManager<T> where T : Media
    {
        void Add(T item);
        bool Remove(string title);
        T FindByTitle(string title);
        IEnumerable<T> FilterByYear(int year);
        IEnumerable<T> GetAllAvailable();
    }
}
