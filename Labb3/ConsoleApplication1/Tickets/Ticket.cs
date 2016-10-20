using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tickets
{
    class Ticket
    {
        public string Person { get; set; }

        public override string ToString()
        {
            return String.Format("Dear {0}, You have booked following event: ", Person);
        }
    }
}
