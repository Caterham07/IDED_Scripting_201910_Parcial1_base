using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_201910_Parcial1_base.Logic
{
    public class Muffler : Part
    {
        public float speedBonus = 50f;
        public Muffler() : base()
        {
            if (level == 1)
            {
                return speedBonus;
            }
            else if (level == 2)
            {
                return speedBonus * 2;
            }
            else if (level == 3)
            {
                return speedBonus * 3;
            }
        }

        public Muffler(float speedBonus) : base(speedBonus)
        {
            if (level >= 0, i = 0, i++)
            {
                return level = +1;
            }
            if (level == 3)
            {
                return ("no more upgrades available");
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.None;
            }
        }
    }
}