using System.Collections.Generic;
using LoadShareWebApp.Models;

namespace LoadShareWebApp.Services
{
    public interface ITruckDetailService
    {
        void DeleteTruckDetail(int id);
        IList<TruckDetail> GetAllTruckDetails();
        TruckDetail GetTruckDetailById(int id);
        void SaveTruckDetail(TruckDetail truckDetail);
        List<TruckDetail> SearchByOrigin(string searchTerm);
    }
}