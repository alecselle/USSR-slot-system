using System;
using Terraria;
using Terraria.ModLoader;
using uniteSlotSystemRemaster;
using uniteSlotSystemRemaster.AccessorySlots;

namespace uniteSlotSystemRemaster
{
    internal class uSlotExample : GlobalItem
    {
        public static int[] Items;

        // Arrays for different mods' item types
        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CalamityShoesTypes = GetCalamityShoesTypes();
        public static int[] CalamityFablesTypes = GetCalamityFablesTypes();
        public static int[] ThoriumTypes = GetThoriumTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] StormsTypes = GetStormsTypes();
        public static int[] ExpAccTypes = GetExpAccTypes();
        public static int[] DashAccTypes = GetDashAccTypes();
        public static int[] DashAccLiteTypes = GetDashAccLiteTypes();
        public static int[] ConsolariaTypes = GetConsolariaTypes();
        public static int[] FargoTypes = GetFargoTypes();
        public static int[] MoreAccTypes = GetMoreAccTypes();
        public static int[] WispTypes = GetWispTypes();
        public static int[] AnaSETypes = GetAnaSETypes();
        public static int[] AnaSSTypes = GetAnaSSTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                //CalamityMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetCalamityShoesTypes()
        {
            if (ModLoader.TryGetMod("CalamityShoes", out var CalamityShoes))
            {
                //CalamityShoes.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetCalamityFablesTypes()
        {
            if (ModLoader.TryGetMod("CalamityFables", out var CalamityFables))
            {
                //CalamityFables.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                //ThoriumMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                //AACMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                //Combinations.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetStormsTypes()
        {
            if (ModLoader.TryGetMod("StormDiversMod", out var StormsMod))
            {
                //StormsMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetExpAccTypes()
        {
            if (ModLoader.TryGetMod("ExpertAccessoryExpansion", out var EAEMod))
            {
                //EAEMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetDashAccTypes()
        {
            if (ModLoader.TryGetMod("DashAccessory", out var DashAccMod))
            {
                //DashAccMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetDashAccLiteTypes()
        {
            if (ModLoader.TryGetMod("DashAccessoryLite", out var DashAccLiteMod))
            {
                //DashAccLiteMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetConsolariaTypes()
        {
            if (ModLoader.TryGetMod("Consolaria", out var ConsolariaMod))
            {
                //ConsolariaMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetFargoTypes()
        {
            if (ModLoader.TryGetMod("FargowiltasSouls", out var FargoMod))
            {
                //FargoMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetMoreAccTypes()
        {
            if (ModLoader.TryGetMod("moreAccessoriesG13", out var MoreAccMod))
            {
                //MoreAccMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetWispTypes()
        {
            if (ModLoader.TryGetMod("Wisplantern", out var WispMod))
            {
                //WispMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetAnaSETypes()
        {
            if (ModLoader.TryGetMod("AnaScarfExpansionMod", out var ASEMod))
            {
                //ASEMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
        }

        public static int[] GetAnaSSTypes()
        {
            if (ModLoader.TryGetMod("AnaSilkScarfMod", out var ASSMod))
            {
                //ASSMod.TryFind<ModItem>("Item", out var Item);
                //return new int[1] { Item.Type };
            }
            return new int[0];
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

        static uSlotExample()
        {
            int[] obj = new int[0]
            {
                // List of vanilla item ids that go in this slot
                // Example: 54 // Hermes Boots
                // Add a '0' for each mod item you want to add

                // Example:
                // 54, 78, 79, 440, 441
                // 0, 0, 0, // Calamity
                // 0, 0, // CalamityShoes
                // 0, 0 // CalamityFables
                // 0, 0, 0 // Thorium
                // 0, 0, // AAC
                // 0, // Combinations
                // 0, 0, // Storms
                // 0, 0, 0, // ExpAcc
                // 0, 0, // DashAcc
                // 0, // DashAccLite
                // 0, 0, // Consolaria
                // 0, 0, 0, // Fargo
                // 0, // MoreAcc
                // 0, // Wisp
                // 0, 0, // AnaSE
                // 0 // AnaSS
            };
            // List of mod item types to add
            // Example: obj[i] = ModTypes[j];
            
            // Example:
            // obj[5] = CalamityTypes[0];
            // obj[6] = CalamityTypes[1];
            // obj[7] = CalamityTypes[2];
            // obj[8] = CalamityShoesTypes[0];
            // obj[9] = CalamityShoesTypes[1];
            // obj[10] = CalamityFablesTypes[0];
            // obj[11] = CalamityFablesTypes[1];
            // obj[12] = ThoriumTypes[0];
            // obj[13] = ThoriumTypes[1];
            // obj[14] = ThoriumTypes[2];
            // obj[15] = AACtypes[0];
            // obj[16] = AACtypes[1];
            // obj[17] = CombinationsTypes[0];
            // obj[18] = StormsTypes[0];
            // obj[19] = StormsTypes[1];
            // obj[20] = ExpAccTypes[0];
            // obj[21] = ExpAccTypes[1];
            // obj[23] = ExpAccTypes[2];
            // obj[24] = DashAccTypes[0];
            // obj[25] = DashAccTypes[1];
            // obj[26] = DashAccLiteTypes[0];
            // obj[27] = ConsolariaTypes[0];
            // obj[28] = ConsolariaTypes[1];
            // obj[29] = FargoTypes[0];
            // obj[30] = FargoTypes[1];
            // obj[31] = FargoTypes[2];
            // obj[32] = MoreAccTypes[0];
            // obj[33] = WispTypes[0];
            // obj[34] = AnaSETypes[0];
            // obj[35] = AnaSETypes[1];
            // obj[36] = AnaSSTypes[0];
            
            Items = obj;
        }
    }
}