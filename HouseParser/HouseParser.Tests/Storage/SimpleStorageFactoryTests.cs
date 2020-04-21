using HouseParser.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HouseParser.Tests.Storage
{
    public class SimpleStorageFactoryTests
    {
        [Fact]
        public void ErrorCreateApartmentStorage()
        {
            var enumTest = (ApartmentStorageEnum)10;
            var factory = new SimpleStorageFactory();

            Assert.Throws<ArgumentException>(() => factory.CreateApartmentStorage(enumTest));
        }

        [Fact]
        public void ApartmantStorageCreate()
        {
            var enumTest = ApartmentStorageEnum.CSV;
            var factory = new SimpleStorageFactory();

            Assert.NotNull(factory.CreateApartmentStorage(enumTest));
        }
    }
}
