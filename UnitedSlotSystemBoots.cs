using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    
    internal class UnitedSlotSystemBoots : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CalamityShoesTypes = GetCalamityShoesTypes();
        public static int[] CalamityFablesTypes = GetCalamityFablesTypes();
        public static int[] ThoriumTypes = GetThoriumTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] StormsTypes = GetStormsTypes();
        public static int[] FargoTypes = GetFargoTypes();

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AngelTreads", out var AngelTreads);
                CalamityMod.TryFind<ModItem>("TracersCelestial", out var CelestialTracers);
                CalamityMod.TryFind<ModItem>("TracersElysian", out var ElysianTracers);
                CalamityMod.TryFind<ModItem>("TracersSeraph", out var SeraphTracers);
                CalamityMod.TryFind<ModItem>("IronBoots", out var IronBoots);
                CalamityMod.TryFind<ModItem>("GravistarSabaton", out var GravistarSabaton);
                return new int[6] { AngelTreads.Type, CelestialTracers.Type, ElysianTracers.Type, SeraphTracers.Type, IronBoots.Type, GravistarSabaton.Type };
            }
            return new int[6];
        }

        public static int[] GetCalamityShoesTypes()
        {
            if (ModLoader.TryGetMod("CalamityShoes", out var CalamityShoes))
            {
                CalamityShoes.TryFind<ModItem>("CelestialTreads", out var CelestialTreads);
                CalamityShoes.TryFind<ModItem>("ElysianTreads", out var ElysianTreads);
                CalamityShoes.TryFind<ModItem>("SeraphTreads", out var SeraphTreads);
                return new int[3] { CelestialTreads.Type, ElysianTreads.Type, SeraphTreads.Type };
            }
            return new int[3];
        }

        public static int[] GetCalamityFablesTypes()
        {
            if (ModLoader.TryGetMod("CalamityFables", out var CalamityFables))
            {
                CalamityFables.TryFind<ModItem>("MushroomBoots", out var MushroomBoots);
                return new int[1] { MushroomBoots.Type };
            }
            return new int[1];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("CrashBoots", out var CrashBoots);
                ThoriumMod.TryFind<ModItem>("SurvivalistBoots", out var SurvivalistBoots);
                ThoriumMod.TryFind<ModItem>("BeeBooties", out var BeeBooties);
                ThoriumMod.TryFind<ModItem>("JetBoots", out var JetBoots);
                ThoriumMod.TryFind<ModItem>("WizardShoes", out var WizardShoes);
                ThoriumMod.TryFind<ModItem>("SlagStompers", out var SlagStompers);
                ThoriumMod.TryFind<ModItem>("SpringSteps", out var SpringSteps);
                ThoriumMod.TryFind<ModItem>("TurboBoots", out var TurboBoots);
                ThoriumMod.TryFind<ModItem>("TravelersBoots", out var TravelersBoots);
                ThoriumMod.TryFind<ModItem>("SteelToedBoots", out var SteelToedBoots);
                ThoriumMod.TryFind<ModItem>("MarchingBoots", out var MarchingBoots);
                ThoriumMod.TryFind<ModItem>("ArtificersRocketeers", out var ArtificersRocketeers);
                ThoriumMod.TryFind<ModItem>("SpartanSandles", out var SpartanSandles);
                ThoriumMod.TryFind<ModItem>("OgreSandal", out var OgreSandal);
                ThoriumMod.TryFind<ModItem>("HoverBoots", out var HoverBoots);
                ThoriumMod.TryFind<ModItem>("HealthyBoots", out var HealthyBoots);
                ThoriumMod.TryFind<ModItem>("DriftBoots", out var DriftBoots);
                ThoriumMod.TryFind<ModItem>("AirWalkers", out var AirWalkers);
                ThoriumMod.TryFind<ModItem>("TerrariumParticleSprinters", out var TerrariumParticleSprinters);
                return new int[19] { CrashBoots.Type, SurvivalistBoots.Type, BeeBooties.Type, JetBoots.Type, WizardShoes.Type, SlagStompers.Type, SpringSteps.Type, TurboBoots.Type, TravelersBoots.Type, SteelToedBoots.Type, MarchingBoots.Type, ArtificersRocketeers.Type, SpartanSandles.Type, OgreSandal.Type, HoverBoots.Type, HealthyBoots.Type, DriftBoots.Type, AirWalkers.Type, TerrariumParticleSprinters.Type };
            }
            return new int[19];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                AACMod.TryFind<ModItem>("TerraAmphibianBoots", out var TerraAmphibianBoots);
                return new int[1] { TerraAmphibianBoots.Type };
            }
            return new int[1];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("HellBoots", out var HellBoots);
                Combinations.TryFind<ModItem>("JungleBoots", out var JungleBoots);
                Combinations.TryFind<ModItem>("DruidTreads", out var DruidTreads);
                Combinations.TryFind<ModItem>("GardeningBoots", out var GardeningBoots);
                Combinations.TryFind<ModItem>("OvergrownTreads", out var OvergrownTreads);
                return new int[5] { HellBoots.Type, JungleBoots.Type, DruidTreads.Type, GardeningBoots.Type, OvergrownTreads.Type };
            }
            return new int[5];
        }

        public static int[] GetStormsTypes()
        {
            if (ModLoader.TryGetMod("StormDiversMod", out var StormsMod))
            {
                StormsMod.TryFind<ModItem>("BloodBoots", out var BloodBoots);
                StormsMod.TryFind<ModItem>("SoulBoots", out var SoulBoots);
                StormsMod.TryFind<ModItem>("StompBootHorse", out var StompBootHorse);
                StormsMod.TryFind<ModItem>("StompBoot", out var StompBoot);
                return new int[4] { BloodBoots.Type, SoulBoots.Type, StompBootHorse.Type, StompBoot.Type };
            }
            return new int[4];
        }

        public static int[] GetFargoTypes()
        {
            if (ModLoader.TryGetMod("FargowiltasSouls", out var FargoMod))
            {
                FargoMod.TryFind<ModItem>("EurusSock", out var EurusSock);
                FargoMod.TryFind<ModItem>("ZephyrBoots", out var ZephyrBoots);
                FargoMod.TryFind<ModItem>("AeolusBoots", out var AeolusBoots);
                return new int[3] { EurusSock.Type, ZephyrBoots.Type, AeolusBoots.Type };
            }
            return new int[3];
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

        static UnitedSlotSystemBoots()
        {
            int[] obj = new int[61]
            {
                54, 1579, 3200, 4055, 3990, 405, 3993, 4874, 898, 1862, 5000, 863, 907, 908, 128, 950, 3017, 4822, 
                0, 0, 0, 0, 0, 0, // Calamity
                0, 0, 0, // Calamity Shoes
                0,  // Calamity Fables
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // Thorium
                0, // AAC
                0, 0, 0, 0, 0, // Combination
                0, 0, 0, 0, // Storms
                0, 0, 0, // Fargo
                0
            };
            obj[18] = CalamityTypes[0];
            obj[19] = CalamityTypes[1];
            obj[20] = CalamityTypes[2];
            obj[21] = CalamityTypes[3];
            obj[22] = CalamityTypes[4];
            obj[23] = CalamityTypes[5];
            obj[24] = CalamityShoesTypes[0];
            obj[25] = CalamityShoesTypes[1];
            obj[26] = CalamityShoesTypes[2];
            obj[27] = CalamityFablesTypes[0];
            obj[28] = ThoriumTypes[0];
            obj[29] = ThoriumTypes[1];
            obj[30] = ThoriumTypes[2];
            obj[31] = ThoriumTypes[3];
            obj[32] = ThoriumTypes[4];
            obj[33] = ThoriumTypes[5];
            obj[34] = ThoriumTypes[6];
            obj[35] = ThoriumTypes[7];
            obj[36] = ThoriumTypes[8];
            obj[37] = ThoriumTypes[9];
            obj[38] = ThoriumTypes[10];
            obj[39] = ThoriumTypes[11];
            obj[40] = ThoriumTypes[12];
            obj[41] = ThoriumTypes[13];
            obj[42] = ThoriumTypes[14];
            obj[43] = ThoriumTypes[15];
            obj[44] = ThoriumTypes[16];
            obj[45] = ThoriumTypes[17];
            obj[46] = ThoriumTypes[18];
            obj[47] = AACTypes[0];
            obj[48] = CombinationsTypes[0];
            obj[49] = CombinationsTypes[1];
            obj[50] = CombinationsTypes[2];
            obj[51] = CombinationsTypes[3];
            obj[52] = CombinationsTypes[4];
            obj[53] = StormsTypes[0];
            obj[54] = StormsTypes[1];
            obj[55] = StormsTypes[2];
            obj[56] = StormsTypes[3];
            obj[57] = FargoTypes[0];
            obj[58] = FargoTypes[1];
            obj[59] = FargoTypes[2];
            Items = obj;
        }
    }
}