using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Events
    {
        public string Person { get; set; }
        public string DateOfEvent { get; set; }
        public string PlaceOfEvent { get; set; }
        public string NameOfEvent { get; set; }


        public virtual string IntroductionOfEvents()
        {
            return String.Format("Event Name: {0},\n Date of Event: {1}, Place of Event: {2}",
                NameOfEvent,
                DateOfEvent,
                PlaceOfEvent);
        }

    }
}