using HouseParser.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseParser.Storage
{
    public class ApartmentStorage : IApartmentStorage
    {
        IApartmentStorage apartmentStorage;


        public ApartmentStorage(IApartmentStorage _apartmentStorage)
        {
            apartmentStorage = _apartmentStorage;
        }

        public void Add(IApartment model)
        {
            apartmentStorage.Add(model);
        }

        public List<IApartment> GetAll()
        {
            return apartmentStorage.GetAll();
        }

        public void Remove(Guid guid)
        {
            apartmentStorage.Remove(guid);
        }

        public void SetApartmentStorage(IApartmentStorage _apartmentStorage)
        {
            apartmentStorage = _apartmentStorage;
        }

        public void Update(IApartment model)
        {
            apartmentStorage.Update(model);
        }
    }
}
