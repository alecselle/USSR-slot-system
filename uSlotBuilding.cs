using System;
using Terraria;
using Terraria.ModLoader;
using uniteSlotSystemRemaster;
using uniteSlotSystemRemaster.AccessorySlots;

namespace uniteSlotSystemRemaster
{
    
    internal class uSlotBuilding : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AncientFossil", out var AncientFossil);
                CalamityMod.TryFind<ModItem>("OceanCrest", out var OceanCrest);
                CalamityMod.TryFind<ModItem>("SpelunkersAmulet", out var SpelunkersAmulet);
                CalamityMod.TryFind<ModItem>("ArchaicPowder", out var ArchaicPowder);
                return new int[4] { AncientFossil.Type, OceanCrest.Type, SpelunkersAmulet.Type, ArchaicPowder.Type };
            }
            return new int[4];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("BuildersPack", out var BuildersPack);
                return new int[1] { BuildersPack.Type };
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

        static uSlotBuilding()
        {
            int[] obj = new int[18]
            {
                3624, 1923, 407, 2216, 2215, 2217, 2214, 3061, 4056, 5126, 5010, 4341, 
                0, 0, 0, 0, // Calamity
                0, // Combination
                0
            };
            obj[12] = CalamityTypes[0];
            obj[13] = CalamityTypes[1];
            obj[14] = CalamityTypes[2];
            obj[15] = CalamityTypes[3];
            obj[16] = CombinationsTypes[0];
            Items = obj;
        }
    }
}