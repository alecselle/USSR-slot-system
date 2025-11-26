using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using uniteSlotSystemRemaster;

namespace uniteSlotSystemRemaster
{
    public class Configuration : ModConfig
    {
        [Header("Slots:")]
        public bool enableWingsAccessorySlot;

        public bool enableBootsAccessorySlot;

        public bool enableGearAccessorySlot;

        public bool enableMagiluminescenceAccessorySlot;

        public bool enableNecklaceAccessorySlot;

        public bool enableScarfAccessorySlot;

        public bool enableHealAccessorySlot;

        public bool enableDefenseAccessorySlot;

        public bool enableExpertModeAccessorySlot;

        public bool enableExpertModeAccessorySlotOnlyAfterEoWorBoC;

        public bool enableBuildingAccessorySlot;

        public bool enableFishingAccessorySlot;

        public bool AllowEquippingInOtherSlots;

        public static Configuration I => ModContent.GetInstance<Configuration>();

        public override ConfigScope Mode => ConfigScope.ServerSide;
        public Configuration()
        {
            enableWingsAccessorySlot = true;
            enableBootsAccessorySlot = true;
            enableGearAccessorySlot = true;
            enableMagiluminescenceAccessorySlot = true;
            enableNecklaceAccessorySlot = true;
            enableScarfAccessorySlot = true;
            enableHealAccessorySlot = true;
            enableDefenseAccessorySlot = true;
            enableExpertModeAccessorySlot = true;
            enableExpertModeAccessorySlotOnlyAfterEoWorBoC = true;
            enableBuildingAccessorySlot = true;
            enableFishingAccessorySlot = true;
            AllowEquippingInOtherSlots = true;
        }
    }
}