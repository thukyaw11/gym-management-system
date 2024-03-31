using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_assignment.Utils
{

    public class DateNow
    {
        public DateNow()
        {
            DateCreated = DateTime.Now;
        }
        public DateTime DateCreated { get; set; }
    }
}
