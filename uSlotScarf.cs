using System;
using Terraria;
using Terraria.ModLoader;
using uniteSlotSystemRemaster;
using uniteSlotSystemRemaster.AccessorySlots;

namespace uniteSlotSystemRemaster
{
    internal class uSlotScarf : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CalamityFablesTypes = GetCalamityFablesTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] ExpAccTypes = GetExpAccExpTypes();
        public static int[] MoreAccTypes = GetMoreAccTypes();
        public static int[] AnaSETypes = GetAnaSETypes();
        public static int[] AnaSSTypes = GetAnaSSTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("BloodyWormScarf", out var BloodyWormScarf);
                CalamityMod.TryFind<ModItem>("CounterScarf", out var CounterScarf);
                CalamityMod.TryFind<ModItem>("EvasionScarf", out var EvasionScarf);
                CalamityMod.TryFind<ModItem>("Popo", out var Popo);
                return new int[4] { BloodyWormScarf.Type, CounterScarf.Type, EvasionScarf.Type, Popo.Type };
            }
            return new int[4];
        }

        public static int[] GetCalamityFablesTypes()
        {
            if (ModLoader.TryGetMod("CalamityFables", out var CalamityFables))
            {
                CalamityFables.TryFind<ModItem>("IntestinalScarf", out var IntestinalScarf);
                return new int[1] { IntestinalScarf.Type };
            }
            return new int[1];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                AACMod.TryFind<ModItem>("BrainScarf", out var BrainScarf);
                return new int[1] { BrainScarf.Type };
            }
            return new int[1];
        }

        public static int[] GetExpAccExpTypes()
        {
            if (ModLoader.TryGetMod("ExpertAccessoryExpansion", out var EAEMod))
            {
                EAEMod.TryFind<ModItem>("WormScarf", out var WormScarf);
                return new int[1] { WormScarf.Type };
            }
            return new int[1];
        }

        public static int[] GetMoreAccTypes()
        {
            if (ModLoader.TryGetMod("moreAccessoriesG13", out var MoreAccMod))
            {
                MoreAccMod.TryFind<ModItem>("MegaScarf", out var MegaScarf);
                MoreAccMod.TryFind<ModItem>("TheDevourerofWorms", out var TheDevourerofWorms);
                return new int[2] { MegaScarf.Type, TheDevourerofWorms.Type };
            }
            return new int[2];
        }

        public static int[] GetAnaSETypes()
        {
            if (ModLoader.TryGetMod("AnaScarfExpansionMod", out var ASEMod))
            {
                ASEMod.TryFind<ModItem>("CrimsonScarf", out var CrimsonScarf);
                ASEMod.TryFind<ModItem>("FlinxScarf", out var FlinxScarf);
                ASEMod.TryFind<ModItem>("FossilScarf", out var FossilScarf);
                ASEMod.TryFind<ModItem>("JungleScarf", out var JungleScarf);
                ASEMod.TryFind<ModItem>("NecroScarf", out var NecroScarf);
                ASEMod.TryFind<ModItem>("ShadowScarf", out var ShadowScarf);
                ASEMod.TryFind<ModItem>("SilkScarf", out var SilkScarf);
                ASEMod.TryFind<ModItem>("StrangeScarf", out var StrangeScarf);
                ASEMod.TryFind<ModItem>("ForbiddenScarf", out var ForbiddenScarf);
                ASEMod.TryFind<ModItem>("FrozenScarf", out var FrozenScarf);
                ASEMod.TryFind<ModItem>("Tier1Scarf", out var Tier1Scarf);
                ASEMod.TryFind<ModItem>("Tier2Scarf", out var Tier2Scarf);
                ASEMod.TryFind<ModItem>("Tier3Scarf", out var Tier3Scarf);
                ASEMod.TryFind<ModItem>("Tier4Scarf", out var Tier4Scarf);
                ASEMod.TryFind<ModItem>("Tier5Scarf", out var Tier5Scarf);
                ASEMod.TryFind<ModItem>("Tier6Scarf", out var Tier6Scarf);
                return new int[16] { CrimsonScarf.Type, FlinxScarf.Type, FossilScarf.Type, JungleScarf.Type, NecroScarf.Type, ShadowScarf.Type, SilkScarf.Type, StrangeScarf.Type, ForbiddenScarf.Type, FrozenScarf.Type, Tier1Scarf.Type, Tier2Scarf.Type, Tier3Scarf.Type, Tier4Scarf.Type, Tier5Scarf.Type, Tier6Scarf.Type, };
            }
            return new int[16];
        }

        public static int[] GetAnaSSTypes()
        {
            if (ModLoader.TryGetMod("AnaSilkScarfMod", out var ASSMod))
            {
                ASSMod.TryFind<ModItem>("AnaSilkScarf", out var AnaSilkScarf);
                return new int[1] { AnaSilkScarf.Type };
            }
            return new int[1];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return (Configuration.I.AllowEquippingInOtherSlots || !Configuration.I.enableBootsAccessorySlot);
            }
            return true;
        }

        static uSlotScarf()
        {
            int[] obj = new int[29]
            {
                3809, 3224,
                0, 0, 0, 0, // Calamity
                0, // CalamityFables
                0, // AAC
                0, 0, // MoreAcc
                0, // ExpAccExp
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // AnaSE
                0, // AnaSS
                0
            };
            obj[2] = CalamityTypes[0];
            obj[3] = CalamityTypes[1];
            obj[4] = CalamityTypes[2];
            obj[5] = CalamityTypes[3];
            obj[6] = CalamityFablesTypes[0];
            obj[7] = AACTypes[0];
            obj[8] = MoreAccTypes[0];
            obj[9] = MoreAccTypes[1];
            obj[10] = ExpAccTypes[0];
            obj[11] = AnaSETypes[0];
            obj[12] = AnaSETypes[1];
            obj[13] = AnaSETypes[2];
            obj[14] = AnaSETypes[3];
            obj[15] = AnaSETypes[4];
            obj[16] = AnaSETypes[5];
            obj[17] = AnaSETypes[6];
            obj[18] = AnaSETypes[7];
            obj[19] = AnaSETypes[8];
            obj[20] = AnaSETypes[9];
            obj[21] = AnaSETypes[10];
            obj[22] = AnaSETypes[11];
            obj[23] = AnaSETypes[12];
            obj[24] = AnaSETypes[13];
            obj[25] = AnaSETypes[14];
            obj[26] = AnaSETypes[15];
            obj[27] = AnaSSTypes[0];
            Items = obj;
        }
    }
}
