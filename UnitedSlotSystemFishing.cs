using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    internal class UnitedSlotSystemFishing : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] FargoTypes = GetFargoTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AlluringBait", out var AlluringBait);
                CalamityMod.TryFind<ModItem>("EnchantedPearl", out var EnchantedPearl);
                CalamityMod.TryFind<ModItem>("SupremeBaitTackleBoxFishingStation", out var SupremeBaitTackleBoxFishingStation);
                return new int[3] { AlluringBait.Type, EnchantedPearl.Type, SupremeBaitTackleBoxFishingStation.Type };
            }
            return new int[3];
        }

        public static int[] GetFargoTypes()
        {
            if (ModLoader.TryGetMod("FargowiltasSouls", out var FargoSouls))
            {
                FargoSouls.TryFind<ModItem>("AnglerEnchant", out var AnglerEnchant);
                return new int[1] { AnglerEnchant.Type };
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

        static UnitedSlotSystemFishing()
        {
            int[] obj = new int[19]
            {
                5064, 3721, 4881, 2375, 2374, 2373, 5139, 5140, 5141, 5142, 5143, 5144, 5145, 5146, 
                0, 0, 0,  // Calamity
                0, // Fargo
                0
            };
            obj[14] = CalamityTypes[0];
            obj[15] = CalamityTypes[1];
            obj[16] = CalamityTypes[2];
            obj[17] = FargoTypes[0];
            Items = obj;
        }
    }
}
