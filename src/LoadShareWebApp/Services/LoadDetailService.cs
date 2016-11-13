using LoadShareWebApp.Models;
using LoadShareWebApp.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadShareWebApp.Services
{
    public class LoadDetailService : ILoadDetailService
    {
        private IGenericRepository _repo;

        public LoadDetailService(IGenericRepository repo)
        {
            _repo = repo;
        }


        //Get all trucks (called by controller Get() method)
        public IList<LoadDetail> GetAllLoadDetails()
        {
            return _repo.Query<LoadDetail>().ToList();
        }

        //Get Single loadDetail by Id (called by the Get["{id}"](loadDetail) method)

        public LoadDetail GetLoadDetailById(int id)
        {
            return _repo.Query<LoadDetail>().Where(m => m.Id == id).FirstOrDefault();
        }

        //Post single truck to the database (called by the Post(movie) method)
        public void SaveLoadDetail(LoadDetail loadDetail)
        {
            if (loadDetail.Id == 0)
            {
                _repo.Add(loadDetail);

            }
            else
            {
                _repo.Update(loadDetail);
            }
        }

        //Delete single truck form the database(called by the Delete(truck) method)

        public void DeleteLoadDetail(int id)
        {
            LoadDetail loadDetailToDelete = _repo.Query<LoadDetail>().Where(m => m.Id == id).FirstOrDefault();
            _repo.Delete(loadDetailToDelete);
        }

        public List<LoadDetail> SearchByOrigin(string searchTerm)
        {
            var movies = _repo.Query<LoadDetail>();//we will search for Origin based on giving a field value(ie Namae)
            return (from m in movies
                    where m.Origin == searchTerm
                    select new LoadDetail
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
