using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Make a vehicle
			Vehicle basicVehicle = new Vehicle("Basic Vehicle");
			basicVehicle.Drive();
			basicVehicle.Stop();

			Console.WriteLine(); // Spacing

			// Make a tank
			Tank basicTank = new Tank("Basic Tank");
			basicTank.Drive();
			basicTank.Stop();
			basicTank.Shoot();

			// Spacing
			Console.WriteLine();

			// Make a tank, but store in
			// a vehicle variable (POLYMORPHISM)
			Vehicle anything = new Tank("Advanced Tank");
			anything.Drive();
			anything.Stop();

			// I want this tank to shoot, but 
			// "Vehicle" doesn't have that method.
			// I need to cast it back
			if (anything is Tank)
			{
				Tank actuallyATank = (Tank)anything;
				actuallyATank.Shoot();
			}
		}
	}
}
