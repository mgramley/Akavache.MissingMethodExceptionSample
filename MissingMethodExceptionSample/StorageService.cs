using Akavache;
using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace MissingMethodExceptionSample
{
    public class StorageService
    {
        public async Task SetAsync<T>(string uniqueKey, T value, DateTimeOffset? absoluteExpiration = null)
        {
            await BlobCache.LocalMachine.InsertObject<T>(uniqueKey, value, absoluteExpiration);
        }

        public async Task<T> GetAsync<T>(string uniqueKey)
        {
            return await BlobCache.LocalMachine.GetObject<T>(uniqueKey);
        }
    }
}
