using System.Collections.Generic;
using LoadShareWebApp.Models;

namespace LoadShareWebApp.Services
{
    public interface ITruckService
    {
        void DeleteTruck(int id);
        IList<Truck> GetAllTrucks();
        Truck GetTruckById(int id);
        void SaveTruck(Truck truck);
        List<Truck> SearchByOrigin(string searchTerm);
    }
}