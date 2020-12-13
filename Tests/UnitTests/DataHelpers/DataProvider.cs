using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace UnitTests.DataHelpers
{
    public class DataProvider
    {
        public static List<T> GetData<T>()
        {
            var objJson = File.ReadAllText($"Data\\{typeof(T).Name}.json");
            return JsonConvert.DeserializeObject<List<T>>(objJson);
        }
    }
}