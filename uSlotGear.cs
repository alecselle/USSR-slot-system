using System;
using Terraria;
using Terraria.ModLoader;
using uniteSlotSystemRemaster;
using uniteSlotSystemRemaster.AccessorySlots;

namespace uniteSlotSystemRemaster
{
    internal class uSlotGear : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CalamityFablesTypes = GetCalamityFablesTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] ConsolariaTypes = GetConsolariaTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("StatisNinjaBelt", out var StatisNinjaBelt);
                CalamityMod.TryFind<ModItem>("StatisVoidSash", out var StatisVoidSash);
                CalamityMod.TryFind<ModItem>("AbyssalDivingGear", out var AbyssalDivingGear);
                CalamityMod.TryFind<ModItem>("AbyssalDivingSuit", out var AbyssalDivingSuit);
                return new int[4] { StatisNinjaBelt.Type, StatisVoidSash.Type, AbyssalDivingGear.Type, AbyssalDivingSuit.Type };
            }
            return new int[4];
        }

        public static int[] GetCalamityFablesTypes()
        {
            if (ModLoader.TryGetMod("CalamityFables", out var CalamityFables))
            {
                CalamityFables.TryFind<ModItem>("WulfrumAcrobaticsPack", out var WulfrumAcrobaticsPack);
                CalamityFables.TryFind<ModItem>("SerratedFiberCloak", out var SerratedFiberCloak);
                return new int[2] { WulfrumAcrobaticsPack.Type, SerratedFiberCloak.Type };
            }
            return new int[2];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                AACMod.TryFind<ModItem>("MasterSwampGear", out var MasterSwampGear);
                AACMod.TryFind<ModItem>("UltimateDivingGear", out var UltimateDivingGear);
                AACMod.TryFind<ModItem>("MasterNinjaFrogGear", out var MasterNinjaFrogGear);
                return new int[3]
                { MasterSwampGear.Type, UltimateDivingGear.Type, MasterNinjaFrogGear.Type };
            }
            return new int[3];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("DeadlyEnviromentGear", out var DeadlyEnviromentGear);
                Combinations.TryFind<ModItem>("HazardousEnviromentGear", out var HazardousEnviromentGear);
                Combinations.TryFind<ModItem>("MOPPGear", out var MOPPGear);
                return new int[3]
                { DeadlyEnviromentGear.Type,HazardousEnviromentGear.Type , MOPPGear.Type };
            }
            return new int[3];
        }

        public static int[] GetConsolariaTypes()
        {
            if (ModLoader.TryGetMod("Consolaria", out var Consolaria))
            {
                Consolaria.TryFind<ModItem>("ShadowboundExoskeleton", out var ShadowboundExoskeleton);
                return new int[1]
                { ShadowboundExoskeleton.Type };
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

        static uSlotGear()
        {
            int[] obj = new int[27]
            {
                394, 953, 975, 976, 963, 977, 984, 1860, 1861, 2423, 3994, 3996, 3995, 
                0, 0, 0, 0, // Calamity
                0, 0, // Calamity Fables
                0, 0, 0, // AAC
                0, 0, 0, // Combination
                0, // Consolaria
                0
            };
            obj[13] = CalamityTypes[0];
            obj[14] = CalamityTypes[1];
            obj[15] = CalamityTypes[2];
            obj[16] = CalamityTypes[3];
            obj[17] = CalamityFablesTypes[0];
            obj[18] = CalamityFablesTypes[1];
            obj[19] = AACTypes[0];
            obj[20] = AACTypes[1];
            obj[21] = AACTypes[2];
            obj[22] = CombinationsTypes[0];
            obj[23] = CombinationsTypes[1];
            obj[24] = CombinationsTypes[2];
            obj[25] = ConsolariaTypes[0];
            Items = obj;
        }
    }
}
