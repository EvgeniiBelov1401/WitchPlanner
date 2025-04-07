using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitchPlanner.Modules
{
    public class Client
    {
        public DateTime? Date { get; set; }
        public string? Name { get; set; }
        

        public Client(string name)
        {
            this.Date = DateTime.Now;
            this.Name = name;
        }
    }
}
