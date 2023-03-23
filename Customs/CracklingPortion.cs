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
    internal class CracklingPortion : CustomItem
    {
        public override string UniqueNameID => "Crackling Portion";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CracklingPortion");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;
        //public override Appliance DedicatedProvider => Mod.FlourTortillaProvider; <- Swapped for ingredient lib so don't need this reference


        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject crackling = Prefab.GetChild("PorkCracklingPortion");
            crackling.ApplyMaterial("Sauce - Mushroom Cooked");
            crackling.GetChild("PorkCracklingPiece").ApplyMaterial("Sauce - Mushroom Cooked");
            crackling.GetChild("PorkCracklingPiece1").ApplyMaterial("Sauce - Mushroom Cooked");
        }
    }
}
