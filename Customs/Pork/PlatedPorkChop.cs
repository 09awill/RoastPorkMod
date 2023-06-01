using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;
using UnityEngine;

namespace RoastPorkMod.Customs.Pork
{
    internal class PlatedPorkChop : CustomItemGroup
    {
        public override string UniqueNameID => "Plated Pork Chop";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedPork");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override Item DisposesTo => Mod.Plate;
        public override Item DirtiesTo => Mod.DirtyPlate;
        public override string ColourBlindTag => "P";
        public override bool CanContainSide => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 2,
                Min = 2,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.PorkChop,
                    Mod.Plate
                }
            },
        };
        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.GetChild("Plate/Plate/Cylinder").ApplyMaterial("Plate", "Plate - Ring");
            Prefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");


        }
    }
}
