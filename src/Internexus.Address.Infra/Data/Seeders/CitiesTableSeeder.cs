using Internexus.Address.Domain.Entities;
using Newtonsoft.Json;
using System.Reflection;

namespace Internexus.Address.Infra.Data.Seeders
{
    public class CitiesTableSeeder
    {
        public static List<CityEntity> Run()
        {
            var cities = new List<CityEntity>();
            var baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (StreamReader r = new StreamReader($"{baseDir}/Data/Seeders/Data/Cities.json"))
            {
                string json = r.ReadToEnd();
                cities = JsonConvert.DeserializeObject<List<CityEntity>>(json);
            }

            return cities;
        }
    }
}
