using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CyrptocurrencyViewModel
    {
        public string short_code { get; set; }
        public string name { get; set; }
        public string currency { get; set; }
        public string current { get; set; }
        public string change_amount { get; set; }
        public string change_percentage { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string volume { get; set; }
        public string ask { get; set; }
        public string bid { get; set; }
        public int timestamp { get; set; }
    }
}
