using LoadShareWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadShareWebApp.Services
{
    public class TruckDetailService : ITruckDetailService
    {
        private IGenericRepository _repo;

        public TruckDetailService(IGenericRepository repo)
        {
            _repo = repo;
        }


        //Get all trucks (called by controller Get() method)
        public IList<TruckDetail> GetAllTruckDetails()
        {
            return _repo.Query<TruckDetail>().ToList();
        }

        //Get Single truck by Id (called by the Get["{id}"](truckDetail) method)

        public TruckDetail GetTruckDetailById(int id)
        {
            return _repo.Query<TruckDetail>().Where(m => m.Id == id).FirstOrDefault();
        }

        //Post single truck to the database (called by the Post(movie) method)
        public void SaveTruckDetail(TruckDetail truckDetail)
        {
            if (truckDetail.Id == 0)
            {
                _repo.Add(truckDetail);

            }
            else
            {
                _repo.Update(truckDetail);
            }
        }

        //Delete single truck form the database(called by the Delete(truck) method)

        public void DeleteTruckDetail(int id)
        {
            TruckDetail truckDetailToDelete = _repo.Query<TruckDetail>().Where(m => m.Id == id).FirstOrDefault();
            _repo.Delete(truckDetailToDelete);
        }

        public List<TruckDetail> SearchByOrigin(string searchTerm)
        {
            var movies = _repo.Query<TruckDetail>();//we will search for Origin based on giving a field value(ie Namae)
            return (from m in movies
                    where m.Origin == searchTerm
                    select new TruckDetail
                    {
                        Id = m.Id,
                        Origin = m.Origin,
                    }).ToList();
        }

        //public IList<Truck> GetAllTrucks()
        //{
        //    throw new NotImplementedException();
        //}



    }
}
