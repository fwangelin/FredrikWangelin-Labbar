using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tickets
{
    class ConcertTicket : Ticket
    {
        public Concerts Concert { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", base.ToString(), Concert.NameOfEvent);
        }
    }
}
