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
    internal class CracklingItem : CustomItemGroup
    {
        public override string UniqueNameID => "CracklingItem";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CracklingItem");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override string ColourBlindTag => "C";
        public override Item SplitSubItem => Mod.CracklingPortion;
        public override List<Item> SplitDepletedItems => new() { Mod.CracklingPortion };
        public override int SplitCount => 2;
        public override float SplitSpeed => 3.0f;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 3,
                Min = 3,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.CracklingPortion,
                    Mod.CracklingPortion,
                    Mod.CracklingPortion
                }
            },
        };
        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.GetChild("PorkCracklingItem").ApplyMaterial("Sauce - Mushroom Cooked");
        }
    }
}
