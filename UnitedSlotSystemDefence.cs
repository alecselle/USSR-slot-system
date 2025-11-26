using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    
    internal class UnitedSlotSystemDefence : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CalamityFablesTypes = GetCalamityFablesTypes();
        public static int[] ThoriumTypes = GetThoriumTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] StormsTypes = GetStormsTypes();
        public static int[] ExpAccTypes = GetExpAccTypes();
        
        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("Baroclaw", out var Baroclaw);
                CalamityMod.TryFind<ModItem>("GiantTortoiseShell", out var GiantTortoiseShell);
                CalamityMod.TryFind<ModItem>("CrawCarapace", out var CrawCarapace);
                CalamityMod.TryFind<ModItem>("GiantShell", out var GiantShell);
                CalamityMod.TryFind<ModItem>("ElysianAegis", out var ElysianAegis);
                CalamityMod.TryFind<ModItem>("AsgardianAegis", out var AsgardianAegis);
                CalamityMod.TryFind<ModItem>("AsgardsValor", out var AsgardsValor);
                CalamityMod.TryFind<ModItem>("ShieldoftheOcean", out var ShieldoftheOcean);
                CalamityMod.TryFind<ModItem>("MarniteRepulsionShield", out var MarniteRepulsionShield);
                CalamityMod.TryFind<ModItem>("OrnateShield", out var OrnateShield);
                CalamityMod.TryFind<ModItem>("ShieldoftheHighRuler", out var ShieldoftheHighRuler);
                CalamityMod.TryFind<ModItem>("RampartofDeities", out var RampartofDeities);
                CalamityMod.TryFind<ModItem>("RoverDrive", out var RoverDrive);
                CalamityMod.TryFind<ModItem>("TheSponge", out var TheSponge);
                CalamityMod.TryFind<ModItem>("Affliction", out var Affliction);
                CalamityMod.TryFind<ModItem>("BloodflareCore", out var BloodflareCore);
                CalamityMod.TryFind<ModItem>("TheAbsorber", out var TheAbsorber);
                CalamityMod.TryFind<ModItem>("SlagsplitterPauldron", out var SlagsplitterPauldron);
                CalamityMod.TryFind<ModItem>("FrostBarrier", out var FrostBarrier);
                CalamityMod.TryFind<ModItem>("HideofAstrumDeus", out var HideofAstrumDeus);
                CalamityMod.TryFind<ModItem>("TheTransformer", out var TheTransformer);
                CalamityMod.TryFind<ModItem>("NebulousCore", out var NebulousCore);
                return new int[22] { Baroclaw.Type, GiantTortoiseShell.Type, CrawCarapace.Type, GiantShell.Type, ElysianAegis.Type, AsgardianAegis.Type, AsgardsValor.Type, ShieldoftheOcean.Type, MarniteRepulsionShield.Type, OrnateShield.Type, ShieldoftheHighRuler.Type, RampartofDeities.Type, RoverDrive.Type, TheSponge.Type, Affliction.Type, BloodflareCore.Type, TheAbsorber.Type, SlagsplitterPauldron.Type, FrostBarrier.Type, HideofAstrumDeus.Type, TheTransformer.Type, NebulousCore.Type };
            }
            return new int[22];
        }

        public static int[] GetCalamityFablesTypes()
        {
            if (ModLoader.TryGetMod("CalamityFables", out var CalamityFables))
            {
                CalamityFables.TryFind<ModItem>("MarniteRepulsionShield", out var MarniteRepulsionShield);
                CalamityFables.TryFind<ModItem>("RoverDrive", out var RoverDrive);
                return new int[2] { MarniteRepulsionShield.Type, RoverDrive.Type };
            }
            return new int[2];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("MantleoftheProtector", out var MantleoftheProtector);
                ThoriumMod.TryFind<ModItem>("TerrariumDefender", out var TerrariumDefender);
                ThoriumMod.TryFind<ModItem>("GoldAegis", out var GoldAegis);
                ThoriumMod.TryFind<ModItem>("HolyAegis", out var HolyAegis);
                ThoriumMod.TryFind<ModItem>("PlatinumAegis", out var PlatinumAegis);
                ThoriumMod.TryFind<ModItem>("ArtificersShield", out var ArtificersShield);
                ThoriumMod.TryFind<ModItem>("BlastShield", out var BlastShield);
                ThoriumMod.TryFind<ModItem>("BloomingShield", out var BloomingShield);
                ThoriumMod.TryFind<ModItem>("GoblinWarshield", out var GoblinWarshield);
                ThoriumMod.TryFind<ModItem>("ThoriumShield", out var ThoriumShield);
                ThoriumMod.TryFind<ModItem>("IronShield", out var IronShield);
                ThoriumMod.TryFind<ModItem>("LeadShield", out var LeadShield);
                ThoriumMod.TryFind<ModItem>("AstroBeetleHusk", out var AstroBeetleHusk);
                ThoriumMod.TryFind<ModItem>("PlasmaGenerator", out var PlasmaGenerator);
                ThoriumMod.TryFind<ModItem>("CopperBuckler", out var CopperBuckler);
                ThoriumMod.TryFind<ModItem>("TinBuckler", out var TinBuckler);
                ThoriumMod.TryFind<ModItem>("SilverBulwark", out var SilverBulwark);
                ThoriumMod.TryFind<ModItem>("TungstenBulwark", out var TungstenBulwark);
                ThoriumMod.TryFind<ModItem>("SeaTurtlesBulwark", out var SeaTurtlesBulwark);
                return new int[19] { MantleoftheProtector.Type, TerrariumDefender.Type, GoldAegis.Type, HolyAegis.Type, PlatinumAegis.Type, ArtificersShield.Type, BlastShield.Type, BloomingShield.Type, GoblinWarshield.Type, ThoriumShield.Type, IronShield.Type, LeadShield.Type, AstroBeetleHusk.Type, PlasmaGenerator.Type, CopperBuckler.Type, TinBuckler.Type, SilverBulwark.Type, TungstenBulwark.Type, SeaTurtlesBulwark.Type };
            }
            return new int[19];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                AACMod.TryFind<ModItem>("BrainScarf", out var BrainScarf);
                AACMod.TryFind<ModItem>("FrozenHeroShield", out var FrozenHeroShield);
                AACMod.TryFind<ModItem>("CelestialAnkh", out var CelestialAnkh);
                AACMod.TryFind<ModItem>("SlimeShield", out var SlimeShield);
                AACMod.TryFind<ModItem>("ObsidianCthulhuShield", out var ObsidianCthulhuShield);
                return new int[5] { BrainScarf.Type, FrozenHeroShield.Type, CelestialAnkh.Type, SlimeShield.Type, ObsidianCthulhuShield.Type };
            }
            return new int[5];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("SlimeShield", out var SlimeShield);
                Combinations.TryFind<ModItem>("MoltenShield", out var MoltenShield);
                return new int[2] { SlimeShield.Type, MoltenShield.Type };
            }
            return new int[2];
        }

        public static int[] GetStormsTypes()
        {
            if (ModLoader.TryGetMod("StormDiversMod", out var StormDiversMod))
            {
                StormDiversMod.TryFind<ModItem>("Celestialshield", out var Celestialshield);
                return new int[1] { Celestialshield.Type };
            }
            return new int[1];
        }

        public static int[] GetExpAccTypes()
        {
            if (ModLoader.TryGetMod("ExpertAccessoryExpansion", out var EAEMod))
            {
                EAEMod.TryFind<ModItem>("WormScarf", out var WormScarf);
                EAEMod.TryFind<ModItem>("EoCShield", out var EoCShield);
                EAEMod.TryFind<ModItem>("BrainOfConfusion", out var BrainOfConfusion);
                return new int[3] { WormScarf.Type, EoCShield.Type, BrainOfConfusion.Type };
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

        static UnitedSlotSystemDefence()
        {
            int[] obj = new int[88]
            {
                3999, 4003, 4004, 4038, 1921, 396, 158, 193, 3016, 3998, 938, 1253, 3997, 1613, 156, 397, 3097, 888, 3781, 5354, 892, 886, 901, 887, 885, 902, 889, 893, 903, 890, 891, 904, 1612, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // Calamity
                0, 0, // Calamity Fables
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // Thorium
                0, 0, 0, 0, 0, // AAC
                0, 0, // Combination
                0, // Storms
                0, 0, 0, // ExpAccExp
                0
            };
            obj[33] = CalamityTypes[0];
            obj[34] = CalamityTypes[1];
            obj[35] = CalamityTypes[2];
            obj[36] = CalamityTypes[3];
            obj[37] = CalamityTypes[4];
            obj[38] = CalamityTypes[5];
            obj[39] = CalamityTypes[6];
            obj[40] = CalamityTypes[7];
            obj[41] = CalamityTypes[8];
            obj[42] = CalamityTypes[9];
            obj[43] = CalamityTypes[10];
            obj[44] = CalamityTypes[11];
            obj[45] = CalamityTypes[12];
            obj[46] = CalamityTypes[13];
            obj[47] = CalamityTypes[14];
            obj[48] = CalamityTypes[15];
            obj[49] = CalamityTypes[16];
            obj[50] = CalamityTypes[17];
            obj[51] = CalamityTypes[18];
            obj[52] = CalamityTypes[19];
            obj[53] = CalamityTypes[20];
            obj[54] = CalamityTypes[21];
            obj[55] = CalamityFablesTypes[0];
            obj[56] = CalamityFablesTypes[1];
            obj[57] = ThoriumTypes[0];
            obj[58] = ThoriumTypes[1];
            obj[59] = ThoriumTypes[2];
            obj[60] = ThoriumTypes[3];
            obj[61] = ThoriumTypes[4];
            obj[62] = ThoriumTypes[5];
            obj[63] = ThoriumTypes[6];
            obj[64] = ThoriumTypes[7];
            obj[65] = ThoriumTypes[8];
            obj[66] = ThoriumTypes[9];
            obj[67] = ThoriumTypes[10];
            obj[68] = ThoriumTypes[11];
            obj[69] = ThoriumTypes[12];
            obj[70] = ThoriumTypes[13];
            obj[71] = ThoriumTypes[14];
            obj[72] = ThoriumTypes[15];
            obj[73] = ThoriumTypes[16];
            obj[74] = ThoriumTypes[17];
            obj[75] = ThoriumTypes[18];
            obj[76] = AACTypes[0];
            obj[77] = AACTypes[1];
            obj[78] = AACTypes[2];
            obj[79] = AACTypes[3];
            obj[80] = AACTypes[4];
            obj[81] = CombinationsTypes[0];
            obj[82] = CombinationsTypes[1];
            obj[83] = StormsTypes[0];
            obj[84] = ExpAccTypes[0];
            obj[85] = ExpAccTypes[1];
            obj[86] = ExpAccTypes[2];
            Items = obj;
        }
    }
}