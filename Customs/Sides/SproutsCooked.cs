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
    internal class SproutsCooked : CustomItem
    {
        public override string UniqueNameID => "Sprouts Cooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SproutsCooked"); // Make model
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.SideMedium;
        public override bool IsMergeableSide => true;
        public override string ColourBlindTag => "Sp";
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 6,
                Process = Mod.Cook,
                IsBad = true,
                Result = Mod.Burnt
            }
        };

        public override void OnRegister(Item gameDataObject)
        {
            for (int i = 1; i < 3; i++)
            {
                Prefab.ApplyMaterialToChild($"Ice Cream ({i})", "Rug - Dark Green");
            }
        }
    }
}
