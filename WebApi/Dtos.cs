using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpPerformanceTest
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }

        public static Customer Create()
        {
            return new Customer
            {
                Id = 100,
                CompanyName = "WOLZA",
                ContactName = "Wolski  Zajazd",
                City = "Zbyszek Piestrzeniewicz",
                Address = "Tuestreet 5",
                Region = "Desert",
                ContactTitle = "Boss X5",
                Country = "Schlumpfland",
                Phone = "544554656654546",
                PostalCode = "54545",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 45,
                        EmployeeId = 546,
                        OrderDate = ToDateTime("02/19/1952"),
                        RequiredDate = ToDateTime("08/14/1992"),
                        ShippedDate = ToDateTime("08/14/1992"),
                        ShipVia = 654,
                        ShipName = "iPad mini",
                        ShipAddress = "Kumpastrasse 2",
                        ShipCity = "Stuggort",
                        ShipCountry = "Trualandy",
                        ShipPostalCode = "54566",
                        ShipRegion = "Rumacheck"
                    }
                }
            };
        }

        public static DateTime ToDateTime(string dateTime)
        {
            var dateParts = dateTime.Split('/');
            return new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[0]), int.Parse(dateParts[1]));
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}