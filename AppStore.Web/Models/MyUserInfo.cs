using System.Collections.Generic;

using AppStore.Data;

namespace AppStore.Web.Models
{
    public class MyUserInfo
    {
        public int MyUserInfoId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool IsEnabled { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<ApplicationVersion> AuthorizedApplicationVersions { get; set; }
        public virtual ICollection<ApplicationVersion> InstalledApplicationVersions { get; set; }
    }
}