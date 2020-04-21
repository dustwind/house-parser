using HouseParser.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseParser.Storage
{
    public class SqlApartmentStorage : IApartmentStorage
    {
        protected string ConnectionString { get; set; }

        public SqlApartmentStorage()
        {
        }

        public SqlApartmentStorage(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        void IApartmentStorage.Add(IApartment model)
        {
            throw new NotImplementedException();
        }

        List<IApartment> IApartmentStorage.GetAll()
        {
            throw new NotImplementedException();
        }

        void IApartmentStorage.Remove(Guid guid)
        {
            throw new NotImplementedException();
        }

        void IApartmentStorage.Update(IApartment model)
        {
            throw new NotImplementedException();
        }
    }
}
