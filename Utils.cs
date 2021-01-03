using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod
{
    class Utils
    {
        public static double speedChange = 0.0001;
        public static double fuelConsumption = 0.01;
        public static double engineDamage = 0.005;
        public static double maxVelocity = 100;
        public static int slowSystem = 100;

        public static String CAR_NAME_VALUE = "Name: {0}";
        public static String CAR_VELOCITY_VALUE = "Velocity: {0}";
        public static String CAR_PETROL_VALUE = "Petrol: {0}";
        public static String CAR_STATUS_VALUE = "Status: {0}";
        public static String CAR_DMG_VALUE = "Engine Damage: {0}";
        public static String CAR_DRIVING_DISTANCE_VALUE = "Driving Distanvce: {0}";
        public enum CarStatus {
            engineOn = 0,
            engineOff = 1,
            carStop = 2,
            acceleration = 3,
            releasing = 4,
            constSpeed = 5
        }
    }
}
