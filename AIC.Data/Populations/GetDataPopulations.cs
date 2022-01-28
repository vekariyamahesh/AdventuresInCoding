using AIC.Data.Enums;
using AIC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Data.Populations
{
    public static class GetDataPopulations
    {
        public static List<Dragon> GetDragons()
        {
            return new List<Dragon>()
            {
                new Dragon{Name="Klauth", Description="Large Red Dragon", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Chromatic},
                new Dragon{Name="Arauthator", Description="White Dragon", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Chromatic},
                new Dragon{Name="Borys", Description="Dragon King of Ur", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Chromatic},
                new Dragon{Name="Bahamut", Description="Boss of the good dragons", DietType=DietTypeEnum.Omnivore, Type = DragonTypeEnum.Metallic},
                new Dragon{Name="Aaronarra", Description="random dragon from the internet", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Metallic},
                new Dragon{Name="Dragon Lord", Description="The OG from Dragon Quest 1", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Chromatic},
                new Dragon{Name="Astanalan", Description="running out of actual named dragons", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Gem},
                new Dragon{Name="Eormennoth", Description="another rando", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Metallic},
                new Dragon{Name="Malaeragoth", Description="found on a wiki", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Gem},
                new Dragon{Name="Umbraxakar", Description="Shadowish Dragon", DietType=DietTypeEnum.Carnivore, Type = DragonTypeEnum.Planar}
            };
        }
    }
}
