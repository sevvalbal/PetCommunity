using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetCommunity.Models
{
    public class Solidarity
    {

        [Key]
        public int S_ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Help_Type { get; set; }
        public string Description { get; set; }
        

    }
}
