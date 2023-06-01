using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;

namespace RoastPorkMod.Customs.Cards
{
    internal class RoastCarrotsSide : CustomDish
    {
        public override string UniqueNameID => "Roast Carrots";
        public override DishType Type => DishType.Side;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = Mod.RoastedCarrots,
                Phase = MenuPhase.Side,
                Weight = 1,
            }
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.Carrots,
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Cook Carrot" },           
            { Locale.French, "Cuire les carottes" },
            { Locale.German, "Karotten kochen"},
            { Locale.Spanish,  "Cocinar zanahorias" },
            { Locale.Polish, "Gotuj marchewki" },
            { Locale.Russian,  "Готовить морковь" },
            { Locale.PortugueseBrazil, "Cozinhe as cenouras" },
            { Locale.Japanese, "人参を調理する" },
            { Locale.ChineseSimplified, "烹饪胡萝卜" },
            { Locale.ChineseTraditional, "烹飪胡蘿蔔" },
            { Locale.Korean, "당근을 조리하다" },
            { Locale.Turkish, "Havuçları pişirin" },
        };
        public override List<(Locale, UnlockInfo)> InfoList => new ()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Roasted Carrots", "Adds roasted carrots as a side", "You're gonna love the roasted carrots") ),       
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Carottes rôties", "Ajoute des carottes rôties en accompagnement", "Tu vas adorer les carottes rôties") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Geröstete Karotten", "Fügt geröstete Karotten als Beilage hinzu", "Du wirst die gerösteten Karotten lieben") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Zanahorias asadas", "Agrega zanahorias asadas como guarnición", "Vas a amar las zanahorias asadas") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo( "Pieczone marchewki", "Dodaje pieczone marchewki jako dodatek", "Będziesz zachwycony(a) pieczonymi marchewkami") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Печеные морковь", "Добавляет запеченные морковь в качестве гарнира", "Ты будешь в восторге от запеченных моркови") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Cenouras assadas", "Adiciona cenouras assadas como acompanhamento", "Você vai adorar as cenouras assadas") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("焼き人参", "焼き人参をサイドディッシュとして追加する", "焼き人参が大好きになるよ") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("烤胡萝卜", "将烤胡萝卜作为配菜添加", "你会喜欢烤胡萝卜的") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("烤胡蘿蔔", "將烤胡蘿蔔作為配菜添加", "你會愛上烤胡蘿蔔的") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("구운 당근", "구운 당근을 사이드로 추가합니다", "구운 당근을 사랑하게 될 거야") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Fırında Havuç", "Fırında havuçları yan olarak ekler", "Fırında havuçları çok seveceksin") ),
        };
    }
}
