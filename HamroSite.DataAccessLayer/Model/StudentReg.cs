using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamroSite.DataAccessLayer
{
    public class StudentReg
    {
        public int StudentRegID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string ParentName { get; set; }
        public DateTime OnCreated { get; set; }
    }
}
