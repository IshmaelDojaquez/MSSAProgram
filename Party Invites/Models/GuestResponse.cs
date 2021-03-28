using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_PartyInvites_.Models
{
    public class GuestResponse
    {
        //Fields & Properties

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required (ErrorMessage = "Please Select If You Are Attending")]
        public bool? WillAttend { get; set; }

        //Constructors


        //Methods
    }
}
