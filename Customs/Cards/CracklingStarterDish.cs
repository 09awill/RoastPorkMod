using KitchenData;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using RoastPorkMod.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastPorkMod.Customs.Cards
{
    internal class CracklingStarterDish : ModDish
    {
        public override string UniqueNameID => "Crackling Starter";
        public override DishType Type => DishType.Starter;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsUnlockable => true;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Mod.PorkDish
        };

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
               Item = Mod.CracklingPortion,
               Phase = MenuPhase.Starter,
               Weight = 1
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.PorkShoulder,
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Cook Pork Shoulder then take off the crackling, then portion and serve" }
        };
        public override IDictionary<Locale, UnlockInfo> LocalisedInfo => new Dictionary<Locale, UnlockInfo>
        {
            { Locale.English, LocalisationUtils.CreateUnlockInfo("Crackling Starter", "Customers can request crackling as a starter", "Mmm Crunchy") }
        };
    }
}
