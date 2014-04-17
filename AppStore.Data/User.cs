using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsEnabled { get; set; }
        public Company Company { get; set; }
        public List<ApplicationVersion> AuthorizedApplicationVersions { get; set; }
        public List<ApplicationVersion> InstalledApplicationVersions { get; set; }
    }
}
