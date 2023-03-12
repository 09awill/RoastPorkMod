using IngredientLib.Util;
using Kitchen.Components;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using UnityEngine;

namespace RoastPorkMod.Customs
{
    internal class PorkShoulderProvider : CustomAppliance
    {
        public override string UniqueNameID => "Pork Shoulder Provider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Provider - Pork Shoulder");
        public override PriceTier PriceTier => PriceTier.Medium;
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateApplianceInfo("Pork Shoulder", "Provides Pork Shoulders", new(), new()) )
        };

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>()
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(Mod.PorkShoulder.ID)
        };
        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject should = Prefab.GetChild("PorkShoulder");
            should.ApplyMaterial("Pork Fat", "Pork", "Pork Fat");
            should.ApplyMaterialToChild("PorkMarbling", "Pork Fat");
            should.ApplyMaterialToChild("PorkMarbling1", "Pork Fat");
            should = Prefab.GetChild("PorkShoulder1");
            should.ApplyMaterial("Pork Fat", "Pork", "Pork Fat");
            should.ApplyMaterialToChild("PorkMarbling", "Pork Fat");
            should.ApplyMaterialToChild("PorkMarbling1", "Pork Fat");

            GameObject fridge = Prefab.GetChild("Fridge");
            GameObject fridge2 = fridge.GetChild("Fridge2");


            Prefab.TryAddComponent<ItemHolderView>();
            fridge.TryAddComponent<ItemHolderView>();

            var sourceView = fridge.TryAddComponent<ItemSourceView>();
            var quad = fridge.GetChild("Quad").GetComponent<MeshRenderer>();
            quad.materials = MaterialHelper.GetMaterialArray("Flat Image");
            ReflectionUtils.GetField<ItemSourceView>("Renderer").SetValue(sourceView, quad);
            ReflectionUtils.GetField<ItemSourceView>("Animator").SetValue(sourceView, fridge2.GetComponent<Animator>());

            var soundSource = fridge2.TryAddComponent<AnimationSoundSource>();
            soundSource.SoundList = new List<AudioClip>() { Mod.Bundle.LoadAsset<AudioClip>("Fridge_mixdown") };
            soundSource.Category = SoundCategory.Effects;
            soundSource.ShouldLoop = false;

            // Fridge Materials
            fridge2.ApplyMaterialToChild("Body", "Metal- Shiny", "Metal- Shiny", "Metal- Shiny");
            fridge2.ApplyMaterialToChild("Door", "Metal- Shiny", "Metal Dark", "Door Glass");
            fridge2.ApplyMaterialToChild("Divider", "Plastic - Dark Grey");
            fridge2.ApplyMaterialToChild("Wire", "Plastic - Blue");
        }
    }
}
