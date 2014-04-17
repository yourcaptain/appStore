using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.Data
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationVersion> Versions { get; set; }
    }
}
