using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    internal class UnitedSlotSystemNecklace : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] ThoriumTypes = GetThoriumTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] StormsTypes = GetStormsTypes();
        public static int[] WispTypes = GetWispTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("SandSharkToothNecklace", out var SandSharkToothNecklace);
                CalamityMod.TryFind<ModItem>("ReaperToothNecklace", out var ReaperToothNecklace);
                CalamityMod.TryFind<ModItem>("NecklaceofVexation", out var NecklaceofVexation);
                CalamityMod.TryFind<ModItem>("SpelunkersAmulet", out var SpelunkersAmulet);
                CalamityMod.TryFind<ModItem>("DeificAmulet", out var DeificAmulet);
                CalamityMod.TryFind<ModItem>("LumenousAmulet", out var LumenousAmulet);
                CalamityMod.TryFind<ModItem>("AbyssalAmulet", out var AbyssalAmulet);
                return new int[7] { SandSharkToothNecklace.Type, ReaperToothNecklace.Type, NecklaceofVexation.Type, AbyssalAmulet.Type, LumenousAmulet.Type, SpelunkersAmulet.Type, DeificAmulet.Type };
            }
            return new int[7];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("PacifistNecklace", out var PacifistNecklace);
                ThoriumMod.TryFind<ModItem>("ForgottenCrossNecklace", out var ForgottenCrossNecklace);
                ThoriumMod.TryFind<ModItem>("DragonTalonNecklace", out var DragonTalonNecklace);
                ThoriumMod.TryFind<ModItem>("VerdantOrnament", out var VerdantOrnament);
                ThoriumMod.TryFind<ModItem>("SavingGrace", out var SavingGrace);
                ThoriumMod.TryFind<ModItem>("Equalizer", out var Equalizer);
                ThoriumMod.TryFind<ModItem>("SacredHeart", out var SacredHeart);
                ThoriumMod.TryFind<ModItem>("SweetVengeance", out var SweetVengeance);
                return new int[8] { PacifistNecklace.Type, ForgottenCrossNecklace.Type, DragonTalonNecklace.Type, VerdantOrnament.Type, SavingGrace.Type, Equalizer.Type, SacredHeart.Type, SweetVengeance.Type };
            }
            return new int[8];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("MirrorNecklace", out var MirrorNecklace);
                return new int[1] { MirrorNecklace.Type };
            }
            return new int[1];
        }

        public static int[] GetStormsTypes()
        {
            if (ModLoader.TryGetMod("StormDiversMod", out var StormDiversMod))
            {
                StormDiversMod.TryFind<ModItem>("WoodNecklace", out var WoodNecklace);
                StormDiversMod.TryFind<ModItem>("WoodNecklaceDesert", out var WoodNecklaceDesert);
                StormDiversMod.TryFind<ModItem>("WoodNecklaceFrozen", out var WoodNecklaceFrozen);
                StormDiversMod.TryFind<ModItem>("ObiPain", out var ObiPain);
                return new int[4] { WoodNecklace.Type, WoodNecklaceDesert.Type, WoodNecklaceFrozen.Type, ObiPain.Type, };
            }
            return new int[4];
        }

        public static int[] GetWispTypes()
        {
            if (ModLoader.TryGetMod("Wisplantern", out var WisplanternMod))
            {
                WisplanternMod.TryFind<ModItem>("WispNecklace", out var WispNecklace);
                return new int[1] { WispNecklace.Type };
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

        static UnitedSlotSystemNecklace()
        {
            int[] obj = new int[30]
            {
                554, 862, 1158, 1290, 1303, 1578, 3212, 4007, 
                0, 0, 0, 0, 0, 0, 0, // Calamity
                0, 0, 0, 0, 0, 0, 0, 0, // Thorium
                0, // Combination
                0, 0, 0, 0, // Storms
                0, // Wisp
                0
            };
            obj[8] = CalamityTypes[0];
            obj[9] = CalamityTypes[1];
            obj[10] = CalamityTypes[2];
            obj[11] = CalamityTypes[3];
            obj[12] = CalamityTypes[4];
            obj[13] = CalamityTypes[5];
            obj[14] = CalamityTypes[6];
            obj[15] = ThoriumTypes[0];
            obj[16] = ThoriumTypes[1];
            obj[17] = ThoriumTypes[2];
            obj[18] = ThoriumTypes[3];
            obj[19] = ThoriumTypes[4];
            obj[20] = ThoriumTypes[5];
            obj[21] = ThoriumTypes[6];
            obj[22] = ThoriumTypes[7];
            obj[23] = CombinationsTypes[0];
            obj[24] = StormsTypes[0];
            obj[25] = StormsTypes[1];
            obj[26] = StormsTypes[2];
            obj[27] = StormsTypes[3];
            obj[28] = WispTypes[0];
            Items = obj;
        }
    }
}
