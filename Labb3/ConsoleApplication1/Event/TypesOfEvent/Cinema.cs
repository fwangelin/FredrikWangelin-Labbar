using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Cinema : Events
    {
        public string MovieCategory { get; set; }

        public override string IntroductionOfEvents()
        {
            return String.Format("{0}, Genre: {1}",
                base.IntroductionOfEvents(),
                MovieCategory);

        }
    }
}