using HouseParser.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseParser.Storage
{
    public class SqlExpressApartmentStorage : IApartmentStorage
    {
        protected string ConnectionString { get; set; }

        public SqlExpressApartmentStorage()
        {
        }

        public SqlExpressApartmentStorage(string connectionString)
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
