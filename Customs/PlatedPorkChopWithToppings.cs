using Kitchen;
using KitchenData;
using KitchenLib.Colorblind;
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
    internal class PlatedPorkChopWithToppings : CustomItemGroup<PlatedPorkChopWithToppingsItemGroupView>
    {
        public override string UniqueNameID => "Plated Pork Chop With Toppings";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedPorkWithTopping");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override Item DisposesTo => Mod.Plate;
        public override Item DirtiesTo => Mod.DirtyPlate;
        public override bool CanContainSide => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet()
            {
                Max = 2,
                Min = 2,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.PorkChop,
                    Mod.Plate
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Mod.AppleSauce,
                }
            },
        };
        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.GetComponent<PlatedPorkChopWithToppingsItemGroupView>()?.Setup(Prefab);

            Prefab.GetChild("Plate/Plate/Cylinder").ApplyMaterial("Plate", "Plate - Ring");

            Prefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");
            Material[] mats = new Material[] { MaterialUtils.GetExistingMaterial("Plastic - Orange") };
            Prefab.GetChild("AppleSauce").ApplyMaterial(mats);
        }
    }
    public class PlatedPorkChopWithToppingsItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject pPrefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present

            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(pPrefab, "Pork"),
                    Item = Mod.PorkChop
                }, 
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(pPrefab, "AppleSauce"),
                    Item = Mod.AppleSauce
                }
            };
            ComponentLabels = new()
            {
                new()
                {
                    Text = "P",
                    Item = Mod.PorkChop
                },
                new()
                {
                    Text = "A",
                    Item = Mod.AppleSauce
                }
            };
        }
    }
}
