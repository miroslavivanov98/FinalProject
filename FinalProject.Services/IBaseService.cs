using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Save(T item);
    }
}
