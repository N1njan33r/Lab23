using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab23.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string Passcode { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}