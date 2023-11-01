using IngredientLib;
using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using RoastPorkMod.Customs.Cards;
using RoastPorkMod.Customs.Pork;
using RoastPorkMod.Customs;
using System.Linq;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;

// Namespace should have "Kitchen" in the beginning
namespace KitchenRoastPorkMod
{
    public class Mod : BaseMod, IModSystem
    {
        // GUID must be unique and is recommended to be in reverse domain name notation
        // Mod Name is displayed to the player and listed in the mods menu
        // Mod Version must follow semver notation e.g. "1.2.3"
        public const string MOD_GUID = "Madvion.Plateup.RoastPorkMod";
        public const string MOD_NAME = "Roast Pork Mod";
        public const string MOD_VERSION = "0.2.1";
        public const string MOD_AUTHOR = "Madvion";
        public const string MOD_GAMEVERSION = ">=1.1.4";
        // Game version this mod is designed for in semver
        // e.g. ">=1.1.3" current and all future
        // e.g. ">=1.1.3 <=1.2.3" for all from/until

        // Boolean constant whose value depends on whether you built with DEBUG or RELEASE mode, useful for testing
#if DEBUG
        public const bool DEBUG_MODE = true;
#else
        public const bool DEBUG_MODE = false;
#endif

        public static AssetBundle Bundle;

        internal static Item Plate => GetExistingGDO<Item>(ItemReferences.Plate);
        internal static Item DirtyPlate => GetExistingGDO<Item>(ItemReferences.PlateDirty);
        internal static Item Apple => GetExistingGDO<Item>(ItemReferences.Apple);
        internal static Item ApplesChopped => GetExistingGDO<Item>(ItemReferences.AppleSlices);
        internal static Item Burnt => GetExistingGDO<Item>(ItemReferences.BurnedFood);
        internal static Item Sugar => GetExistingGDO<Item>(ItemReferences.Sugar);
        internal static Item Stuffing => GetExistingGDO<Item>(ItemReferences.Stuffing);
        internal static Item ChoppedMushrooms => GetExistingGDO<Item>(ItemReferences.MushroomChopped);
        internal static Item Mushroom => GetExistingGDO<Item>(ItemReferences.Mushroom);
        internal static Item Onion => GetExistingGDO<Item>(ItemReferences.Onion);
        internal static Item Flour => GetExistingGDO<Item>(ItemReferences.Flour);
        internal static Item Water => GetExistingGDO<Item>(ItemReferences.Water);
        internal static Item Carrots => GetExistingGDO<Item>(ItemReferences.Carrot);








        internal static Process Cook => GetExistingGDO<Process>(ProcessReferences.Cook);

        internal static Process Chop => GetExistingGDO<Process>(ProcessReferences.Chop);

        internal static Process RequireOven => GetExistingGDO<Process>(ProcessReferences.RequireOven);



        internal static Item PorkChop => Find<Item>(IngredientLib.References.GetIngredient("Porkchop"));
        internal static Item Garlic => Find<Item>(IngredientLib.References.GetIngredient("Garlic"));
        internal static Item MincedGarlic => Find<Item>(IngredientLib.References.GetIngredient("Minced Garlic"));




        internal static Item CracklingItem => GetModdedGDO<Item, CracklingItem>();
        internal static Item CracklingPortion => GetModdedGDO<Item, CracklingPortion>();
        internal static Item AppleSauce => GetModdedGDO<Item, AppleSauce>();
        internal static Item GarlicMushroomsCooked => GetModdedGDO<Item, GarlicMushroomsCooked>();
        internal static Item RoastedCarrots => GetModdedGDO<Item, RoastedCarrots>();
        internal static Item SproutsCooked => GetModdedGDO<Item, SproutsCooked>();
        internal static Item SproutsStalk => GetModdedGDO<Item, SproutsStalk>();
        internal static Item SproutsRaw => GetModdedGDO<Item, SproutsRaw>();







        internal static ItemGroup PlatedPorkChop => GetModdedGDO<ItemGroup, PlatedPorkChop>();
        internal static ItemGroup PlatedPorkChopWithToppings => GetModdedGDO<ItemGroup, PlatedPorkChopWithToppings>();

        internal static Item CookedPorkShoulder => GetModdedGDO<Item, CookedPorkShoulder>();
        internal static Item CookedPorkShoulderWithoutCrackling => GetModdedGDO<Item, CookedPorkShoulderWithoutCrackling>();
        internal static Item CookedPorkShoulderPortionable => GetModdedGDO<Item, CookedPorkShoulderPortionable>();

        internal static Item PorkShoulder => GetModdedGDO<Item, PorkShoulder>();

        internal static Appliance PorkShoulderProvider => GetModdedGDO<Appliance, PorkShoulderProvider>();
        internal static Appliance SproutsStalkProvider => GetModdedGDO<Appliance, SproutStalkProvider>();

        internal static Dish CracklingStarter => GetModdedGDO<Dish, CracklingStarterDish>();
        internal static Dish PorkDish => GetModdedGDO<Dish, PorkDish>();
        internal static Dish PorkDishWithToppings => GetModdedGDO<Dish, PorkDishWithToppings>();








        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        private void AddGameData()
        {
            LogInfo("Attempting to register game data...");

            AddGameDataObject<AppleSauce>();
            AddGameDataObject<CookedPorkShoulder>();
            AddGameDataObject<CracklingItem>();
            AddGameDataObject<CracklingPortion>();
            AddGameDataObject<PlatedPorkChop>();
            AddGameDataObject<PlatedPorkChopWithToppings>();
            AddGameDataObject<PorkShoulder>();
            AddGameDataObject<PorkShoulderProvider>();
            AddGameDataObject<CracklingStarterDish>();
            AddGameDataObject<PorkDish>();
            AddGameDataObject<PorkDishWithToppings>();
            AddGameDataObject<CookedPorkShoulderWithoutCrackling>();
            AddGameDataObject<CookedPorkShoulderPortionable>();
            AddGameDataObject<PorkDishWithGarlicMushrooms>();
            AddGameDataObject<PorkDishWithStuffing>();
            AddGameDataObject<RoastCarrotsSide>();
            AddGameDataObject<SproutSide>();
            AddGameDataObject<SproutStalkProvider>();

            AddGameDataObject<GarlicMushroomsCooked>();
            AddGameDataObject<GarlicMushroomsRaw>();
            AddGameDataObject<RoastedCarrots>();
            AddGameDataObject<SproutsCooked>();
            AddGameDataObject<SproutsRaw>();
            AddGameDataObject<SproutsStalk>();



            LogInfo("Done loading game data.");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            // TODO: Uncomment the following if you have an asset bundle.
            // TODO: Also, make sure to set EnableAssetBundleDeploy to 'true' in your ModName.csproj

            LogInfo("Attempting to load asset bundle...");
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).First();
            LogInfo("Done loading asset bundle.");

            // Register custom GDOs
            AddGameData();

            // Perform actions when game data is built
            Events.BuildGameDataEvent += delegate (object s, BuildGameDataEventArgs args)
            {
                
                Item carrots = args.gamedata.Get<Item>(ItemReferences.Carrot);
                Item.ItemProcess proc = new Item.ItemProcess
                {
                    Duration = 3,
                    Process = Mod.Cook,
                    IsBad = false,
                    Result = Mod.RoastedCarrots,
                };
                carrots.DerivedProcesses.Add(proc);
                
            };
        }

        private static T1 GetModdedGDO<T1, T2>() where T1 : GameDataObject
        {
            return (T1)GDOUtils.GetCustomGameDataObject<T2>().GameDataObject;
        }
        private static T GetExistingGDO<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id);
        }
        internal static T Find<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
        }

        internal static T Find<T, C>() where T : GameDataObject where C : CustomGameDataObject
        {
            return GDOUtils.GetCastedGDO<T, C>();
        }

        internal static T Find<T>(string modName, string name) where T : GameDataObject
        {
            return GDOUtils.GetCastedGDO<T>(modName, name);
        }
        #region Logging
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        public static void LogWarning(string _log) { Debug.LogWarning($"[{MOD_NAME}] " + _log); }
        public static void LogError(string _log) { Debug.LogError($"[{MOD_NAME}] " + _log); }
        public static void LogInfo(object _log) { LogInfo(_log.ToString()); }
        public static void LogWarning(object _log) { LogWarning(_log.ToString()); }
        public static void LogError(object _log) { LogError(_log.ToString()); }
        #endregion
    }
}
