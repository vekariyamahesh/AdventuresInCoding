using AIC.Data.Enums;
using AIC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Refactoring
{


    public static class CreatureFunctionality
    {
        public static decimal CalcuateDragonBite(Dragon dragon)
        {

            if (dragon == null) return 0;
            else if (dragon.Type == DragonTypeEnum.Metallic && dragon.DietType == DietTypeEnum.Carnivore) return 5.25M;
            else if (dragon.Type == DragonTypeEnum.Metallic && dragon.DietType == DietTypeEnum.Omnivore) return 3.25M;
            else if (dragon.Type == DragonTypeEnum.Metallic && dragon.DietType == DietTypeEnum.Herbivore) return 1.25M;
            else if (dragon.Type == DragonTypeEnum.Chromatic && dragon.DietType == DietTypeEnum.Carnivore) return 7.75M;
            else if (dragon.Type == DragonTypeEnum.Chromatic && dragon.DietType == DietTypeEnum.Omnivore) return 5.75M;
            else if (dragon.Type == DragonTypeEnum.Chromatic && dragon.DietType == DietTypeEnum.Herbivore) return 3.75M;
            else if (dragon.Type == DragonTypeEnum.Gem && dragon.DietType != DietTypeEnum.Carnivore) return 8.25M;
            else if (dragon.Type == DragonTypeEnum.Gem && dragon.DietType == DietTypeEnum.Carnivore) return 6.25M;
            else if (dragon.Type == DragonTypeEnum.Planar) return 4.5M;
            else return 3M;
        }
    }
}
