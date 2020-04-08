using HouseParser.Storage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HouseParser.Models
{
    public class ApartmentStorageInfo
    {
        public ApartmentStorageEnum Type { get; private set; }

        public string ConnectionString { get; private set; }

        public ApartmentStorageInfo (ApartmentStorageEnum type)
        {
            if (!Enum.IsDefined(typeof(ApartmentStorageEnum), type))
            {
               throw new ArgumentException("Unhandled ApartmentStorageEnum value");
            }

            Type = type;
            ConnectionString = ConfigurationManager.ConnectionStrings[type.ToString()]?.ConnectionString;
        }
    }
}
