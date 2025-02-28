using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactManagerApp.Models
{
	public class Contact
	{
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        
        public string Company { get; set; }
    }
}