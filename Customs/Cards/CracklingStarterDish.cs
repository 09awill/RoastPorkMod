using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenRoastPorkMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastPorkMod.Customs.Cards
{
    internal class CracklingStarterDish : CustomDish
    {
        public override string UniqueNameID => "Crackling Starter";
        public override DishType Type => DishType.Starter;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override CardType CardType => CardType.Default;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsUnlockable => true;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Mod.PorkDish
        };

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
               Item = Mod.CracklingPortion,
               Phase = MenuPhase.Starter,
               Weight = 1
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.PorkShoulder,
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Cook Pork Shoulder then take off the crackling, then portion and serve" },
            { Locale.French, "Faire cuire l'épaule de porc puis retirer le croustillant, puis découper et servir." },
            { Locale.German, "Schweineschulter kochen, dann das Knusprige abnehmen, in Portionen teilen und servieren." },
            { Locale.Spanish,  "Cocinar la paleta de cerdo, luego quitar el crujiente, porcionar y servir." },
            { Locale.Polish, "Ugotuj szynkę wieprzową, następnie usuń chrupiącą skórkę, pokroj i podawaj." },
            { Locale.Russian, "Приготовить свиное плечо, затем снять хрустящую корочку, нарезать порции и подать." },
            { Locale.PortugueseBrazil, "Cozinhe o ombro de porco, retire a crosta crocante, porcione e sirva." },
            { Locale.Japanese, "豚肩肉を調理し、それから皮目のパリパリを取り除いてカットして提供してください。" },
            { Locale.ChineseSimplified,  "烤猪肩肉，去除表皮，切块上菜。" },
            { Locale.ChineseTraditional, "烤豬肩肉，去除表皮，切塊上菜。" },
            { Locale.Korean, "돼지 어깨살을 조리한 후 껍질을 제거하고 적당한 크기로 잘라서 제공하세요." },
            { Locale.Turkish,  "Domuz omuz pişirin, sonra çıtır kabuğunu çıkarın, porsiyonlara ayırın ve servis yapın." },
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Crackling Starter", "Customers can request crackling as a starter", "Mmm Crunchy") ),
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Entrée de Craquelins", "Les clients peuvent demander des craquelins en entrée", "Mmm croustillant") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Knusprige Vorspeise", "Kunden können Knusper als Vorspeise bestellen", "Mmm knusprig") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Entrante de Chicharrón", "Los clientes pueden solicitar chicharrón como entrada", "Mmm Crujiente") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Starter ze skwarek", "Klienci mogą poprosić o skwarki na przystawkę", "Mmm chrupiące") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Запеканка из свиного бока", "Клиенты могут заказать запеканку из свиного бока в качестве закуски", "Mmm хрустящая") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Entrada de torresmo", "Os clientes podem pedir torresmo como entrada", "Mmm Crocante") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("豚のかりんとう", "客は前菜としてかりんとうを注文することができます", "Mmm カリカリ") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("炸猪皮开胃菜", "顾客可以要求炸猪皮作为开胃菜", "嘎吱脆") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("炸豬皮開胃菜", "顧客可以要求炸豬皮作為開胃菜", "嘎吱脆") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("돼지 피부 전채요리", "고객들은 피부 전채요리를 시작으로 요청할 수 있습니다", "Mmm 바삭") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Çıtır Başlangıç", "Müşteriler çıtırı başlangıç olarak isteyebilirler", "Mmm çıtır") ),
        };
    }
}
