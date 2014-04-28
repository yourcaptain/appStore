using AppStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Data
{
    public class ApplicationVersion
    {
        public int ApplicationVersionId { get; set; }
        public Application Application { get; set; }
        public int Version { get; set; }
        public int VersionName { get; set; }
        public string ReleaseNotes { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<MyUserInfo> InstalledUsers { get; set; }
        public virtual ICollection<MyUserInfo> AuthorizedUsers { get; set; }
    }
}
