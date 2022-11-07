using AIC.Data.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AIC.Refactoring
{
    public static class CreatureFactory
    {
        public static object? AdoptACreature(string creatureName)
        {
            if (creatureName == null || string.IsNullOrEmpty(creatureName))
            {
                return default;
            }
            try
            {
                var typeMap = typeof(Creature).Assembly.GetTypes().Where(t => t.Namespace == typeof(Creature).Namespace)
                          .ToDictionary(t => t.Name, t => t,
                                        StringComparer.OrdinalIgnoreCase);

                Type type;
                if (typeMap.TryGetValue(creatureName, out type))
                {
                    return Activator.CreateInstance(type);
                }
                else
                {
                    return new Creature();
                }
            }
            catch
            {

                return new Creature();
            }

        }
    }
}
