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
using Unity.Entities;
using UnityEngine;

namespace RoastPorkMod.Customs.Pork
{
    internal class CookedPorkShoulderWithoutCrackling : CustomItem
    {
        public override string UniqueNameID => "Cooked Pork Shoulder Without Crackling";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PorkShoulderCookedWithoutCrackling");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 4,
                Process = Mod.Chop,
                IsBad = false,
                Result = Mod.CookedPorkShoulderPortionable
            }
        };
        public override void OnRegister(Item gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Pork1", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork2", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork3", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork4", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork5", "Porkchop Fat", "Porkchop");
            //Prefab.GetChild("Pork5").ApplyMaterialToChild("PorkOtherSide", "Porkchop Fat", "Porkchop");

        }
    }
}

