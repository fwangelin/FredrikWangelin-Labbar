using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___Fredrik_Wängelin
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string MotorType { get; set; }

        public override string IntroductionOfVehicles()
        {
            return String.Format("{0}, Antal dörrar: {1}, Motortyp: {2}",
                                base.IntroductionOfVehicles(),
                                NumberOfDoors,
                                MotorType);
        }
    }
}