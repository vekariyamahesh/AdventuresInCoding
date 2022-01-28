using AIC.Data.Enums;
using AIC.Data.Models;
using AIC.Data.Populations;

namespace AIC.Sorting
{
    public class SortingCreatures
    {
        public List<Dragon> Dragons;

        public SortingCreatures()
        {
            Dragons = GetDataPopulations.GetDragons();
        }


        public void SortDragonsByName()
        {
            throw new NotImplementedException();
        }
    }
}