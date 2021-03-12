using System.Collections.Generic;

namespace Dale.ApplicationServices.Definitions
{
    public interface ICrudEntity<T>
    {
        T Create(T product);
        T Update(T product);
        bool Delete(int productId);
        T Get(int productId);
        IEnumerable<T> GetList();
    }
}
