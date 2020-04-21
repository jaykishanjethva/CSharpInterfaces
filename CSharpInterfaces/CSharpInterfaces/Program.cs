using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Using interface as variable types
                IVehicle myBike = new Bicycle();
                IVehicle myCar = new Car();
                IVehicle myOtherCar = new Car();

                myBike.Make = "Giant";
                myBike.Model = "XTC Advanced 29";
                myBike.SpeedUp(3);
                myBike.ChangeGear(15);

                if(myBike is Bicycle)// type check to ensure a safe cast
                {
                    ((Bicycle)myBike).DeployKiskStand();
                    P("Kick stand deployed: "+ ((Bicycle)myBike).KickStandDown);
                }

                myCar.Make = "Jeep";
                myCar.Model = "Wrangler";
                myCar.SpeedUp(-3);

                myOtherCar.Make = "Forester";
                myOtherCar.Model = "Subaru";
                myOtherCar.ChangeGear(3);
                myOtherCar.SpeedUp(30);

                List<IVehicle> myVehicles = new List<IVehicle>()
                {
                    myBike, myCar, myOtherCar
                };

                foreach(IVehicle v in myVehicles)
                {
                    //Print 
                    IPrintable myVehicle = null;

                    if(v is Car)
                    {
                        myVehicle = (Car)v;
                    }

                    if (v is Bicycle)
                    {
                        myVehicle = (Bicycle)v;
                    }

                    P("--------------------------------------");
                    if (myVehicle != null)
                        P(myVehicle.Print());
                }
            }
            catch (Exception ex)
            {

                P(ex.Message);
            }

            Console.ReadLine(); // Haults closing
        }

        static void P(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
