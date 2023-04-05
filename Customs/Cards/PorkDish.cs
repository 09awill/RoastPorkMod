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
using Unity.Entities;
using UnityEngine;

namespace RoastPorkMod.Customs.Cards
{
    internal class PorkDish : ModDish
    {
        public override string UniqueNameID => "Pork Dish";
        public override DishType Type => DishType.Base;
        public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("PlatedPorkIcon");
        public override GameObject IconPrefab => DisplayPrefab;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Large;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsSpecificFranchiseTier => false;
        public override bool IsAvailableAsLobbyOption => true;

        public override List<string> StartingNameSet => new()
        {
            "Hogwash",
            "Ground Hog Day",
            "Swine and Dine",
            "Piggie Smalls",
            "The Chop Shop",
            "The Pig and Pickle",
            "Bacon Me Crazy",
            "Boar-ing Kitchen",
            "Quit Hogging The Stove"

        };
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedPorkChop,
                Phase = MenuPhase.Main,
                Weight = 1,
            }
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Cook Pork Shoulder then take off the crackling, then portion cooked shoulder into steaks, plate up and serve!" }
        };
        public override IDictionary<Locale, UnlockInfo> LocalisedInfo => new Dictionary<Locale, UnlockInfo>
        {
            { Locale.English, LocalisationUtils.CreateUnlockInfo("Pork", "Adds Pork as a Main", "Delicious Pork") }
        };

        public override void OnRegister(GameDataObject gameDataObject)
        {
            DisplayPrefab.GetChildFromPath("Plate/Plate/Cylinder").ApplyMaterial("Plate", "Plate - Ring");
            DisplayPrefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");
        }
    }
}
