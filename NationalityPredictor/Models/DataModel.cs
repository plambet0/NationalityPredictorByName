using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalityPredictor.Models
{
    public class DataModel
    {

        public DataModel()
        {
            this.Country = new HashSet<CountryModel>();
        }
        
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "country")]
        public ICollection<CountryModel> Country { get; set; }
    }
}
