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
    internal class AppleSauce : CustomItemGroup
    {
        public override string UniqueNameID => "AppleSauce";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("AppleSauce");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override string ColourBlindTag => "AS";

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 2,
                Min = 2,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.ApplesChopped,
                    Mod.Sugar
                }
            },
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            Material[] mats = new Material[] { MaterialUtils.GetExistingMaterial("Wood 1") };
            Prefab.GetChild("Bowl").ApplyMaterial(mats);
            mats = new Material[] { MaterialUtils.GetExistingMaterial("Plastic - Orange") };
            Prefab.GetChild("Sauce").ApplyMaterial(mats);

        }
    }
}
