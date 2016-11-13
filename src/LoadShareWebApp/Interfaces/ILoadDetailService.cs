using System.Collections.Generic;
using LoadShareWebApp.Models;

namespace LoadShareWebApp.Services
{
    public interface ILoadDetailService
    {
        void DeleteLoadDetail(int id);
        IList<LoadDetail> GetAllLoadDetails();
        LoadDetail GetLoadDetailById(int id);
        void SaveLoadDetail(LoadDetail loadDetail);
        List<LoadDetail> SearchByOrigin(string searchTerm);
    }
}