using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MongoDbCRUD.Common.RequestModel
{
   public class EmployeeDto
    {      
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public AddressDto PrimaryAddress { get; set; }
    }

    public class AddressDto
    {
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PinCode { get; set; }

    }
}
