using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MixERP.Net.Common.Helpers
{
    public static class CollectionHelper
    {
        public static Collection<T> ToCollection<T>(this List<T> items)
        {
            if (items == null)
            {
                return null;
            }


            Collection<T> collection = new Collection<T>();

            foreach (T t in items)
            {
                collection.Add(t);
            }

            return collection;
        }
    }
}