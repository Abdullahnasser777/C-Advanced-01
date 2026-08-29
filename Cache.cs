using C__Advanced.Question__20;

namespace C__Advanced
{
    internal class Cache<T>
    {
        public static implicit operator Cache<T>(Cache<string, string> v)
        {
            throw new NotImplementedException();
        }
    }
}