using IngredientLib.Util;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RoastPorkMod.Customs
{
    internal class PlatedPorkChopWithToppings : CustomItemGroup
    {
        public override string UniqueNameID => "Plated Pork Chop With Toppings";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedPorkWithTopping");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
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
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Mod.AppleSauce,
                }
            },
        };
        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.GetChildFromPath("Plate/Plate").ApplyMaterial("Plate");
            Prefab.GetChildFromPath("Plate/Plate/Cylinder").ApplyMaterial("Plate - Ring");
            Prefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");
            Material[] mats = new Material[] { MaterialUtils.GetExistingMaterial("Apple Cooked") };
            Prefab.GetChild("AppleSauce").ApplyMaterial(mats);
        }
    }
}
