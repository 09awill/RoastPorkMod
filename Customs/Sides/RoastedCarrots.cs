using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities.UniversalDelegates;
using UnityEngine;

namespace RoastPorkMod.Customs.Pork
{
    internal class RoastedCarrots : CustomItem
    {
        public override string UniqueNameID => "Roasted Carrots";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoastedCarrot"); // Make model
        public override GameObject SidePrefab => Mod.Bundle.LoadAsset<GameObject>("RoastedCarrot");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.SideMedium;
        //public override string ColourBlindTag => "RC";

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
        public override bool IsMergeableSide => true;
        public override void OnRegister(Item gameDataObject)
        {
            GameObject Carrot = Prefab.GetChild("Carrot");
            Carrot.ApplyMaterialToChild($"Cylinder.001", "Plastic - Orange");
            Carrot.ApplyMaterialToChild($"Cylinder.002", "Rug - Dark Green");
            Carrot.ApplyMaterialToChild($"Cylinder.001/Char1", "Bread - Cooked");
            Carrot.ApplyMaterialToChild($"Cylinder.001/Char2", "Bread - Cooked");
            Carrot.ApplyMaterialToChild($"Cylinder.001/Char3", "Bread - Cooked");


        }
    }
}
