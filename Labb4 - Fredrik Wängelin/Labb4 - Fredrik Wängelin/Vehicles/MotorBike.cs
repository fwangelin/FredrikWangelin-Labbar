using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___Fredrik_Wängelin
{
    public class MotorBikes : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public string EngineSize { get; set; }

        public override string IntroductionOfVehicles()
        {
            return String.Format("{0}, \n Antal sittplatser: {1}, {2} kubik.",
                                base.IntroductionOfVehicles(),
                                NumberOfSeats,
                                EngineSize);
        }
    }
}