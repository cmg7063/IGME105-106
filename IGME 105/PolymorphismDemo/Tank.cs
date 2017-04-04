using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
	class Tank : Vehicle
	{

		// Constructor to pass data to
		// the parent's constructor
		public Tank(String name)
			: base(name)
		{ }

		// Override the parent's drive method
		public override void Drive()
		{
			Console.WriteLine(name + ": TANK is driving");
		}

		// Shoot method
		// This only exists in this class (not in the parent)
		public void Shoot()
		{
			Console.WriteLine(name + ": TANK is shooting");
		}

	}
}
