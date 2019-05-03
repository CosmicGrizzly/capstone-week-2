using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_capstone
{
    class Task
    {
        public List<string> members;
        public Task()
        {
            members = new List<string>();
            status = false;
        }
        public string date;
        public bool status;
        public string description;
    }
   
}
