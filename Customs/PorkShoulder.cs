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
    internal class PorkShoulder : CustomItem
    {
        public override string UniqueNameID => "PorkShoulder";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PorkShoulder");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override Appliance DedicatedProvider => Mod.PorkShoulderProvider;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 15,
                Process = Mod.Cook,
                Result = Mod.CookedPorkShoulder
            }
        };

        public override void OnRegister(Item gameDataObject)
        {
            GameObject go = Prefab.GetChild("PorkShoulder");
            go.ApplyMaterial("Pork Fat", "Pork", "Plastic - Black Dark");
            go.ApplyMaterialToChild("PorkMarbling", "Pork Fat");
            go.ApplyMaterialToChild("PorkMarbling1", "Pork Fat");
        }
    }
}
