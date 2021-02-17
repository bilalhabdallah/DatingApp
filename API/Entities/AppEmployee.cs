using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppEmployee
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

    }
}
