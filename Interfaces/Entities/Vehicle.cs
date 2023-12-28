using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    internal class Vehicle
    {
        public String Model { get; set; }

        public Vehicle() { }

        public Vehicle(String model)
        {
            Model = model;
        }
    }
}
