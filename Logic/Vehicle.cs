using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        private float baseMaxSpeed = 50f;

        private int Level { get; set; }
        public VehicleType Car { get => Car; set => Get = value; }

        private abstract VehicleType Get { ; }

        public Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return speedBonus;
            }
        }

        public Vehicle()
        {
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (Type == part.Type || part.Type == VehicleType.Any)
            {
                return ("part equipped");
            }

            return result;
        }

        public void Upgrade()
        {
        }
    }
}