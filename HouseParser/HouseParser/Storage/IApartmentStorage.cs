using HouseParser.Models;
using System;
using System.Collections.Generic;

namespace HouseParser.Storage
{
    public interface IApartmentStorage
    {
        void Add(IApartment model);

        void Remove(Guid guid);

        void Update(IApartment model);

        List<IApartment> GetAll();
    }
}
