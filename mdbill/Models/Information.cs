using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace mdbill.Models
{
    public class Information
    {
        public int ID { get; set; }
        public string AccountNo { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string Others { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}