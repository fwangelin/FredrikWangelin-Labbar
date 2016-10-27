using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___Fredrik_Wängelin
{
    public class UsedCar : Car
    {
        public int UsedCarAmountOfPreviousOwner { get; set; }
        public string UsedCarPossibleDefects { get; set; }

        public override string IntroductionOfVehicles()
        {
            return String.Format("{0}, Antal ägare: {1}, Eventuella skavanker: {2}",
                                base.IntroductionOfVehicles(),
                                UsedCarAmountOfPreviousOwner,
                                UsedCarPossibleDefects);
        }
    }
}