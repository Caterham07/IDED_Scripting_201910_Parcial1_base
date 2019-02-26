using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_201910_Parcial1_base.Logic
{
    public class Car : Vehicle
    {
        public float baseMaxSpeed = 200f;
        public Car() : base()
        {
        }

        public Car(float _baseMaxSpeed) : base(_baseMaxSpeed)
        {
        }

        protected override VehicleType Type
        {
            get
            {
                return VehicleType.None;
            }
        }
    }
}