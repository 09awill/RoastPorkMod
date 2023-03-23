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

namespace RoastPorkMod.Customs
{
    internal class CookedPorkShoulderWithoutCrackling : CustomItem
    {
        public override string UniqueNameID => "Cooked Pork Shoulder Without Crackling";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PorkShoulderCookedWithoutCrackling");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override Item SplitSubItem => Mod.PorkChop;
        public override int SplitCount => 4;
        public override List<Item> SplitDepletedItems => new() { Mod.PorkChop };
        public override float SplitSpeed => 3.0f;
        public override void OnRegister(GameDataObject gameDataObject)
        {        
            Prefab.ApplyMaterialToChild("Pork1", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork2", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork3", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork4", "Porkchop Fat", "Porkchop");
            Prefab.ApplyMaterialToChild("Pork5", "Porkchop Fat", "Porkchop");
            //Prefab.GetChild("Pork5").ApplyMaterialToChild("PorkOtherSide", "Porkchop Fat", "Porkchop");
            var view = Prefab.AddComponent<CookedShoulderView>();
            //Prefab.AddComponent<ObjectsSplittableView>();

            GameObject[] list = new GameObject[]
            {
                Prefab.GetChild("Pork4"),
                Prefab.GetChild("Pork3"),
                Prefab.GetChild("Pork2"),
                Prefab.GetChild("Pork1")
            };
            view.m_Objects = list;

        }
        public class CookedShoulderView : ObjectsSplittableView
        {
            public GameObject[] m_Objects;
            private ViewData m_Data;
            private bool m_RunOnce = false;
            protected override void UpdateData(ViewData data)
            {
                if (m_RunOnce && data.Remaining == 0)
                {
                    return;
                }
                else
                {

                    for (int i = 0; i < m_Objects.Length; i++)
                    {

                        GameObject gameObject = m_Objects[i];
                        gameObject.SetActive(i < data.Remaining);
                    }

                    m_Data = data;
                    m_RunOnce = true;
                }
            }

        }
    }
}

