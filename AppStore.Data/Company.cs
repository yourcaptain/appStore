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
        public List<ApplicationVersion> AuthorizedApplicationVersions { get; set; }
    }
}
