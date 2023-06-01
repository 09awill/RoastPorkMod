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
    internal class GarlicMushroomsRaw : CustomItemGroup
    {
        public override string UniqueNameID => "Garlic Mushrooms Raw";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GarlicMushroomsRaw"); // Make model
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.SideMedium;
        //public override Appliance DedicatedProvider => Mod.FlourTortillaProvider; <- Swapped for ingredient lib so don't need this reference
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 2,
                Min = 2,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.ChoppedMushrooms,
                    Mod.MincedGarlic
                }
            },
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 3,
                Process = Mod.Cook,
                IsBad = false,
                Result = Mod.GarlicMushroomsCooked
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            GameObject mushrooms = Prefab.GetChild("Mushrooms");
            for (int i = 1; i < 4; i++)
            {
                mushrooms.ApplyMaterialToChild($"mushroomHalf ({i})/mushroomHalf", "Mushroom Dark", "Mushroom Light");
            }
            GameObject herbs = Prefab.GetChild("Herbs");
            for (int i = 0; i < 8; i++)
            {
                herbs.ApplyMaterialToChild($"Cube ({i})", "Clothing Green");
            }

        }
    }
}
