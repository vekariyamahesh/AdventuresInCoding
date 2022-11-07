using AIC.Data.Enums;
using AIC.Data.Models;
using Xunit;

namespace AIC.Refactoring.Tests
{
    public class RefactorTest
    {
        [Fact]
        public void CheckMetalicDragonBite()
        {
            var metallicDragon = (Dragon?)CreatureFactory.AdoptACreature("dragon");

            Assert.NotNull(metallicDragon);            
            metallicDragon.Type = DragonTypeEnum.Metallic;
            metallicDragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(5.25M,CreatureFunctionality.CalcuateDragonBite(metallicDragon));
            metallicDragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(3.25M, CreatureFunctionality.CalcuateDragonBite(metallicDragon));
            metallicDragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(1.25M, CreatureFunctionality.CalcuateDragonBite(metallicDragon));
        }

        [Fact]
        public void CheckChromaticDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Chromatic;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(7.75M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(5.75M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(3.75M, CreatureFunctionality.CalcuateDragonBite(dragon));
        }

        [Fact]
        public void CheckGemDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Gem;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(6.25M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(8.25M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(8.25M, CreatureFunctionality.CalcuateDragonBite(dragon));
        }

        [Fact]
        public void CheckPlanarDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Planar;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(4.5M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(4.5M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(4.5M, CreatureFunctionality.CalcuateDragonBite(dragon));
        }

        [Fact]
        public void CheckOtherDragonBite()
        {
            var dragon = (Dragon)CreatureFactory.AdoptACreature("dragon");
            dragon.Type = DragonTypeEnum.Other;
            dragon.DietType = DietTypeEnum.Carnivore;
            Assert.Equal(3M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Omnivore;
            Assert.Equal(3M, CreatureFunctionality.CalcuateDragonBite(dragon));
            dragon.DietType = DietTypeEnum.Herbivore;
            Assert.Equal(3M, CreatureFunctionality.CalcuateDragonBite(dragon));
        }

        [Fact]
        public void CheckInvalidCreature()
        {
            var blah = CreatureFactory.AdoptACreature("blah");
            Assert.NotNull(blah);
            Assert.IsType<Creature>(blah);
        }

        [Fact]
        public void CheckEmptyCreature()
        {
            var blah = CreatureFactory.AdoptACreature(string.Empty);
            Assert.Null(blah);
        }

        [Fact]
        public void CheckNullCreature()
        {
            var blah = CreatureFactory.AdoptACreature(null);
            Assert.Null(blah);
        }
    }
}
