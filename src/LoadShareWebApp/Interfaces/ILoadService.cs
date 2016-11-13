using System.Collections.Generic;
using LoadShareWebApp.Models;

namespace LoadShareWebApp.Services
{
    public interface ILoadService
    {
        void DeleteLoad(int id);
        IList<Load> GetAllLoads();
        Load GetLoadById(int id);
        void SaveLoad(Load load);
        List<Load> SearchByOrigin(string searchTerm);
    }
}