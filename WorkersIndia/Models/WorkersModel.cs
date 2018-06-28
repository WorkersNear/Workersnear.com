using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkersIndia.Models
{
    public class WorkersModel
    {
    }
    public class Register
    {       
        public string PhoneNumber { get; set; }   
        public string Password { get; set; }
       
    }

    public class Login
    {        
        public string UserName { get; set; }       
        public string Password { get; set; }       
    }

    public class Newworker
    { 

        [Required]       
        public string Name { get; set; }

        [Required]
        [StringLength(300)]       
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string Occupation { get; set; }

        [Required]
        [StringLength(100)]
        public string Area { get; set; }

        [Required]
        [StringLength(100)]
        public string ContratororSingle { get; set; }

        [Required]
        [StringLength(100)]
        public string Image { get; set; }       

        //[Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(100)]      
        public string Pincode { get; set; }



    }
}