using System;

namespace HouseParser.Models
{
    public class Apartment : IApartment
    {
        public Guid Id { get; private set; }
        public string City { get; private set; }

        public double Area { get; private set; }

        public int Rooms { get; private set; }

        public int Floor { get; private set; }

        public double Price { get; private set; }

        public Apartment(string city, double area, int rooms, int floor, double price)
        {
            if (area < 0)
            {
                throw new ArgumentException("Area can not be negative.");
            }

            if (rooms < 0)
            {
                throw new ArgumentException("Rooms can not be negative.");
            }

            if (price < 0)
            {
                throw new ArgumentException("Price can not be negative.");
            }

            Id = Guid.NewGuid();
            City = city;
            Floor = floor;
            Area = area;
            Rooms = rooms;
            Price = price;
        }
    }
}
