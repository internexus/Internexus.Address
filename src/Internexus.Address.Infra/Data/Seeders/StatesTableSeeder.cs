using Internexus.Address.Domain.Entities;
using Newtonsoft.Json;
using System.Reflection;

namespace Internexus.Address.Infra.Data.Seeders
{
    public class StatesTableSeeder
    {
        public static List<StateEntity> Run()
        {
            var states = new List<StateEntity>();
            var baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (StreamReader r = new StreamReader($"{baseDir}/Data/Seeders/Data/States.json"))
            {
                string json = r.ReadToEnd();
                states = JsonConvert.DeserializeObject<List<StateEntity>>(json);
            }

            return states;
        }
    }
}
