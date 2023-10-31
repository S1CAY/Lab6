using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    public class FunctionCache<TKey, TResult>
    {
        private readonly Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();

        public Func<TKey, TResult> Function { get; }

        public FunctionCache(Func<TKey, TResult> function)
        {
            Function = function;
        }

        public TResult GetResult(TKey key, TimeSpan expirationTime)
        {
            if (cache.TryGetValue(key, out var cacheItem))
            {

                if (DateTime.Now - cacheItem.CacheTime <= expirationTime)
                {
                    return cacheItem.Result;
                }
            }

            TResult result = Function(key);

            cache[key] = new CacheItem(result, DateTime.Now);

            return result;
        }

        private class CacheItem
        {
            public TResult Result { get; }
            public DateTime CacheTime { get; }

            public CacheItem(TResult result, DateTime cacheTime)
            {
                Result = result;
                CacheTime = cacheTime;
            }
        }
    }
}
