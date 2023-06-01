using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;

namespace RoastPorkMod.Customs.Cards
{
    internal class SproutSide : CustomDish
    {
        public override string UniqueNameID => "Sprout Side";
        public override DishType Type => DishType.Side;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = Mod.SproutsCooked,
                Phase = MenuPhase.Side,
                Weight = 1,
            }
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.SproutsStalk,
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Cook,
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Portion sprouts from stalk then cook and serve as a side" },        
            { Locale.French,  "Détachez les pousses de chou de la tige, puis faites-les cuire et servez-les en accompagnement." },
            { Locale.German, "Portioniere die Röschen vom Stiel ab, koche sie und serviere sie als Beilage."},
            { Locale.Spanish,  "Separa los brotes del tallo, luego cocínalos y sírvelos como guarnición." },
            { Locale.Polish, "Odłóż pędy od łodygi, następnie gotuj i podawaj jako dodatek." },
            { Locale.Russian,  "Отделите побеги от стебля, затем приготовьте и подавайте как гарнир." },
            { Locale.PortugueseBrazil, "Separe os brotos do caule, depois cozinhe e sirva como acompanhamento." },
            { Locale.Japanese, "茎から芽を取り分け、調理して添え物として提供します" },
            { Locale.ChineseSimplified,  "从茎上取下豆芽，然后煮熟并作为配菜上桌"},
            { Locale.ChineseTraditional, "從莖上取下豆芽，然後煮熟並作為配菜上桌" },
            { Locale.Korean, "새싹을 줄기에서 분리하고 조리하여 사이드로 제공합니다." },
            { Locale.Turkish, "Filizleri sapından ayırın, ardından pişirin ve yanında servis yapın." },
        };
        public override List<(Locale, UnlockInfo)> InfoList => new ()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Sprouts", "Adds sprouts as a side", "Windy") ),          
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Choux de Bruxelles", "Ajoute des choux de Bruxelles en accompagnement", "Venteux") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Rosenkohl", "Fügt Rosenkohl als Beilage hinzu", "Windig") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Brotes de col de Bruselas", "Agrega brotes de col de Bruselas como guarnición", "Ventoso") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo( "Brukselka", "Dodaje brukselkę jako dodatek", "Wietrznie") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Брюссельская капуста", "Добавляет брюссельскую капусту как гарнир", "Ветрено") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Broto de repolho-de-bruxelas", "Adiciona brotos de repolho-de-bruxelas como acompanhamento", "Ventoso") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("芽キャベツ", "芽キャベツをサイドディッシュとして追加する", "風が強い") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo( "豆苗", "将豆苗作为配菜添加", "多风") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("豆苗", "將豆苗作為配菜添加", "多風") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("새싹", "새싹을 사이드로 추가합니다", "바람이 분다") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Brüksel lahanası", "Brüksel lahanasını yanında servis yapar", "Rüzgarlı") ),
        };
    }
}
