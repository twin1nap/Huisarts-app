using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarydB.model
{
    public class SmallPatiënt
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Adres { get; set; } //street
        //public string HouseNum { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        //public string PhoneNum { get; set; }
        public int NotesCount { get; set; }
    }
}
