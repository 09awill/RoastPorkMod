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
            { Locale.English, "Cook Pork Shoulder then take off the crackling, then chop and portion cooked shoulder into steaks, plate up and serve!" },
            { Locale.French, "Cuire l'épaule de porc, puis retirer le croustillant, ensuite découper et portionner l'épaule cuite en steaks, dresser sur assiettes et servir !" },
            { Locale.German, "Kochen Sie die Schweineschulter, nehmen Sie dann die knusprige Haut ab, schneiden Sie die gekochte Schulter in Steaks und portionieren Sie sie, richten Sie sie auf Tellern an und servieren Sie sie!" },
            { Locale.Spanish,  "Cocine el hombro de cerdo, luego retire la piel crujiente, después corte y porcione el hombro cocido en filetes, sirva en platos ¡y a disfrutar!" },
            { Locale.Polish, "Ugotuj bark wieprzowy, następnie usuń chrupiącą skórkę, potem pokrój i porcjnuj ugotowany bark na steki, ułóż na talerzach i podawaj!" },
            { Locale.Russian, "Приготовьте свиную плечевую кость, затем снимите хрустящую корочку, затем нарежьте и разделите приготовленное мясо на стейки, разложите на тарелках и подавайте!" },
            { Locale.PortugueseBrazil, "Cozinhe o ombro de porco e depois retire a pele crocante. Em seguida, corte e divida o ombro cozido em bifes, coloque nos pratos e sirva!" },
            { Locale.Japanese, "豚肩肉を調理し、その後パリパリの皮を取り除きます。次に、調理した肩肉をステーキに切り分けて盛り付け、提供してください！" },
            { Locale.ChineseSimplified,   "烹饪猪肩肉，然后去掉表面的脆皮，再将烹煮好的肩肉切成片，摆盘并上菜！" },
            { Locale.ChineseTraditional, "烹飪豬肩肉，然後去掉脆皮，再將熟肩肉切成扒片，盛盤上菜！" },
            { Locale.Korean, "돼지 어깨고기를 요리한 다음 바삭한 피부를 떼어내고, 그 후에 요리된 어깨고기를 스테이크로 썬 다음, 접시에 담아서 제공하세요!" },
            { Locale.Turkish,  "Domuz omzunu pişirin, ardından çıtır çıtır kabuğunu çıkarın, sonra pişmiş omuzu biftekler halinde doğrayın ve tabaklara yerleştirip servis yapın!" },
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
