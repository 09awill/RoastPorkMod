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
    internal class SproutsRaw : CustomItem
    {
        public override string UniqueNameID => "Sprouts Raw";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SproutsRaw"); // Make model
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.SideMedium;
        //public override Appliance DedicatedProvider => Mod.FlourTortillaProvider; <- Swapped for ingredient lib so don't need this reference

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 3,
                Process = Mod.Cook,
                IsBad = false,
                Result = Mod.SproutsCooked
            }
        };
        public override void OnRegister(Item gameDataObject)
        {
            for (int i = 1; i < 3; i++)
            {
                Prefab.ApplyMaterialToChild($"Ice Cream ({i})", "Clothing Green");
            }
            Prefab.ApplyMaterialToChild("BreadcrumbsBowl/Cylinder", "Metal Dark");
        }
    }
}
