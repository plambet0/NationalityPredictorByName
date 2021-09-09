using NationalityPredictor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalityPredictor.Services
{
    public interface INationalityPredictorService
    {
        Task<DataModel> GetCountries(string name);
    }
}
