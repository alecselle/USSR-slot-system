using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    internal class UnitedSlotSystemExpert : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] StormsTypes = GetStormsTypes();
        public static int[] ExpAccTypes = GetExpAccTypes();
        public static int[] ConsolariaTypes = GetConsolariaTypes(); 

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("BloodyWormTooth", out var BloodyWormTooth);
                CalamityMod.TryFind<ModItem>("RottenBrain", out var RottenBrain);
                CalamityMod.TryFind<ModItem>("AmalgamatedBrain", out var AmalgamatedBrain);
                CalamityMod.TryFind<ModItem>("BloodyWormScarf", out var BloodyWormScarf);
                CalamityMod.TryFind<ModItem>("TheAmalgam", out var TheAmalgam);
                return new int[5] { BloodyWormTooth.Type, RottenBrain.Type, AmalgamatedBrain.Type, BloodyWormScarf.Type, TheAmalgam.Type };
            }
            return new int[5];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                AACMod.TryFind<ModItem>("BrainScarf", out var BrainScarf);
                AACMod.TryFind<ModItem>("SlimeShield", out var SlimeShield);
                AACMod.TryFind<ModItem>("ObsidianCthulhuShield", out var ObsidianCthulhuShield);
                return new int[3] { BrainScarf.Type, SlimeShield.Type, ObsidianCthulhuShield.Type };
            }
            return new int[3];
        }
        
        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("SlimeShield", out var SlimeShield);
                return new int[1] { SlimeShield.Type };
            }
            return new int[1];
        }

        public static int[] GetStormsTypes()
        {
            if (ModLoader.TryGetMod("StormDiversMod", out var StormDiversMod))
            {
                StormDiversMod.TryFind<ModItem>("AridCore", out var AridCore);
                StormDiversMod.TryFind<ModItem>("StormCoil", out var StormCoil);
                StormDiversMod.TryFind<ModItem>("LunaticHood", out var LunaticHood);
                StormDiversMod.TryFind<ModItem>("DeathCore", out var DeathCore);
                StormDiversMod.TryFind<ModItem>("PrimeAccess", out var PrimeAccess);
                StormDiversMod.TryFind<ModItem>("FlameCore", out var FlameCore);
                StormDiversMod.TryFind<ModItem>("SantaWires", out var SantaWires);
                return new int[7] { AridCore.Type, StormCoil.Type, LunaticHood.Type, DeathCore.Type, PrimeAccess.Type, FlameCore.Type, SantaWires.Type };
            }
            return new int[7];
        }

        public static int[] GetExpAccTypes()
        {
            if (ModLoader.TryGetMod("ExpertAccessoryExpansion", out var EAEMod))
            {
                EAEMod.TryFind<ModItem>("WormScarf", out var WormScarf);
                EAEMod.TryFind<ModItem>("EoCShield", out var EoCShield);
                EAEMod.TryFind<ModItem>("BrainOfConfusion", out var BrainOfConfusion);
                EAEMod.TryFind<ModItem>("EmpressFlightBooster", out var EmpressFlightBooster);
                EAEMod.TryFind<ModItem>("EnergyModule", out var EnergyModule);
                EAEMod.TryFind<ModItem>("BoneHelm", out var BoneHelm);
                EAEMod.TryFind<ModItem>("LaserModule", out var LaserModule);
                EAEMod.TryFind<ModItem>("HiveBackpack", out var HiveBackpack);
                EAEMod.TryFind<ModItem>("DukeScale", out var DukeScale);
                EAEMod.TryFind<ModItem>("GravityGlobe", out var GravityGlobe);
                EAEMod.TryFind<ModItem>("DrivingModule", out var DrivingModule);
                EAEMod.TryFind<ModItem>("RoyalGel", out var RoyalGel);
                EAEMod.TryFind<ModItem>("ShinyStone", out var ShinyStone);
                EAEMod.TryFind<ModItem>("SporeSac", out var SporeSac);
                EAEMod.TryFind<ModItem>("VolatileGelatin", out var VolatileGelatin);
                EAEMod.TryFind<ModItem>("DemonHeart", out var DemonHeart);
                EAEMod.TryFind<ModItem>("LunarSeal", out var LunarSeal);
                EAEMod.TryFind<ModItem>("BoneGlove", out var BoneGlove);
                return new int[18] { WormScarf.Type, EoCShield.Type, BrainOfConfusion.Type, EmpressFlightBooster.Type, EnergyModule.Type, BoneHelm.Type, LaserModule.Type, HiveBackpack.Type, DukeScale.Type,GravityGlobe.Type, DrivingModule.Type, RoyalGel.Type, ShinyStone.Type, SporeSac.Type, VolatileGelatin.Type, DemonHeart.Type, LunarSeal.Type, BoneGlove.Type };
            }
            return new int[18];
        }

        public static int[] GetConsolariaTypes()
        {
            if (ModLoader.TryGetMod("Consolaria", out var Consolaria))
            {
                Consolaria.TryFind<ModItem>("OstarasGift", out var OstarasGift);
                return new int[1] { OstarasGift.Type };
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

        static UnitedSlotSystemExpert()
        {
            int[] obj = new int[49]
            {
                3090, 3097, 3224, 3223, 3333, 3245, 5100, 4987, 3336, 3337, 4989, 1131, 4954, 
                0, 0, 0, 0, 0, // Calamity
                0, 0, 0, // AAC
                0, // Combination
                0, 0, 0, 0, 0, 0, 0, // Storms
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // ExpAccExp
                0, // Consolaria
                0
            };
            obj[13] = CalamityTypes[0];
            obj[14] = CalamityTypes[1];
            obj[15] = CalamityTypes[2];
            obj[16] = CalamityTypes[3];
            obj[17] = CalamityTypes[4];
            obj[18] = AACTypes[0];
            obj[19] = AACTypes[1];
            obj[20] = AACTypes[2];
            obj[21] = CombinationsTypes[0];
            obj[22] = StormsTypes[0];
            obj[23] = StormsTypes[1];
            obj[24] = StormsTypes[2];
            obj[25] = StormsTypes[3];
            obj[26] = StormsTypes[4];
            obj[27] = StormsTypes[5];
            obj[28] = StormsTypes[6];
            obj[29] = ExpAccTypes[0];
            obj[30] = ExpAccTypes[1];
            obj[31] = ExpAccTypes[2];
            obj[32] = ExpAccTypes[3];
            obj[33] = ExpAccTypes[4];
            obj[34] = ExpAccTypes[5];
            obj[35] = ExpAccTypes[6];
            obj[36] = ExpAccTypes[7];
            obj[37] = ExpAccTypes[8];
            obj[38] = ExpAccTypes[9];
            obj[39] = ExpAccTypes[10];
            obj[40] = ExpAccTypes[11];
            obj[41] = ExpAccTypes[12];
            obj[42] = ExpAccTypes[13];
            obj[43] = ExpAccTypes[14];
            obj[44] = ExpAccTypes[15];
            obj[45] = ExpAccTypes[16];
            obj[46] = ExpAccTypes[17];
            obj[47] = ConsolariaTypes[0];
            Items = obj;
        }
    }
}
