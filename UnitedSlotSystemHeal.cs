using System;
using Terraria;
using Terraria.ModLoader;
using USSR;
using USSR.AccessorySlots;

namespace USSR
{
    internal class UnitedSlotSystemHeal : GlobalItem
    {
        public static int[] Items;

        public static int[] CalamityTypes = GetCalamityTypes();
        public static int[] CalamityFablesTypes = GetCalamityFablesTypes();
        public static int[] ThoriumTypes = GetThoriumTypes();
        public static int[] AACTypes = GetAACTypes();
        public static int[] CombinationsTypes = GetCombinationsTypes();
        public static int[] StormsTypes = GetStormsTypes();
        public static int[] ConsolariaTypes = GetConsolariaTypes();

        public static int[] GetCalamityTypes()
        {

            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("BloodPact", out var BloodPact);
                CalamityMod.TryFind<ModItem>("AmbrosialAmpoule", out var AmbrosialAmpoule);
                CalamityMod.TryFind<ModItem>("CleansingJelly", out var CleansingJelly);
                CalamityMod.TryFind<ModItem>("HoneyDew", out var HoneyDew);
                CalamityMod.TryFind<ModItem>("CrownJewel", out var CrownJewel);
                CalamityMod.TryFind<ModItem>("GladiatorsLocket", out var GladiatorsLocket);
                CalamityMod.TryFind<ModItem>("GrandGelatin", out var GrandGelatin);
                CalamityMod.TryFind<ModItem>("LifeJelly", out var LifeJelly);
                CalamityMod.TryFind<ModItem>("LivingDew", out var LivingDew);
                CalamityMod.TryFind<ModItem>("InfectedJewel", out var InfectedJewel);
                CalamityMod.TryFind<ModItem>("RadiantOoze", out var RadiantOoze);
                CalamityMod.TryFind<ModItem>("TrinketofChi", out var TrinketofChi);
                CalamityMod.TryFind<ModItem>("VitalJelly", out var VitalJelly);
                CalamityMod.TryFind<ModItem>("Radiance", out var Radiance);
                CalamityMod.TryFind<ModItem>("Regenator", out var Regenator);
                CalamityMod.TryFind<ModItem>("ChaliceOfTheBloodGod", out var ChaliceOfTheBloodGod);
                CalamityMod.TryFind<ModItem>("TheAbsorber", out var TheAbsorber);
                CalamityMod.TryFind<ModItem>("BloomStone", out var BloomStone);
                CalamityMod.TryFind<ModItem>("PermafrostsConcoction", out var PermafrostsConcoction);
                CalamityMod.TryFind<ModItem>("DraedonsHeart", out var DraedonsHeart);
                CalamityMod.TryFind<ModItem>("TheCamper", out var TheCamper);
                CalamityMod.TryFind<ModItem>("NebulousCore", out var NebulousCore);
                return new int[22] { BloodPact.Type, AmbrosialAmpoule.Type, CleansingJelly.Type, HoneyDew.Type, CrownJewel.Type, GladiatorsLocket.Type, GrandGelatin.Type, LifeJelly.Type, LivingDew.Type, InfectedJewel.Type, RadiantOoze.Type, TrinketofChi.Type, VitalJelly.Type, Radiance.Type, Regenator.Type, ChaliceOfTheBloodGod.Type, TheAbsorber.Type, BloomStone.Type, PermafrostsConcoction.Type, DraedonsHeart.Type, TheCamper.Type, NebulousCore.Type };
            }
            return new int[22];
        }

        public static int[] GetCalamityFablesTypes()
        {
            if (ModLoader.TryGetMod("CalamityFables", out var CalamityFables))
            {
                CalamityFables.TryFind<ModItem>("LuminousMixture", out var LuminousMixture);
                return new int[1] { LuminousMixture.Type };
            }
            return new int[1];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("MonsterCharm", out var MonsterCharm);
                ThoriumMod.TryFind<ModItem>("Phylactery", out var Phylactery);
                ThoriumMod.TryFind<ModItem>("NecromancersHeart", out var NecromancersHeart);
                ThoriumMod.TryFind<ModItem>("PotionChaser", out var PotionChaser);
                ThoriumMod.TryFind<ModItem>("SalamanderEye", out var SalamanderEye);
                ThoriumMod.TryFind<ModItem>("BandofReplenishment", out var BandofReplenishment);
                ThoriumMod.TryFind<ModItem>("VampireGland", out var VampireGland);
                return new int[7] { MonsterCharm.Type, Phylactery.Type, NecromancersHeart.Type, PotionChaser.Type, SalamanderEye.Type, BandofReplenishment.Type, VampireGland.Type };
            }
            return new int[7];
        }

        public static int[] GetAACTypes()
        {
            if (ModLoader.TryGetMod("AdvancedAccessoryCombinations", out var AACMod))
            {
                AACMod.TryFind<ModItem>("HardenedBand", out var HardenedBand);
                return new int[1]
                { HardenedBand.Type };
            }
            return new int[1];
        }

        public static int[] GetCombinationsTypes()
        {
            if (ModLoader.TryGetMod("Combinations", out var Combinations))
            {
                Combinations.TryFind<ModItem>("ArchmagiLuminarium", out var ArchmagiLuminarium);
                return new int[1] { ArchmagiLuminarium.Type };
            }
            return new int[1];
        }

        public static int[] GetStormsTypes()
        {
            if (ModLoader.TryGetMod("StormDiversMod", out var StormDiversMod))
            {
                StormDiversMod.TryFind<ModItem>("HeartJar", out var HeartJar);
                StormDiversMod.TryFind<ModItem>("HeartJarPS", out var HeartJarPS);
                StormDiversMod.TryFind<ModItem>("SpectreAccessory", out var SpectreAccessory);
                StormDiversMod.TryFind<ModItem>("SpectreAccessoryMagnet", out var SpectreAccessoryMagnet);
                StormDiversMod.TryFind<ModItem>("Celestialshield", out var Celestialshield);
                return new int[5] { HeartJar.Type, HeartJarPS.Type, SpectreAccessory.Type, SpectreAccessoryMagnet.Type, Celestialshield.Type };
            }
            return new int[5];
        }

        public static int[] GetConsolariaTypes()
        {
            if (ModLoader.TryGetMod("Consolaria", out var Consolaria))
            {
                Consolaria.TryFind<ModItem>("OstarasGift", out var OstarasGift);
                Consolaria.TryFind<ModItem>("ValentineRing", out var ValentineRing);
                return new int[2] { OstarasGift.Type, ValentineRing.Type };
            }
            return new int[2];
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

        static UnitedSlotSystemHeal()
        {
            int[] obj = new int[55]
            {
                3991, 49, 111, 2221, 2219, 2220, 860, 1595, 4000, 4001, 555, 982, 223, 535, 3337, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // Calamity
                0, // Calamity Fables
                0, 0, 0, 0, 0, 0, 0, // Thorium
                0, // AAC
                0, // Combination
                0, 0, 0, 0, 0, // Storms
                0, 0, // Consolaria
                0
            };
            obj[15] = CalamityTypes[0];
            obj[16] = CalamityTypes[1];
            obj[17] = CalamityTypes[2];
            obj[18] = CalamityTypes[3];
            obj[19] = CalamityTypes[4];
            obj[20] = CalamityTypes[5];
            obj[21] = CalamityTypes[6];
            obj[22] = CalamityTypes[7];
            obj[23] = CalamityTypes[8];
            obj[24] = CalamityTypes[9];
            obj[25] = CalamityTypes[10];
            obj[26] = CalamityTypes[11];
            obj[27] = CalamityTypes[12];
            obj[28] = CalamityTypes[13];
            obj[29] = CalamityTypes[14];
            obj[30] = CalamityTypes[15];
            obj[31] = CalamityTypes[16];
            obj[32] = CalamityTypes[17];
            obj[33] = CalamityTypes[18];
            obj[34] = CalamityTypes[19];
            obj[35] = CalamityTypes[20];
            obj[36] = CalamityTypes[21];
            obj[37] = CalamityFablesTypes[0];
            obj[38] = ThoriumTypes[0];
            obj[39] = ThoriumTypes[1];
            obj[40] = ThoriumTypes[2];
            obj[41] = ThoriumTypes[3];
            obj[42] = ThoriumTypes[4];
            obj[43] = ThoriumTypes[5];
            obj[44] = ThoriumTypes[6];
            obj[45] = AACTypes[0];
            obj[46] = CombinationsTypes[0];
            obj[47] = StormsTypes[0];
            obj[48] = StormsTypes[1];
            obj[49] = StormsTypes[2];
            obj[50] = StormsTypes[3];
            obj[51] = StormsTypes[4];
            obj[52] = ConsolariaTypes[0];
            obj[53] = ConsolariaTypes[1];
            Items = obj;
        }
    }
}
