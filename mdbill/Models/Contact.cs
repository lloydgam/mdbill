using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mdbill.Models
{
    public class Contact
    {

        public int ID { get; set; }
        public int Information_ID { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Others { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}