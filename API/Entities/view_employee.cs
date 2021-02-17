using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class view_employee
    {

        public int IdEmployee { get; set; }
        public int IdUser { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
    }
}
