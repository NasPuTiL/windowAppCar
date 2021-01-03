using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod
{
	public class Car
	{
		public int gear { get; set; }
		public double velocity { get; set; }
		public double petrolLevel { get; set; }
		public Boolean checkEngine { get; set; }
		public double engineDMG { get; set; }
		public double drivingDistance { get; set; }
		public Enum carStatus { get; set; }
		public String name { get; set; }

		public Car(String name)
		{
			this.gear = 0;
			this.velocity = 0;
			this.petrolLevel = 100;
			this.checkEngine = false;
			this.drivingDistance = 0;
			this.carStatus = Utils.CarStatus.engineOff;
			this.engineDMG = 0;
			this.name = name;
		}

		public Car()
		{
			this.gear = 0;
			this.velocity = 0;
			this.petrolLevel = 100;
			this.checkEngine = false;
			this.drivingDistance = 0;
			this.carStatus = Utils.CarStatus.engineOff;
			this.engineDMG = 0;
			this.name = "TEST";
		}

		public Boolean getEngineStatus()
		{
			if (engineDMG > 70) {
				this.checkEngine = true;
			}

			return checkEngine;
		}


		private void increateSpeed()
		{
			if (velocity < Utils.maxVelocity)
			{
				velocity += Utils.speedChange;
			}

			setDistance();
		}

		private void setDistance()
		{
			if (velocity != 0)
			{
				drivingDistance += velocity / 2;
			}
		}

		private void reducingSpeed()
		{
			if (velocity > 0)
			{
				velocity -= Utils.speedChange;
			}

			setDistance();
		}

		public void fuelConsumption(double x){
			petrolLevel -= x*Utils.fuelConsumption;
		}

		public void fuelConsumption()
		{
			fuelConsumption(1);
		}

		public Boolean needToChangeGear()
		{
			if (velocity > 20 && gear != 1) {
				engineDMG += Utils.engineDamage;
				return true;
			} 
			
			if (velocity < 20 || velocity > 42 && gear != 2) {
				engineDMG += Utils.engineDamage;
				return true;
			}

			if (velocity < 40 || velocity > 62 && gear != 3)
			{
				engineDMG += Utils.engineDamage;
				return true;
			}

			if (velocity < 60 || velocity > 82 && gear != 4)
			{
				engineDMG += Utils.engineDamage;
				return true;
			}

			if (velocity < 80 || velocity > 100 && gear != 5)
			{
				engineDMG += Utils.engineDamage;
				return true;
			}

			return false;
		}

		public Enum getStatus()
        {
			return carStatus;
        }
	}
}
