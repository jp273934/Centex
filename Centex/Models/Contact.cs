using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centex.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string Message { get; set; }
    }
}