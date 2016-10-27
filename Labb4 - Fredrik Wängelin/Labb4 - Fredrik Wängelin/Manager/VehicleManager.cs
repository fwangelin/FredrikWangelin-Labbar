using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___Fredrik_Wängelin.Manager
{
    class VehicleManager
    {
        public List<MotorBikes> NewMotorBikes { get; set; }
        public List<UsedMotorBike> UsedMotorBikes { get; set; }

        public void Manager()
        {
            NewMotorBikes = new List<MotorBikes>()
            {
            new MotorBikes { VehicleManufacturer = "Harley Davidson", VehicleModel = "Sportster", VehicleYear = 2017,
                VehiclePrice = 145000, VehicleMilage = 0, NumberOfSeats = 1, EngineSize = "1200"},

            new MotorBikes { VehicleManufacturer = "Harley Davidson", VehicleModel = "Dyna",      VehicleYear = 2017,
                VehiclePrice = 165000, VehicleMilage = 0, NumberOfSeats = 2, EngineSize = "1600"},

            new MotorBikes { VehicleManufacturer = "Harley Davidson", VehicleModel = "Softail",   VehicleYear = 2017,
                VehiclePrice = 263000, VehicleMilage = 0, NumberOfSeats = 2, EngineSize = "1800"},

            new MotorBikes { VehicleManufacturer = "Harley Davidson", VehicleModel = "Softail",   VehicleYear = 2017,
                VehiclePrice = 278000, VehicleMilage = 0, NumberOfSeats = 2, EngineSize = "1800"},

            new MotorBikes { VehicleManufacturer = "Harley Davidson", VehicleModel = "Softail",   VehicleYear = 2017,
                VehiclePrice = 213500, VehicleMilage = 0, NumberOfSeats = 2, EngineSize = "1800"},

            };

            UsedMotorBikes = new List<UsedMotorBike>()
            {
            new UsedMotorBike { VehicleManufacturer = "Harley Davidson", VehicleModel = "Sportster", VehicleYear = 2006,
                VehiclePrice = 70500, VehicleMilage = 3000, NumberOfSeats = 1, EngineSize = "1200",
                UsedMotorbikeAmountOfPreviousOwner = 2, UsedMotorbikePossibleDefects = "inga"},

            new UsedMotorBike { VehicleManufacturer = "Harley Davidson", VehicleModel = "Dyna",      VehicleYear = 2001,
                VehiclePrice = 89000, VehicleMilage = 5800, NumberOfSeats = 2, EngineSize = "1600",
                UsedMotorbikeAmountOfPreviousOwner = 2, UsedMotorbikePossibleDefects = "inga"},

            new UsedMotorBike { VehicleManufacturer = "Harley Davidson", VehicleModel = "Softail",   VehicleYear = 2014,
                VehiclePrice = 200000, VehicleMilage = 500, NumberOfSeats = 2, EngineSize = "1800",
                UsedMotorbikeAmountOfPreviousOwner = 2, UsedMotorbikePossibleDefects = "inga"},

            new UsedMotorBike { VehicleManufacturer = "Harley Davidson", VehicleModel = "Softail",   VehicleYear = 2009,
                VehiclePrice = 158000, VehicleMilage = 1500, NumberOfSeats = 2, EngineSize = "1800",
                UsedMotorbikeAmountOfPreviousOwner = 2, UsedMotorbikePossibleDefects = "inga"},

            new UsedMotorBike { VehicleManufacturer = "Harley Davidson", VehicleModel = "Softail",   VehicleYear = 1999,
                VehiclePrice = 140500, VehicleMilage = 2000, NumberOfSeats = 1, EngineSize = "1800",
                UsedMotorbikeAmountOfPreviousOwner = 2, UsedMotorbikePossibleDefects = "inga"},

            };
        }
            public void PrintNewMotorCycleStock()
        {
            Console.WriteLine("Nya Motorcyklar i lager:");
            Console.WriteLine();
            int i = 1;
            foreach (var newBikes in NewMotorBikes)
            {
                Console.WriteLine(i + ". " + newBikes.IntroductionOfVehicles()); i++;
            }
        }
        public void PrintUsedMotorCycleStock()
        {
            Console.WriteLine("Begagnade Motorcyklar i lager:");
            Console.WriteLine();
            int i = 1;
            foreach (var usedBikes in UsedMotorBikes)
            {
                Console.WriteLine(i + ". " + usedBikes.IntroductionOfVehicles()); i++;
            }
            Console.Read();
        }

    }


}
