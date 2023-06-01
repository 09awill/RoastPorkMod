using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System.Collections.Generic;

namespace RoastPorkMod.Customs.Cards
{
    internal class PorkDishWithGarlicMushrooms : CustomDish
    {
        public override string UniqueNameID => "Pork Dish With Garlic Mushrooms";
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
                Ingredient = Mod.GarlicMushroomsCooked,
                MenuItem = Mod.PlatedPorkChopWithToppings
            },
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            Mod.PorkShoulder,
            Mod.Plate,
            Mod.Mushroom,
            Mod.Garlic
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Chop Mushrooms, Chop Garlic then chop again, combine, cook and add to plated pork" },
            { Locale.French, "Coupez les champignons, coupez l'ail puis coupez à nouveau, combinez, faites cuire et ajoutez au porc dans l'assiette." },
            { Locale.German, "Pilze hacken, Knoblauch hacken und nochmals hacken, kombinieren, kochen und zum angerichteten Schweinefleisch hinzufügen." },
            { Locale.Spanish,  "Pique los champiñones, pique el ajo y luego pique de nuevo, combine, cocine y agregue al cerdo en el plato." },
            { Locale.Polish, "Posiekaj grzyby, posiekaj czosnek, a następnie posiekaj ponownie, połącz, gotuj i dodaj do ułożonej wieprzowiny na talerzu." },
            { Locale.Russian, "Порежьте грибы, порежьте чеснок, затем еще раз порежьте, соедините, приготовьте и добавьте на тарелку с порцией свинины." },
            { Locale.PortugueseBrazil, "Pique os cogumelos, pique o alho e depois pique novamente, misture, cozinhe e adicione à carne de porco no prato." },
            { Locale.Japanese, "きのこを切り、にんにくを切り、再び切り、混ぜ合わせて調理し、豚肉に加えて皿に盛り付けます。" },
            { Locale.ChineseSimplified,   "切碎蘑菇，切碎大蒜，再次切碎，混合，烹饪并加入盘中的猪肉。" },
            { Locale.ChineseTraditional, "切碎蘑菇，切碎大蒜，再次切碎，混合，烹飪並加入盤中的豬肉。" },
            { Locale.Korean, "버섯을 썰고, 마늘을 썰고 다시 썰어서 섞어서 요리하고 요리된 돼지고기에 추가합니다." },
            { Locale.Turkish,  "Mantarları doğrayın, sarımsağı doğrayın ve tekrar doğrayın, karıştırın, pişirin ve tabağa yerleştirilmiş domuz etine ekleyin." },
        };
        public override List<(Locale, UnlockInfo)> InfoList => new ()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Garlic Mushrooms", "Adds garlic mushrooms as a topping to pork", "You're gonna stink of garlic") ),            
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Champignons à l'ail", "Ajoute des champignons à l'ail en tant que garniture pour le porc", "Tu vas sentir l'ail") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Knoblauchpilze", "Fügt Knoblauchpilze als Belag auf das Schweinefleisch hinzu", "Du wirst nach Knoblauch riechen") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Champiñones al ajillo", "Añade champiñones al ajillo como cobertura para el cerdo", "Vas a oler a ajo") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Grzyby czosnkowe", "Dodaje grzyby czosnkowe jako dodatek do wieprzowiny", "Będziesz pachnieć czosnkiem") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Чесночные грибы", "Добавляет чесночные грибы как топпинг к свинине", "Ты будешь пахнуть чесноком") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Cogumelos com alho", "Adiciona cogumelos com alho como cobertura para o porco", "Você vai cheirar a alho") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("ニンニクのきのこ", "豚肉にニンニクのきのこをトッピングとして追加する", "ニンニクの匂いがするよ") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("大蒜蘑菇", "将大蒜蘑菇作为猪肉的配料添加", "你会有大蒜的味道") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("大蒜蘑菇", "將大蒜蘑菇作為豬肉的配料添加", "你會有大蒜的味道") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("마늘 버섯", "돼지고기에 마늘 버섯을 토핑으로 추가합니다", "너는 마늘 냄새가 날 거야") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo( "Sarımsaklı Mantarlar", "Sarımsaklı mantarları domuz etinin üzerine ekliyor", "Sarımsak kokacaksın") ),

        };
    }
}
