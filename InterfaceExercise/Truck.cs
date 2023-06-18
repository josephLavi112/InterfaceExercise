using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle,ICompany
    {
        public string BedLength { get; set; }
        public int GasMileage { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int WheelCount { get; set; }
        public string logo { get; set; }
        public string CoName { get; set; }
    }
}
