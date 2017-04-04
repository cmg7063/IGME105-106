using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
	class Vehicle
	{
		// Fields
		protected String name;

		// Constructor
		public Vehicle(String name)
		{
			this.name = name;
		}

		// Drive method
		// "virtual" means we can override later if we want
		public virtual void Drive()
		{
			Console.WriteLine(name + ": VEHICLE is driving");
		}

		// Stop method
		// Can not be overridden since it's not virtual
		public void Stop()
		{
			Console.WriteLine(name + ": VEHICLE has stopped");
		}
	}
}
