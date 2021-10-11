using System.Collections.Generic;
using Verse;
using RimWorld;

namespace ButcherCounters
{
    public class RecipeWorkerCounter_ButcherAnimalsBase : Verse.RecipeWorkerCounter_ButcherAnimals
    {
        public virtual MeatSourceCategory MeatSourceCategory { get; }

        public override int CountProducts(Bill_Production bill)
        {
            int num = 0;
            List<ThingDef> childThingDefs = ThingCategoryDefOf.MeatRaw.childThingDefs;
            for (int i = 0; i < childThingDefs.Count; i++)
            {
                if (FoodUtility.GetMeatSourceCategory(childThingDefs[i]) == this.MeatSourceCategory)
                    num += bill.Map.resourceCounter.GetCount(childThingDefs[i]);
            }
            return num;
        }
    }

    public class RecipeWorkerCounter_ButcherAnimals : RecipeWorkerCounter_ButcherAnimalsBase
    {
        public override MeatSourceCategory MeatSourceCategory => MeatSourceCategory.Undefined;
    }

    public class RecipeWorkerCounter_ButcherHumans : RecipeWorkerCounter_ButcherAnimalsBase
    {
        public override MeatSourceCategory MeatSourceCategory => MeatSourceCategory.Humanlike;
    }

    public class RecipeWorkerCounter_ButcherInsects : RecipeWorkerCounter_ButcherAnimalsBase
    {
        public override MeatSourceCategory MeatSourceCategory => MeatSourceCategory.Insect;
    }

}
