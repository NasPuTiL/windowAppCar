using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod
{
    class Utils
    {
        public static double speedChange = 1;
        public static double fuelConsumption = 0.01;
        public static double engineDamage = 1;
        public static double maxVelocity = 100;
        public static int slowSystem = 100;

        public static String CAR_NAME_VALUE = "Name: {0}";
        public static String CAR_VELOCITY_VALUE = "Velocity: {0}";
        public static String CAR_PETROL_VALUE = "Petrol: {0}";
        public static String CAR_STATUS_VALUE = "Status: {0}";
        public static String CAR_DMG_VALUE = "Engine Damage: {0}";
        public static String CAR_ENGINE_SPEED_VALUE = "Engine Speed: {0}";
        public static String CAR_GEAR_VALUE = "Gear: {0}";
        public static String CAR_DRIVING_DISTANCE_VALUE = "Driving Distanvce: {0}";
        public static String CAR_CHECK_ENGINE_MSG = "Check Engine Light is on in Your Car";
        public static String CAR_LEVEL_OF_FUEL_MSG = "Low level of fuel in Your car";
        public enum CarStatus {
            engineOn = 0,
            engineOff = 1,
            carStop = 2,
            acceleration = 3,
            releasing = 4,
            constSpeed = 5
        }


        public static int[,] gearRange = new int[,] { { 0, 30 }, { 12, 40 }, { 25, 60 }, { 35, 70}, { 45, 100 } };

    }
}
