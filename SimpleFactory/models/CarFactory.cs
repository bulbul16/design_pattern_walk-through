using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.models
{
	public class CarFactory
	{
		public Car GetCar(string carType = "FourSeater")
		{
			Car car = null;

			switch (carType)
			{
				case "FourSeater":
					car = new FourSeaterCar();
					break;
				case "SixSeater":
					car = new SixSeaterCar();
					break;
			}
			car.Manufacture();
			return car;

		}
	}
}
