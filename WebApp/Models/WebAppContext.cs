using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class WebAppContext : DbContext
    {    
        public WebAppContext() : base("name=WebAppContext")
        {
        }

        public System.Data.Entity.DbSet<WebApp.Models.Movie> Movies { get; set; }
    }
}
