using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        T Create(T entity);

        List<T> Read();

        T Update(T entity);

        bool Delete(T entity);
    }
}
