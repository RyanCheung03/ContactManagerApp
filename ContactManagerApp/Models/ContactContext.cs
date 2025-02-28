using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ContactManagerApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
