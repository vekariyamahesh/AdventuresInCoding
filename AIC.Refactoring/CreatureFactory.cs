using AIC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Refactoring
{
    public static class CreatureFactory
    {
        public static object? AdoptACreature(string creatureName)
        {
            if (creatureName == null)
            {
                return default;
            }
            else if (creatureName == "dragon")
            {
                return new Dragon();
            }
            else if (creatureName == "unicorn")
            {
                return new Unicorn();
            }
            else
            {
                return new Creature();
            }
        }
    }
}
