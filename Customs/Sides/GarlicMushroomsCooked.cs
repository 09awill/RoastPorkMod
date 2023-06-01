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
    internal class GarlicMushroomsCooked : CustomItem
    {
        public override string UniqueNameID => "Garlic Mushrooms Cooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GarlicMushroomsCooked"); // Make model
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.SideMedium;
        //public override Appliance DedicatedProvider => Mod.FlourTortillaProvider; <- Swapped for ingredient lib so don't need this reference
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
            GameObject Mushrooms = Prefab.GetChild("Mushrooms");
            for (int i = 1; i < 4; i++)
            {
                Mushrooms.ApplyMaterialToChild($"mushroomHalf ({i})/mushroomHalf", "Mushroom Cooked", "Mushroom Cooked");
            }
            GameObject herbs = Prefab.GetChild("Herbs");
            for (int i = 0; i < 8; i++)
            {
                herbs.ApplyMaterialToChild($"Cube ({i})", "Rug - Dark Green");
            }
        }
    }
}
