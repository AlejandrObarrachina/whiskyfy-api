using Microsoft.Extensions.Caching.Distributed;
using Whiskyfy_Api.Transversal.Redis.Contracts;

namespace Whiskyfy_Api.Transversal.Redis
{
    public class RedisPersistence : IRedisPersistence
    {
        private readonly IDistributedCache _distributedCache;

        public RedisPersistence(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public string GetData(string typeOfData)
        {
            var todayTimeStamp = DateTime.Today.ToString("yyyyMMdd");
            var tableKey = String.Concat(typeOfData, "_", todayTimeStamp);
            return _distributedCache.GetString(tableKey);
        }

        public void SaveData(string typeOfData, string jsonToSave)
        {
            var todayTimeStamp = DateTime.Today.ToString("yyyyMMdd");
            var tableKey = String.Concat(typeOfData, "_", todayTimeStamp);
            _distributedCache.SetString(tableKey, jsonToSave);
        }
    }
}
