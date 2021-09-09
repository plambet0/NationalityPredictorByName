using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalityPredictor.Models
{
    public class CountryModel
    {
        
        public string country_id { get; set; }

        [JsonProperty(PropertyName = "probability")]
        public decimal Probability { get; set;}

        public string ProbabilityFormated => (this.Probability * 100).ToString("F2") + "%";
    }
}
