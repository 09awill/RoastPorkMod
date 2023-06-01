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

namespace RoastPorkMod.Customs.Pork
{
    internal class SproutsStalk : CustomItem
    {
        public override string UniqueNameID => "Sprouts Stalk";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SproutsStalk"); // Make model
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.SideMedium;
        public override Appliance DedicatedProvider => Mod.SproutsStalkProvider;
        public override Item SplitSubItem => Mod.SproutsRaw;
        public override List<Item> SplitDepletedItems => new() { Mod.SproutsRaw };
        public override int SplitCount => 1;
        public override float SplitSpeed => 3.0f;

        public override void OnRegister(Item gameDataObject)
        {
            for (int i = 1; i < 6; i++)
            {
                Prefab.ApplyMaterialToChild($"Ice Cream ({i})", "Rug - Dark Green");
            }
            Prefab.ApplyMaterialToChild("Cylinder", "Clothing Green");

        }
    }
}
