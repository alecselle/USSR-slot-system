using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    internal class UnitedSlotSystemRevengeance : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("Laudanum", out var Laudanum);
                CalamityMod.TryFind<ModItem>("OccultSkullCrown", out var OccultSkullCrown);
                CalamityMod.TryFind<ModItem>("StressPills", out var StressPills);
                CalamityMod.TryFind<ModItem>("HeartofDarkness", out var HeartofDarkness);
                return new int[4] { Laudanum.Type, OccultSkullCrown.Type, StressPills.Type, HeartofDarkness.Type };
            }
            return new int[4];
        }

        public static int[] ItemsStatic = new int[4]
        {
            GetCalamityTypes()[0],
            GetCalamityTypes()[1],
            GetCalamityTypes()[2],
            GetCalamityTypes()[3]
        };

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                bool isEnabled = false;

                if (Configuration.I.enableExpertModeAccessorySlot && ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
                {
                    bool isRevengeanceActive = (bool)CalamityMod.Call("DifficultyActive", "revengeance");
                    bool isDeathActive = (bool)CalamityMod.Call("DifficultyActive", "death");

                    if (!isRevengeanceActive)
                    {
                        isEnabled = isDeathActive;
                    }
                    else
                    {
                        isEnabled = true;
                    }
                }
                return (Configuration.I.AllowEquippingInOtherSlots || !isEnabled);
            }
            return true;
        }

        static UnitedSlotSystemRevengeance()
        {
            Items = ItemsStatic;
        }
    }
}
