using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stroyka.Extensions
{
    public class MyList<TEntity, TPrimaryKey> :IAsyncDisposable where TEntity : BaseEntity<TPrimaryKey>
    {
        public static List<TEntity> DublicateDelete(List<TEntity> list)
        {
            List<TEntity> result = new();
            result.AddRange(list);

            foreach (var item in list)
            {
                var categories2 = result.FindAll(x=>x.Id.Equals(item.Id));
                if (categories2.Count > 1)
                {
                    foreach (var item2 in categories2)
                    {
                        if (list.IndexOf(item) != list.IndexOf(item2))
                            result.Remove(item);
                    }
                }
            }
            return result;
        }


        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
