using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    internal class UnitedSlotSystemMagiluminescence : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] MoreAccTypes = GetMoreAccTypes();
        public static int[] ExpAccTypes = GetExpAccExpTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AscendantInsignia", out var AscendantInsignia);
                return new int[1] { AscendantInsignia.Type };
            }
            return new int[1];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("MagicArrow", out var MagicArrow);
                Combinations.TryFind<ModItem>("CharmOfTrueFlight", out var CharmOfTrueFlight);
                return new int[2] { MagicArrow.Type, CharmOfTrueFlight.Type };
            }
            return new int[2];
        }

        public static int[] GetMoreAccTypes()
        {
            if (ModLoader.TryGetMod("moreAccessoriesG13", out var MoreAccMod))
            {
                MoreAccMod.TryFind<ModItem>("CosmiliteInsignia", out var CosmiliteInsignia);
                MoreAccMod.TryFind<ModItem>("MechMagiluminescence", out var MechMagiluminescence);
                return new int[2] { CosmiliteInsignia.Type, MechMagiluminescence.Type };
            }
            return new int[2];
        }

        public static int[] GetExpAccExpTypes()
        {
            if (ModLoader.TryGetMod("ExpertAccessoryExpansion", out var EAEMod))
            {
                EAEMod.TryFind<ModItem>("EmpressFlightBooster", out var EmpressFlightBooster);
                return new int[1] { EmpressFlightBooster.Type };
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

        static UnitedSlotSystemMagiluminescence()
        {
            int[] obj = new int[9]
            {
                4989, 5107,
                0, // Calamity
                0, 0, // MoreAcc
                0, 0, // Combination
                0, // ExpAccExp
                0
            };
            obj[2] = CalamityTypes[0];
            obj[3] = MoreAccTypes[0];
            obj[4] = MoreAccTypes[1];
            obj[5] = CombinationsTypes[0];
            obj[6] = CombinationsTypes[1];
            obj[7] = ExpAccTypes[0];
            Items = obj;
        }
    }
}
