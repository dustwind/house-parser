using HouseParser.Models;
using System;
using Xunit;

namespace HouseParser.Tests.Models
{
    public class ApartmentTests
    {
        [Fact]
        public void ApartmantCreate()
        {
            Assert.NotNull(new Apartment("", 1, 1, 1, 1));
        }

        [Fact]
        public void ErrorIfAreaBelowZero()
        {
            var area = -1d;

            Assert.Throws<ArgumentException>(() => new Apartment("", area, 1, 1, 1));
        }

        [Fact]
        public void ErrorIfRoomBelowZero()
        {
            var rooms = -1;

            Assert.Throws<ArgumentException>(() => new Apartment("", 1, rooms, 1, 1));
        }

        [Fact]
        public void ErrorIfPriceBelowZero()
        {
            var price = -1d;

            Assert.Throws<ArgumentException>(() => new Apartment("", 1, 1, 1, price));
        }
    }
}
