﻿

namespace CRM.Domain.Entities
{
    public class Client
    {
        public decimal ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Notes { get; set; }
    }
}
