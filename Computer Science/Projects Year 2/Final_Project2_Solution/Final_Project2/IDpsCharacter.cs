using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project2
{
    interface IDpsCharacter
    {
        bool AttemptUpgrade(int Something);
        void UpdateCost();
        void UpdateDamage();
    }
}
