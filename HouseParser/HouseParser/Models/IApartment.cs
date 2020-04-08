using System;

namespace HouseParser.Models
{
    public interface IApartment
    {
        public Guid Id { get; }

        public string City { get; }

        public double Area { get; }

        public int Rooms { get; }

        public int Floor { get; }

        public double Price { get; }

    }
}
