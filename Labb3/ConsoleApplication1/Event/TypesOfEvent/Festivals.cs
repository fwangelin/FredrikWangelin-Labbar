using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Festivals : Events
    {
        public string TopBandPlaying { get; set; }


        public override string IntroductionOfEvents()
        {
            return String.Format("{0}, Top Band playing: {1}",
                base.IntroductionOfEvents(),
                TopBandPlaying);

        }

    }
}