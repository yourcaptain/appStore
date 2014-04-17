using AppStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Data
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationVersion> AuthorizedApplicationVersions { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
