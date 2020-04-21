using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HouseParser.Storage
{
    public class StorageSimpleFactory
    {
        public IApartmentStorage CreateApartmentStorage(ApartmentStorageEnum type)
        {
            IApartmentStorage result = null;

            if (!Enum.IsDefined(typeof(ApartmentStorageEnum), type))
            {
                throw new ArgumentException("Unhandled ApartmentStorageEnum value");
            }

            switch (type)
            {
                case ApartmentStorageEnum.CSV:
                    {
                        result = new CsvApartmentStorage(GetConnectionString(type));
                        break;
                    }
                case ApartmentStorageEnum.SQL:
                    {
                        result = new SqlApartmentStorage(GetConnectionString(type));
                        break;
                    }
                case ApartmentStorageEnum.SQLite:
                    {
                        result = new SqliteApartmentStorage(GetConnectionString(type));
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException("Unsupported ApartmentStorageEnum value.");
                    }                    
            }

            return result;
        }

        private string GetConnectionString(ApartmentStorageEnum type)
        {
            return ConfigurationManager.ConnectionStrings[type.ToString()]?.ConnectionString;
        }
    }
}
