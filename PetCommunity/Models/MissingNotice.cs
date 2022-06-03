using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace PetCommunity.Models
{
    public class MissingNotice
    {
        [Key]
        public int MN_ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PetType { get; set; }
        public string PetBreed { get; set; }
        public string PetGender { get; set; }
        public string PetName { get; set; }

        public string image { get; set; }
        [NotMapped]
        public IFormFile imageFolder { get; set; }


    }
}
