using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bicycle : IVehicle, IPrintable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Gear { get; set; }

        /// <summary>
        /// Specific bicycle property
        /// </summary>
        public bool KickStandDown { get; private set; }

        /// <summary>
        /// Specific bicycle property
        /// </summary>
        public void DeployKiskStand()
        {
            KickStandDown = true;
        }

        public void UndeployKickStand()
        {
            KickStandDown = false;
        }

        public void ApplyBrake(int decrement)
        {
            Speed -= decrement;
        }

        public void ChangeGear(int newGear)
        {
            if (newGear > 18)
            {
                throw new ArgumentException("Bicycle gearing doesn't support more than 18 gears!");
            }
            if (newGear == 0)
            {
                throw new ArgumentException("Ooops! The chain came off!");
            }
            Gear = newGear;
        }

        public string Print()
        {
            string bike = "This is a bicycle\n";
            bike += $"Make: {Make}\n";
            bike += $"Model: {Model}\n";
            bike += $"Current Speed: {Speed}\n";
            bike += $"Current Gear: {Gear}\n";

            return bike;
        }

        /// <summary>
        /// support negative increment. support of reverse gear
        /// </summary>
        /// <param name="increment"></param>
        public void SpeedUp(int increment)
        {
            // Reverse is not supported

            if (Speed + increment < 0)
            {
                throw new ArgumentException("Bicycle do not support reverse.");
            }

            Speed += increment;
        }
    }
}
