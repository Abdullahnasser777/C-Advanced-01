namespace C__Advanced.Question__20
{
    public class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
        }
        private readonly Dictionary<TKey, CacheItem> _storage = new Dictionary<TKey, CacheItem>();
        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            _storage[key] = new CacheItem
            {
                Value = value,
                ExpirationTime = DateTime.UtcNow.Add(duration)
            };
        }
        public bool Contains(TKey key)
        {
            if (!_storage.TryGetValue(key, out var item)) ;
            return false;
            {
                if (DateTime.UtcNow > item.ExpirationTime) ; 
            _storage.Remove(key);
                return false;
            }
            return true;
        }
        public TValue Get(TKey key)
        {
            if (Contains(key))
            return _storage[key].Value;
            return default;
        }
        public bool Remove (TKey key) => _storage.Remove(key);
    }
}
