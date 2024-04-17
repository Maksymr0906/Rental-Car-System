using Newtonsoft.Json;
using Rental_Car_System.Data.Models;
using System.Diagnostics;

namespace Rental_Car_System.Data.Repositories.Implementation
{
    [Obsolete]
    public class JsonRepository<T> where T : Entity
    {
        private List<T> items;
        private static JsonRepository<T> instance;

        public string FilePath { get; private set; }

        private JsonRepository(string path)
        {
            FilePath = path;

            if (!File.Exists(FilePath))
            {
                using (File.Create(FilePath)) { }
            }

            items = GetAllItemsFromFile();
        }

        public static JsonRepository<T> GetRepo(string path)
        {
            if (instance == null)
            {
                instance = new JsonRepository<T>(path);
            }

            return instance;
        }

        private List<T> GetAllItemsFromFile()
        {
            try
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error reading json: {ex.Message}");
                return new List<T>();
            }
        }

        private void SaveItemsToFile(List<T> items)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(items, Formatting.Indented);
                File.WriteAllText(FilePath, updatedJson);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error reading json: {ex.Message}");
            }
        }

        public void Create(T item)
        {
            items.Add(item);
            SaveItemsToFile(items);
        }

        public void Delete(T item)
        {
            items.RemoveAll(i => i.Id == item.Id);
            SaveItemsToFile(items);
        }

        public List<T> GetAll(Func<T, bool> filter = null)
        {
            return filter != null ? items.Where(filter).ToList() : items;
        }

        public void Update(T item)
        {
            var existingItemIndex = items.FindIndex(i => i.Id == item.Id);
            if (existingItemIndex != -1)
            {
                items[existingItemIndex] = item;
                SaveItemsToFile(items);
            }
        }

        public T GetByFilter(Func<T, bool> filter)
        {
            return items.FirstOrDefault(filter);
        }
    }
}
