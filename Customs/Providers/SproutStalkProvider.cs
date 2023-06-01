using Kitchen.Components;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using UnityEngine;

namespace RoastPorkMod.Customs
{
    internal class SproutStalkProvider : CustomAppliance
    {
        public override string UniqueNameID => "Sprouts Stalk Provider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Provider - Sprouts");
        public override PriceTier PriceTier => PriceTier.Medium;
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateApplianceInfo("Sprouts Stalk Provider", "Provides Sprouts", new(), new()) )
        };

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>()
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(Mod.SproutsStalk.ID)
        };
        public override void OnRegister(Appliance gameDataObject)
        {
            GameObject genericStorage = Prefab.GetChild("GenericStorage");
            genericStorage.ApplyMaterialToChild("Cube", "Wood - Default");
            genericStorage.ApplyMaterialToChild("Cube.002", "Wood - Default");
            genericStorage.ApplyMaterialToChild("Cube.003", "Wood - Default");
            GameObject sproutsStalk = Prefab.GetChild("SproutsStalk");
            GameObject sproutsStalk1 = Prefab.GetChild("SproutsStalk (1)");

            for (int i = 1; i < 6; i++)
            {
                sproutsStalk.ApplyMaterialToChild($"Ice Cream ({i})", "Rug - Dark Green");
                sproutsStalk1.ApplyMaterialToChild($"Ice Cream ({i})", "Rug - Dark Green");
            }
            sproutsStalk.ApplyMaterialToChild("Cylinder", "Clothing Green");
            sproutsStalk1.ApplyMaterialToChild("Cylinder", "Clothing Green");




        }
    }
}
