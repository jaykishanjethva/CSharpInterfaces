using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car : IVehicle, IPrintable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Gear { get; set; }

        /// <summary>
        /// Specific car property
        /// </summary>
        public double FuelLevel { get; set; }

        /// <summary>
        /// specific method of car
        /// </summary>
        /// <param name="litres"></param>
        public void FillUp(double litres)
        {
            if(litres < 0)
            {
                throw new ArgumentException("Don't syphon fuel!");
            }

            FuelLevel += litres;
        }

        public void ApplyBrake(int decrement)
        {
            Speed -= decrement;
        }

        public void ChangeGear(int newGear)
        {
            if (newGear > 6)
            {
                throw new ArgumentException("Car trasmission doesn't support more than 6 gears!");
            }

            Gear = newGear;
        }

        public string Print()
        {
            string car = "This is a car\n";
            car += $"Make:{Make}\n";
            car += $"Model:{Model}\n";
            car += Speed > 0 ? $"Current Speed:{Speed}\n" : $"Current Reverse Speed:{Speed}\n";
            car += Gear >= 0 ? $"Current Gear:{Gear}\n" : $"Car is in reverse\n";

            return car;
        }

        /// <summary>
        /// support negative increment. support of reverse gear
        /// </summary>
        /// <param name="increment"></param>
        public void SpeedUp(int increment)
        {
            Speed += increment;

            //Don't allow reverse speed over 5

            if (Speed < 0)
            {
                Gear = -1; //-1 to dictate in reverse gear
            }
        }
    }
}
