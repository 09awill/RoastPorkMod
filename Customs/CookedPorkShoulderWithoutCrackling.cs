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
    internal class CookedPorkShoulderWithoutCrackling : CustomItemGroup
    {
        public override string UniqueNameID => "Cooked Pork Shoulder Without Crackling";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PorkShoulderCookedWithoutCrackling");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override Item SplitSubItem => Mod.PorkChop;
        public override List<Item> SplitDepletedItems => new() { Mod.PorkChop };
        public override int SplitCount => 4;
        public override float SplitSpeed => 3.0f;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 5,
                Min = 5,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.PorkChop,
                    Mod.PorkChop,
                    Mod.PorkChop,
                    Mod.PorkChop,
                    Mod.PorkChop,
                }
            },
        };
        public override void OnRegister(GameDataObject gameDataObject)
        {               
            Prefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork1", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork2", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork3", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork4", "Porkchop Fat", "Porkchop");


        }
    }
}
