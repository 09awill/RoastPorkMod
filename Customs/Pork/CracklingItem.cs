using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace RoastPorkMod.Customs.Pork
{
    internal class CracklingItem : CustomItem
    {
        public override string UniqueNameID => "CracklingItem";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CracklingItem");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override string ColourBlindTag => "C";
        public override Item SplitSubItem => Mod.CracklingPortion;
        public override List<Item> SplitDepletedItems => new() { Mod.CracklingPortion };
        public override int SplitCount => 2;
        public override float SplitSpeed => 3.0f;


        public override void OnRegister(Item gameDataObject)
        {
            Prefab.GetChild("PorkCracklingItem/PorkCracklingItem").ApplyMaterial("Sauce - Mushroom Cooked");
            Prefab.GetChild("PorkCracklingItem/PorkCracklingItem1").ApplyMaterial("Sauce - Mushroom Cooked");
            Prefab.GetChild("PorkCracklingItem/PorkCracklingItem2").ApplyMaterial("Sauce - Mushroom Cooked");


            var view = Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo info = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");

            List<GameObject> list = new List<GameObject>()
            {
                Prefab.GetChild("PorkCracklingItem/PorkCracklingItem2"),
                Prefab.GetChild("PorkCracklingItem/PorkCracklingItem1"),
            };
            info.SetValue(view, list);
        }
    }
}
