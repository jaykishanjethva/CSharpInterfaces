using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// This is the IVehicle Interface
    /// </summary>
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Speed { get; set; }
        int Gear { get; set; }

        /// <summary>
        /// The contract method for changing the gear of vehicle
        /// </summary>
        /// <param name="newGear">The gear to change to</param>
        void ChangeGear(int newGear);
        void SpeedUp(int increment);
        void ApplyBrake(int decrement);
    }
}
