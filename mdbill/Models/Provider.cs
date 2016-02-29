using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mdbill.Models
{
    public class Provider
    {
        public int ID { get; set; }
        public int Information_ID { get; set; }
        public string SHORTCUT { get; set; }
        public string PROVIDERNAME { get; set; }

        public string LASTNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public char MIDDLEINITIAL { get; set; }
        public string ADDRESS { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}