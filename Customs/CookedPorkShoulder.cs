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
    internal class CookedPorkShoulder : CustomItemGroup
    {
        public override string UniqueNameID => "Cooked Pork Shoulder";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PorkShoulderCooked");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override Item SplitSubItem => Mod.CracklingItem;
        public override List<Item> SplitDepletedItems => new() { Mod.CookedPorkShoulderWithoutCrackling};
        public override int SplitCount => 1;
        public override float SplitSpeed => 3.0f;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 10,
                Process = Mod.Cook,
                IsBad = true,
                Result = Mod.Burnt
            }
        };
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 2,
                Min = 2,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.CookedPorkShoulderWithoutCrackling,
                    Mod.CracklingItem,
                }
            },
        };
        public override void OnRegister(GameDataObject gameDataObject)
        {
            //third one should be string

            //New Testing
            GameObject go = Prefab.GetChild("PorkShoulderCookedNew");
            go.ApplyMaterial("Sauce - Mushroom Cooked", "Porkchop", "Porkchop Fat");
            go.GetChild("Pork").ApplyMaterial("Porkchop Fat", "Porkchop");
            go.GetChild("Pork2").ApplyMaterial("Porkchop Fat", "Porkchop");


            /* Old
            GameObject go = Prefab.GetChild("PorkShoulderCooked");
            go.ApplyMaterial("Sauce - Mushroom Cooked", "Porkchop", "Porkchop Fat");
            go.GetChild("PorkMarbling").ApplyMaterial("Porkchop Fat");
            go.GetChild("PorkMarbling1").ApplyMaterial("Porkchop Fat");
            */
        }
    }
}
