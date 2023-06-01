using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;

namespace RoastPorkMod.Customs.Cards
{
    internal class PorkDishWithStuffing : CustomDish
    {
        public override string UniqueNameID => "Pork Dish With Stuffing";
        public override DishType Type => DishType.Extra;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Mod.PorkDishWithToppings
        };
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.Stuffing,
                MenuItem = Mod.PlatedPorkChopWithToppings
            },
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate,
            Mod.Onion,
            Mod.Flour,
            Mod.Water
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead flour and cook to make bread. Slice and cook to make toast. Chop toast to create breadcrumbs, combine with chopped onion and cook" },
            { Locale.French, "Pétrissez la farine et faites cuire pour faire du pain. Tranchez et faites cuire pour faire des toasts. Hachez les toasts pour créer des miettes de pain, mélangez-les avec de l'oignon haché et faites cuire." },
            { Locale.German, "Knete Mehl und koche, um Brot herzustellen. Schneide und koche, um Toast zuzubereiten. Hacke den Toast, um Semmelbrösel herzustellen, kombiniere sie mit gehackter Zwiebel und koche."},
            { Locale.Spanish,  "Amasa la harina y cocina para hacer pan. Rebana y cocina para hacer tostadas. Pica las tostadas para hacer migas de pan, combínalas con cebolla picada y cocina." },
            { Locale.Polish, "Wyrabiaj mąkę i gotuj, aby zrobić chleb. Kraj i gotuj, aby zrobić tost. Posiekaj tost na bułkę tartą, połącz z posiekaną cebulą i gotuj." },
            { Locale.Russian,  "Замешивайте муку и готовьте, чтобы приготовить хлеб. Нарезайте и готовьте, чтобы приготовить тосты. Измельчите тосты, чтобы получить сухари, соедините с нарезанным луком и готовьте." },
            { Locale.PortugueseBrazil, "Amasse a farinha e cozinhe para fazer pão. Fatie e cozinhe para fazer torradas. Pique as torradas para criar migalhas, combine com cebola picada e cozinhe." },
            { Locale.Japanese, "小麦粉をこねて調理し、パンを作ります。スライスして調理し、トーストを作ります。トーストを刻んでパン粉を作り、刻んだ玉ねぎと混ぜ合わせて調理します。" },
            { Locale.ChineseSimplified,   "揉面粉并烹饪以制作面包。切片并烹饪以制作吐司。切碎吐司制作面包屑，与切碎的洋葱混合烹饪。" },
            { Locale.ChineseTraditional, "揉麵粉並烹飪以製作麵包。切片並烹飪以製作吐司。切碎吐司製作麵包屑，與切碎的洋蔥混合烹飪。" },
            { Locale.Korean, "밀가루를 반죽하여 요리하여 빵을 만듭니다. 슬라이스하여 요리하여 토스트를 만듭니다. 토스트를 다시 썰어서 빵가루를 만들고, 다진 양파와 함께 조리합니다." },
            { Locale.Turkish,  "Unu yoğurup pişirerek ekmek yapın. Dilimleyin ve kızartarak tost yapın. Tostları doğrayarak galeta unu oluşturun, doğranmış soğanla karıştırın ve pişirin." },

        };
        public override List<(Locale, UnlockInfo)> InfoList => new ()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Pork with stuffing", "Adds stuffing as a topping to pork", "You're gonna be stuffed") ),
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Porc avec de la farce", "Ajoute de la farce comme garniture pour le porc", "Tu vas être bien rassasié(e)") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Schweinefleisch mit Füllung", "Fügt Füllung als Belag auf das Schweinefleisch hinzu", "Du wirst satt sein") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Cerdo con relleno", "Añade relleno como cobertura para el cerdo", "Vas a estar lleno(a)") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Wieprzowina z nadzieniem", "Dodaje nadzienie jako dodatek do wieprzowiny", "Będziesz najedzony(a)") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Свинина с начинкой", "Добавляет начинку как топпинг к свинине", "Ты будешь наелся(лась)") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Porco com recheio", "Adiciona recheio como cobertura para o porco", "Você vai ficar cheio(a)") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo( "詰め物の入った豚肉", "豚肉の上に詰め物をトッピングとして追加する", "お腹いっぱいになるよ") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("填料的猪肉", "将填料作为猪肉的配料添加", "你会吃饱的") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("填料的豬肉", "將填料作為豬肉的配料添加", "你會吃飽的") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("Stuffing 으로 속을 채운 돼지고기", "Stuffing을 돼지고기의 토핑으로 추가합니다", "배부르게 될 거야") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("İçli Köfte ile domuz eti", "Domuz etine içli köfte olarak ekler", "Tıka basa dolacaksın") ),

        };
    }
}
