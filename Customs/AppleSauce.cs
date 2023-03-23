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
    internal class AppleSauce : CustomItem
    {
        public override string UniqueNameID => "AppleSauce";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("AppleSauce");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;
        //public override Appliance DedicatedProvider => Mod.FlourTortillaProvider; <- Swapped for ingredient lib so don't need this reference


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Material[] mats = new Material[] { MaterialUtils.GetExistingMaterial("Wood 1") };
            Prefab.GetChild("Bowl").ApplyMaterial(mats);
            mats = new Material[] { MaterialUtils.GetExistingMaterial("Plastic - Orange") };
            Prefab.GetChild("Sauce").ApplyMaterial(mats);

        }
    }
}
