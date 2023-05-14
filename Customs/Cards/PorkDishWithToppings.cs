using IngredientLib.Util;
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
                MenuItem = Mod.PlatedPorkChop
            },
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate,
            Mod.Apple
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Chop apples, then chop again to make sauce, add to plated pork" },
            { Locale.French, "Hacher les pommes, puis hacher à nouveau pour faire de la sauce, ajouter au porc dans l'assiette!" },
            { Locale.German,  "Äpfel hacken, dann nochmal hacken, um eine Sauce zu machen, auf das angerichtete Schweinefleisch geben!" },
            { Locale.Spanish,  "Cortar las manzanas, luego picar de nuevo para hacer la salsa, agregar al cerdo en el plato!" },
            { Locale.Polish, "Posiekaj jabłka, następnie posiekaj ponownie, aby zrobić sos, dodaj do podanego na talerzu mięsa wieprzowego!" },
            { Locale.Russian, "Нарежьте яблоки, затем нарежьте их еще раз, чтобы сделать соус, добавьте на тарелку с свининой!" },
            { Locale.PortugueseBrazil, "Pique as maçãs, depois pique novamente para fazer molho, adicione ao porco no prato!" },
            { Locale.Japanese, "リンゴを切ってから再び刻んでソースを作り、盛り付けた豚肉に加えます！" },
            { Locale.ChineseSimplified, "切碎苹果，再切一次制成酱汁，加入盘中的猪肉！" },
            { Locale.ChineseTraditional, "切碎蘋果，再切一次製成醬汁，加入盤中的豬肉！" },
            { Locale.Korean,  "사과를 잘게 썰고 다시 잘게 썰어 소스를 만든 다음 접시에 올린 돼지고기에 넣으세요!" },
            { Locale.Turkish,  "Elmaları doğrayın, ardından sos yapmak için tekrar doğrayın, tabağa koyduğunuz domuz etine ekleyin!" },
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
