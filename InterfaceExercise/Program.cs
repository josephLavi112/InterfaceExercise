using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var subaru = new Car();
            subaru.Make = "subaru";
            subaru.Model = "wrx";
            subaru.WheelCount = 4;
            subaru.Year = 2020;
            subaru.CoName = "subaru inc.";
            subaru.IsElectric = false;

            var gmc = new Truck();
            gmc.Make = "GMC";
            gmc.Model = "Sierra";
            gmc.Year = 2023;
            gmc.WheelCount = 4;
            gmc.BedLength = "6ft";
            gmc.CoName = "GMC inc.";

            var lamborghini = new SUV();
            lamborghini.Model = "Urus";
            lamborghini.Make = "Lamborghini";
            lamborghini.Year = 2030;
            lamborghini.WheelCount = 4;
            lamborghini.IsHatchback = true;
            lamborghini.CoName = "Lamborghini inc.";

            var parkingLot = new List<IVehicle>() { subaru, gmc, lamborghini };

            foreach(var vehicle in parkingLot)
            {
                if(vehicle is Car)
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear:{vehicle.Year}\n" +
                    $"Wheel Count {vehicle.WheelCount}\nCompany: {vehicle.CoName}\nElectric {subaru.IsElectric}");
                }
                else if (vehicle is Truck)
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear:{vehicle.Year}\n" +
                    $"Wheel Count {vehicle.WheelCount}\nCompany: {vehicle.CoName}\nBedLength {gmc.BedLength}");
                }
                else
                {
                    Console.WriteLine($"Make: {vehicle.Make}\nModel: {vehicle.Model}\nYear:{vehicle.Year}\n" +
                    $"Wheel Count {vehicle.WheelCount}\nCompany: {vehicle.CoName}\nIsHatchbcack: {lamborghini.IsHatchback}");
                }
                
            }

        }
    }
}
