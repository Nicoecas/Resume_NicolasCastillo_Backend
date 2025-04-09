namespace Resume_NicolasCastillo_Backend.Data
{
    public class InMemoryDb
    {
        private static readonly Lazy<InMemoryDb> instance = new(() => new InMemoryDb());
        public static InMemoryDb Instance => instance.Value;

        private readonly Dictionary<string, List<object>> storage = new();

        private InMemoryDb() { }

        public void Add<T>(T item)
        {
            var key = typeof(T).Name;
            if (!storage.ContainsKey(key))
                storage[key] = new List<object>();

            storage[key].Add(item!);
        }

        public List<T> GetAll<T>()
        {
            var key = typeof(T).Name;
            if (!storage.ContainsKey(key))
                return new List<T>();

            return storage[key].Cast<T>().ToList();
        }

        public T? FirstOrDefault<T>(Func<T, bool> predicate)
        {
            return GetAll<T>().Where(predicate).FirstOrDefault();
        }

        public List<T> ListAll<T>(Func<T, bool> predicate)
        {
            return GetAll<T>().Where(predicate).ToList();
        }
    }
}
