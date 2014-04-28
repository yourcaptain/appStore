using System.Collections.Generic;

using AppStore.Data;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ICollection<ApplicationVersion> AuthorizedApplicationVersions { get; set; }
        public virtual ICollection<ApplicationVersion> InstalledApplicationVersions { get; set; }
    }
}