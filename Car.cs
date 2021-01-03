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

		public Boolean checkEngineStatus()
		{
			if (engineDMG > 70) {
				this.checkEngine = true;
			}

			return checkEngine;
		}


		public void increateSpeed() {

			if (velocity < Utils.maxVelocity && gear > 0) {
				velocity += Utils.speedChange;
			}

			setDistance();
		}

		public void setDistance()
		{
			if (velocity != 0)
			{
				drivingDistance += velocity;
			}
		}

		public void reducingSpeed()
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

		public void needToChangeGear()
		{

			if(velocity < 5 && gear == 0) {
				return;
            }
			
			if (velocity > Utils.gearRange[0,0] && velocity < Utils.gearRange[0,1] && gear == 1) {
				return;
			} 
			
			if (velocity > Utils.gearRange[1, 0] && velocity < Utils.gearRange[1, 1] && gear == 2) {
				return;
			}

			if (velocity > Utils.gearRange[2, 0] && velocity < Utils.gearRange[2, 1] && gear == 3) {
				return;
			}

			if (velocity > Utils.gearRange[3, 0] && velocity < Utils.gearRange[3, 1] && gear == 4) {
				return;
			}

			if (velocity > Utils.gearRange[4, 0] && velocity <= Utils.gearRange[4, 1] && gear == 5) {
				return;
			}

			engineDMG += Utils.engineDamage;
		}

		public Enum getStatus()
        {
			return carStatus;
        }
	}
}
