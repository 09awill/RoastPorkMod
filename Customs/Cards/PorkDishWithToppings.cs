using IngredientLib.Util;
using KitchenData;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using RoastPorkMod.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RoastPorkMod.Customs.Cards
{
    internal class PorkDishWithToppings : ModDish
    {
        public override string UniqueNameID => "Pork Dish With Toppings";
        public override DishType Type => DishType.Extra;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Mod.PorkDish
        };
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedPorkChopWithToppings,
                Phase = MenuPhase.Main,
                Weight = 1,
            }
        };

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.AppleSauce,
                MenuItem = Mod.PlatedPorkChop
            },
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate,
            Mod.Apple
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Chop apples, then chop again to make sauce, add to plated pork" }
        };
        public override IDictionary<Locale, UnlockInfo> LocalisedInfo => new Dictionary<Locale, UnlockInfo>
        {
            { Locale.English, LocalisationUtils.CreateUnlockInfo("Apple Sauce", "Adds apple sauce as a topping to pork", "What is pork without apple sauce?") }
        };
    }
}
