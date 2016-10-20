using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Concerts : Events
    {
        public string WillConcertBeOutside { get; set; }

    public override string IntroductionOfEvents()
        {
            return String.Format("{0}, The concert will be: {1}",
                base.IntroductionOfEvents(),
                WillConcertBeOutside);

        }
    }
}