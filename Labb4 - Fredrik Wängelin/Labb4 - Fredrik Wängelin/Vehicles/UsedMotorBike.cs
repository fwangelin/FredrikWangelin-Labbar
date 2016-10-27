using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___Fredrik_Wängelin
{
    public class UsedMotorBike : MotorBikes
    {
        public int UsedMotorbikeAmountOfPreviousOwner { get; set; }
        public string UsedMotorbikePossibleDefects { get; set; }

        public override string IntroductionOfVehicles()
        {
            return String.Format("{0}, \n Antal ägare: {1}, Märkbar defekt: {2}",
                                base.IntroductionOfVehicles(),
                                UsedMotorbikeAmountOfPreviousOwner,
                                UsedMotorbikePossibleDefects);
        }
    }
}