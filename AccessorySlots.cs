using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using USSR;

namespace USSR.AccessorySlots
{
    [Autoload(false)]
    public class BootsAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)5000;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)4822;

        public override bool IsEnabled()
        {
            return Configuration.I.enableBootsAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemBoots.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemBoots.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Boots");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Boots");
                break;
            }
        }
    }
    [Autoload(false)]
    public class BuildingAccessSlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)3061;

        public override bool IsEnabled()
        {
            return Configuration.I.enableBuildingAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemBuilding.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemBuilding.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Building");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Building");
                break;
            }
        }
    }
    [Autoload(false)]
    public class DefenseAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)1613;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)3998;

        public override bool IsEnabled()
        {
            return Configuration.I.enableDefenseAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemDefence.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemDefence.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Defences");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Defences");
                break;
            }
        }
    }
    [Autoload(false)]
    public class ExpAccessSlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)3223;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)3090;

        public override bool IsEnabled()
        {
            if (Configuration.I.enableExpertModeAccessorySlotOnlyAfterEoWorBoC && Configuration.I.enableExpertModeAccessorySlot)
            {
                return NPC.downedBoss2;
            }
            if (!Configuration.I.enableExpertModeAccessorySlotOnlyAfterEoWorBoC && Configuration.I.enableExpertModeAccessorySlot)
            {
                return true;
            }
            return false;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemExpert.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemExpert.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Expert");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Expert");
                break;
            }
        }
    }
    [Autoload(false)]
    public class FishingAccessSlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)2375;

        public override bool IsEnabled()
        {
            return Configuration.I.enableFishingAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemFishing.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemFishing.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Fishing");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Fishing");
                break;
            }
        }
    }
    [Autoload(false)]
    public class GearAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)984;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)4983;

        public override bool IsEnabled()
        {
            return Configuration.I.enableGearAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemGear.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemGear.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Gears");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Gears");
                break;
            }
        }
    }
    [Autoload(false)]
    public class HealAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)860;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)4000;

        public override bool IsEnabled()
        {
            return Configuration.I.enableHealAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemHeal.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemHeal.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Heals");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Heals");
                break;
            }
        }
    }
    [Autoload(false)]
    public class MagiluminescenceAccessorySlot : ModAccessorySlot
    {
        //public override string FunctionalTexture => "Terraria/Images/Item_" + (short)4989;
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)5107;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)5107;

        public override bool IsEnabled()
        {
            return Configuration.I.enableMagiluminescenceAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemMagiluminescence.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemMagiluminescence.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Magiluminescences");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Magiluminescences");
                break;
            }
        }
    }
    [Autoload(false)]
    public class NecklaceAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)3212;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)4007;

        public override bool IsEnabled()
        {
            return Configuration.I.enableNecklaceAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemNecklace.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemNecklace.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Necklaces");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Necklaces");
                break;
            }
        }
    }
    [Autoload(false)]
    public class RevAccessSlot : ModAccessorySlot
    {
        public override bool IsEnabled()
        {
            if (Configuration.I.enableExpertModeAccessorySlot && ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                if (!(bool)CalamityMod.Call("DifficultyActive", "revengeance"))
                {
                    return (bool)CalamityMod.Call("DifficultyActive", "death");
                }
                return true;
            }
            return false;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemRevengeance.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemRevengeance.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Revengeance");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Revengeance");
                break;
            }
        }
    }
    [Autoload(false)]
    public class ScarfAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)3224;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)3809;

        public override bool IsEnabled()
        {
            return Configuration.I.enableScarfAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return Array.IndexOf(UnitedSlotSystemScarf.Items, checkItem.type) != -1;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return Array.IndexOf(UnitedSlotSystemScarf.Items, item.type) != -1;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Scarfs");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Scarfs");
                break;
            }
        }
    }
    [Autoload(false)]
    public class WingsAccessorySlot : ModAccessorySlot
    {
        public override string FunctionalTexture => "Terraria/Images/Item_" + (short)493;

        //public override string VanityTexture => "Terraria/Images/Item_" + (short)665;

        public override bool IsEnabled()
        {
            return Configuration.I.enableWingsAccessorySlot;
        }

        public override bool IsVisibleWhenNotEnabled()
        {
            return false;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return checkItem.wingSlot > 0;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return item.wingSlot > 0;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
            case AccessorySlotType.FunctionalSlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.Items.Wings");
                break;
            case AccessorySlotType.VanitySlot:
                Main.hoverItemName = Language.GetTextValue("Mods.USSR.SocialItems.Wings");
                break;
            }
        }
    }
}