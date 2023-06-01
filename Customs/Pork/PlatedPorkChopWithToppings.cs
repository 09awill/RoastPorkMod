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

namespace RoastPorkMod.Customs.Pork
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
                RequiresUnlock = true,
                Items = new List<Item>()
                {
                    Mod.AppleSauce,
                    Mod.Stuffing,
                    Mod.GarlicMushroomsCooked
                }
            },
        };
        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.GetComponent<PlatedPorkChopWithToppingsItemGroupView>()?.Setup(Prefab);

            Prefab.GetChild("Plate/Plate/Cylinder").ApplyMaterial("Plate", "Plate - Ring");

            Prefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");
            Material[] mats = new Material[] { MaterialUtils.GetExistingMaterial("Plastic - Orange") };
            Prefab.GetChild("AppleSauce").ApplyMaterial(mats);
            for (int i = 1; i < 3; i++)
            {
                Prefab.ApplyMaterialToChild($"Stuffing/Ice Cream ({i})", "Bread - Inside Cooked");
            }

            GameObject Mushrooms = Prefab.GetChild("GarlicMushroomsCooked/Mushrooms");
            for (int i = 1; i < 4; i++)
            {
                Mushrooms.ApplyMaterialToChild($"mushroomHalf ({i})/mushroomHalf", "Mushroom Cooked", "Mushroom Cooked");
            }
            GameObject herbs = Prefab.GetChild("GarlicMushroomsCooked/Herbs");
            for (int i = 0; i < 8; i++)
            {
                herbs.ApplyMaterialToChild($"Cube ({i})", "Rug - Dark Green");
            }

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
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(pPrefab, "Stuffing"),
                    Item = Mod.Stuffing
                },               
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(pPrefab, "GarlicMushroomsCooked"),
                    Item = Mod.GarlicMushroomsCooked
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
                },
                new()
                {
                    Text = "S",
                    Item = Mod.Stuffing
                },                
                new()
                {
                    Text = "M",
                    Item = Mod.GarlicMushroomsCooked
                }
            };
        }
    }
}
