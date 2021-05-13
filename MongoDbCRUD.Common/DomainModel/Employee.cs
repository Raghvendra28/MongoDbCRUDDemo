using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbCRUD.Common.DomainModel
{
    public class Employee :BaseModel
    {
        [BsonId]
        public Guid Id { get; set; }

        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address PrimaryAddress { get; set; }
    }

    public class Address
    {
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PinCode { get; set; }

    }
}
