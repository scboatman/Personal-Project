﻿using LoadShareWebApp.Models;
using LoadShareWebApp.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadShareWebApp.Services
{
    public class TruckService : ITruckService
    {
        private IGenericRepository _repo;
              


        //Get all trucks (called by controller Get() method)
        public IList<Truck> GetAllTrucks()
        {
            return _repo.Query<Truck>().ToList();
        }

        //Get Single truck by Id (called by the Get["{id}"](truck) method)

        public Truck GetTruckById(int id)
        {
            return _repo.Query<Truck>().Where(m => m.Id == id).FirstOrDefault();
        }

        //Post single truck to the database (called by the Post(movie) method)
        public void SaveTruck(Truck truck)
        {
            if (truck.Id == 0)
            {
                _repo.Add(truck);

            }
            else
            {
                _repo.Update(truck);
            }
        }

        //Delete single truck form the database(called by the Delete(truck) method)

        public void DeleteTruck(int id)
        {
            Truck truckToDelete = _repo.Query<Truck>().Where(m => m.Id == id).FirstOrDefault();
            _repo.Delete(truckToDelete);
        }

        public List<Truck> SearchByOrigin(string searchTerm)
        {
            var movies = _repo.Query<Truck>();//we will search for Origin based on giving a field value(ie Namae)
            return (from m in movies
                    where m.Origin == searchTerm
                    select new Truck
                    {
                        Id = m.Id,
                        Origin = m.Origin,
                    }).ToList();
        }

        //public IList<Truck> GetAllTrucks()
        //{
        //    throw new NotImplementedException();
        //}
        public TruckService(IGenericRepository repo)
        {
            _repo = repo;
        }




    }
}
