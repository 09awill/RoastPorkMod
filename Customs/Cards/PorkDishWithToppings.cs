using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;

namespace RoastPorkMod.Customs.Cards
{
    internal class PorkDishWithToppings : CustomDish
    {
        public override string UniqueNameID => "Pork Dish With Toppings";
        public override DishType Type => DishType.Extra;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Mod.PorkDish
        };
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedPorkChopWithToppings,
                Phase = MenuPhase.Main,
                Weight = 1,
            }
        };

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.AppleSauce,
                MenuItem = Mod.PlatedPorkChopWithToppings
            },
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate,
            Mod.Apple,
            Mod.Sugar
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Chop apples, then combine with sugar to make sauce, add to plated pork" },
            { Locale.French, "Coupez les pommes en dés, puis mélangez-les avec du sucre pour faire une sauce, ajoutez-la au porc dressé." },
            { Locale.German,  "Äpfel würfeln, dann mit Zucker vermischen, um eine Sauce herzustellen, zum angerichteten Schweinefleisch hinzufügen." },
            { Locale.Spanish,  "Corta las manzanas en trozos, luego combínalas con azúcar para hacer una salsa, añádela al cerdo en el plato." },
            { Locale.Polish, "Posiekaj jabłka, następnie połącz je z cukrem, aby przygotować sos, dodaj go do porcji ułożonego na talerzu." },
            { Locale.Russian, "Нарежьте яблоки, затем соедините с сахаром, чтобы приготовить соус, добавьте к порционированной свинине." },
            { Locale.PortugueseBrazil, "Pique as maçãs, em seguida, misture com açúcar para fazer o molho, adicione ao porco no prato." },
            { Locale.Japanese, "リンゴを切って、砂糖と組み合わせてソースを作り、盛り付けた豚肉に加えます" },
            { Locale.ChineseSimplified, "切碎苹果，然后与糖混合制成酱汁，加到盘中的猪肉上" },
            { Locale.ChineseTraditional, "切碎蘋果，然後與糖混合製成醬汁，加到盤中的豬肉上" },
            { Locale.Korean,  "사과를 썰어서 설탕과 함께 섞어 소스를 만들고, 그것을 담아낸 돼지고기에 추가합니다" },
            { Locale.Turkish,  "Elmaları doğrayın, ardından şekerle karıştırarak sos yapın ve tabağa yerleştirilmiş olan domuz etine ekleyin." },
        };
        public override List<(Locale, UnlockInfo)> InfoList => new ()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Apple Sauce", "Adds apple sauce as a topping to pork", "What is pork without apple sauce?") ),
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Compote de pommes", "Ajoutez la compote de pommes comme garniture pour le porc", "Qu'est-ce que le porc sans compote de pommes ?") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Apfelmus", "Fügt Apfelmus als Topping zu Schweinefleisch hinzu", "Was ist Schweinefleisch ohne Apfelmus?") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Salsa de Manzana", "Agrega salsa de manzana como cobertura para el cerdo", "¿Qué es el cerdo sin salsa de manzana?") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Mus jabłkowy", "Dodaj mus jabłkowy jako dodatek do wieprzowiny", "Co to jest wieprzowina bez musu jabłkowego?") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Яблочный соус", "Добавьте яблочный соус как топпинг к свинине", "Что такое свинина без яблочного соуса?") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Molho de Maçã", "Adiciona o molho de maçã como cobertura para o porco", "O que é o porco sem molho de maçã?") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("アップルソース", "豚肉のトッピングとしてアップルソースを追加する", "リンゴソースなしで豚肉はあり得ないでしょう？") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("苹果酱", "将苹果酱加入猪肉作为配料", "没有苹果酱的猪肉算什么？") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("蘋果醬", "將蘋果醬加入豬肉作為配料", "沒有蘋果醬的豬肉算什麼？") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("애플소스", "돼지고기에 토핑으로 애플소스 추가", "애플소스 없는 돼지고기는 불가능합니다.") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Elma Sosu", "Elma sosunu domuz etine ekleyin", "Elma sosu olmadan domuz eti ne ki?") ),
        };
    }
}
