﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Abstract Vehicle class, contains an empty constructor and the virtual Price and VehicleType methods
    /// </summary>
    public abstract class Vehicle
    {
        protected Vehicle(string licensePlate)
        {
            if (licensePlate.Length > 7)
            {
                throw new Exception("License plate cannot be longer than 7 characters.");
            }
        }

        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle
        /// </summary>
        /// <returns>double</returns>
        public virtual double Price()
        {
            return 200;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>string</returns>
        public virtual string VehicleType()
        {
            return "Not assigned";
        }
    }
}