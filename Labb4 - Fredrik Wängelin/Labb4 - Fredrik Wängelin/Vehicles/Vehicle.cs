using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___Fredrik_Wängelin
{
    public abstract class Vehicle
    {

        public string VehicleManufacturer { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleYear { get; set; }
        public int VehiclePrice { get; set; }
        public int VehicleMilage { get; set; }

        public virtual string IntroductionOfVehicles()
        {
            return String.Format("Märke: {0}, Modell: {1},\n Årsmodell: {2}, Pris: {3}, Miltal: {4}",
                                VehicleManufacturer,
                                VehicleModel,
                                VehicleYear,
                                VehiclePrice,
                                VehicleMilage);
        }


    }

     
}