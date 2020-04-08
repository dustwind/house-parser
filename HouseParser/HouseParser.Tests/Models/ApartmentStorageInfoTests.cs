using HouseParser.Models;
using HouseParser.Storage;
using System;
using Xunit;

namespace HouseParser.Tests.Models
{
    public class ApartmentStorageInfoTests
    {
        [Fact]
        public void ErrorApartmantStorafeInfoCreate()
        {
            var enumTest = (ApartmentStorageEnum)10;

            Assert.Throws<ArgumentException>(() => new ApartmentStorageInfo(enumTest));
        }

        [Fact]
        public void ApartmantStorageInfoCreate()
        {
            var enumTest = (ApartmentStorageEnum)0;

            Assert.NotNull(new ApartmentStorageInfo(enumTest));
        }
    }
}
