using IngredientLib.Util;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static RoastPorkMod.Customs.CookedPorkShoulderWithoutCrackling;

namespace RoastPorkMod.Customs
{
    internal class CracklingItem : CustomItem
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


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.GetChildFromPath("PorkCracklingItem/PorkCracklingItem").ApplyMaterial("Sauce - Mushroom Cooked");
            Prefab.GetChildFromPath("PorkCracklingItem/PorkCracklingItem1").ApplyMaterial("Sauce - Mushroom Cooked");
            Prefab.GetChildFromPath("PorkCracklingItem/PorkCracklingItem2").ApplyMaterial("Sauce - Mushroom Cooked");


            var view = Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo info = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");

            List<GameObject> list = new List<GameObject>()
            {
                Prefab.GetChildFromPath("PorkCracklingItem/PorkCracklingItem2"),
                Prefab.GetChildFromPath("PorkCracklingItem/PorkCracklingItem1"),
            };
            info.SetValue(view, list);
        }
    }
}
