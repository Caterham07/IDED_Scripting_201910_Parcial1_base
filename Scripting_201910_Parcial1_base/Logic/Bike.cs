using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_201910_Parcial1_base.Logic
{
    public class Bike : Vehicle
    {
        public float baseMaxSpeed = 100f;
        public Bike() : base()
        {
        }

        public Bike(float _baseMaxSpeed) : base(_baseMaxSpeed)
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