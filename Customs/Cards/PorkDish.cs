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

namespace RoastPorkMod.Customs.Cards
{
    internal class PorkDish : CustomDish
    {
        public override string UniqueNameID => "Pork Dish";
        public override DishType Type => DishType.Base;
        public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("PlatedPorkIcon");
        public override GameObject IconPrefab => DisplayPrefab;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Large;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsSpecificFranchiseTier => false;
        public override bool IsAvailableAsLobbyOption => true;

        public override List<string> StartingNameSet => new()
        {
            "Hogwash",
            "Ground Hog Day",
            "Swine and Dine",
            "Piggie Smalls",
            "The Chop Shop",
            "The Pig and Pickle",
            "Bacon Me Crazy",
            "Boar-ing Kitchen",
            "Quit Hogging The Stove",
            "Miny's Porky Place",
            "Pork on your fork"

        };
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedPorkChop,
                Phase = MenuPhase.Main,
                Weight = 1,
            }
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Cook Pork Shoulder then take off the crackling, then portion cooked shoulder into steaks, plate up and serve!" },
            { Locale.French, "Cuire l'épaule de porc, retirer le croustillant, couper en tranches puis dresser sur l'assiette et servir !" },
            { Locale.German, "Schweineschulter kochen, das Knusprige abnehmen, in Steaks portionieren, auf einem Teller anrichten und servieren!" },
            { Locale.Spanish,  "Cocinar la paleta de cerdo, quitar la piel crujiente, cortar en filetes, servir en un plato y ¡listo!" },
            { Locale.Polish, "Ugotuj szynkę wieprzową, zdejmij skórkę, następnie pokrój w steki, ułóż na talerzu i podaj!" },
            { Locale.Russian, "Приготовить свиное плечо, снять хрустящую корочку, разделить на стейки, выложить на тарелку и подать!" },
            { Locale.PortugueseBrazil, "Cozinhe o ombro de porco, retire a pele crocante, corte em bifes, sirva em um prato e pronto!" },
            { Locale.Japanese, "豚肩肉を調理し、かりっとした皮を取り除いてステーキにカットし、皿に盛って提供してください！" },
            { Locale.ChineseSimplified,   "烹饪猪肩肉，取下脆皮，切成牛排，摆盘上菜！" },
            { Locale.ChineseTraditional, "烹飪豬肩肉，取下酥脆皮，切成牛排，擺盤上菜！" },
            { Locale.Korean, "돼지 어깨고기를 요리하고 바삭한 껍질을 제거한 후 스테이크로 나누어 접시에 담아 서빙하세요!" },
            { Locale.Turkish,  "Domuz omuzu pişirin, çıtır kabuğunu çıkarın, pişmiş omuzu biftekler halinde porsiyonlayın, tabağa yerleştirin ve servis yapın!" },
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Pork", "Adds Pork as a Main", "Delicious Pork") ),
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Porc", "Ajoutez le porc en plat principal", "Délicieux porc") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Schweinefleisch", "Fügen Sie Schweinefleisch als Hauptgericht hinzu", "Leckeres Schweinefleisch") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Cerdo", "Agrega Cerdo como Plato Principal", "Delicioso Cerdo") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Wieprzowina", "Dodaje wieprzowinę jako danie główne", "Pyszna wieprzowina") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Свинина", "Добавьте свинину как основное блюдо", "Вкусная свинина") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Porco", "Adiciona Porco como Prato Principal", "Delicioso Porco") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("ポーク", "メインにポークを追加", "おいしいポーク") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("猪肉", "添加猪肉作为主菜", "美味的猪肉") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("豬肉", "添加豬肉作為主菜", "美味的豬肉") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("돼지고기", "돼지고기 추가하기", "맛있는 돼지고기") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo( "Domuz eti", "Ana yemek olarak domuz eti ekleyin", "Lezzetli domuz eti") ),
        };

        public override void OnRegister(Dish gameDataObject)
        {
            DisplayPrefab.GetChild("Plate/Plate/Cylinder").ApplyMaterial("Plate", "Plate - Ring");
            DisplayPrefab.ApplyMaterialToChild("Pork", "Porkchop Fat", "Porkchop");
        }
    }
}
