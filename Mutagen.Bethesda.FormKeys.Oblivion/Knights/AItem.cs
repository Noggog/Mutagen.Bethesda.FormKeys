using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> NDTitanShield => Construct(0xe91);
            public static FormLink<IAItemGetter> NDArmorLightShield5 => Construct(0xe92);
            public static FormLink<IAItemGetter> NDArmorLightHelmet5 => Construct(0xe93);
            public static FormLink<IAItemGetter> NDArmorLightGreaves5 => Construct(0xe94);
            public static FormLink<IAItemGetter> NDArmorLightGauntlets5 => Construct(0xe95);
            public static FormLink<IAItemGetter> NDArmorLightCuirass5 => Construct(0xe96);
            public static FormLink<IAItemGetter> NDArmorLightBoots5 => Construct(0xe97);
            public static FormLink<IAItemGetter> NDArmorLightShield4 => Construct(0xe98);
            public static FormLink<IAItemGetter> NDArmorLightHelmet4 => Construct(0xe99);
            public static FormLink<IAItemGetter> NDArmorLightGreaves4 => Construct(0xe9a);
            public static FormLink<IAItemGetter> NDArmorLightGauntlets4 => Construct(0xe9b);
            public static FormLink<IAItemGetter> NDArmorLightCuirass4 => Construct(0xe9c);
            public static FormLink<IAItemGetter> NDArmorLightBoots4 => Construct(0xe9d);
            public static FormLink<IAItemGetter> NDArmorLightShield3 => Construct(0xe9e);
            public static FormLink<IAItemGetter> NDArmorLightHelmet3 => Construct(0xe9f);
            public static FormLink<IAItemGetter> NDArmorLightGreaves3 => Construct(0xea0);
            public static FormLink<IAItemGetter> NDArmorLightGauntlets3 => Construct(0xea1);
            public static FormLink<IAItemGetter> NDArmorLightCuirass3 => Construct(0xea2);
            public static FormLink<IAItemGetter> NDArmorLightBoots3 => Construct(0xea3);
            public static FormLink<IAItemGetter> NDArmorLightShield2 => Construct(0xea4);
            public static FormLink<IAItemGetter> NDArmorLightHelmet2 => Construct(0xea5);
            public static FormLink<IAItemGetter> NDArmorLightGreaves2 => Construct(0xea6);
            public static FormLink<IAItemGetter> NDArmorLightGauntlets2 => Construct(0xea7);
            public static FormLink<IAItemGetter> NDArmorLightCuirass2 => Construct(0xea8);
            public static FormLink<IAItemGetter> NDArmorLightBoots2 => Construct(0xea9);
            public static FormLink<IAItemGetter> NDArmorLightShield1 => Construct(0xeaa);
            public static FormLink<IAItemGetter> NDArmorLightHelmet1 => Construct(0xeab);
            public static FormLink<IAItemGetter> NDArmorLightGreaves1 => Construct(0xeac);
            public static FormLink<IAItemGetter> NDArmorLightGauntlets1 => Construct(0xead);
            public static FormLink<IAItemGetter> NDArmorLightCuirass1 => Construct(0xeae);
            public static FormLink<IAItemGetter> NDArmorLightBoots1 => Construct(0xeaf);
            public static FormLink<IAItemGetter> NDArmorHeavyShield5 => Construct(0xeb0);
            public static FormLink<IAItemGetter> NDArmorHeavyHelmet5 => Construct(0xeb1);
            public static FormLink<IAItemGetter> NDArmorHeavyGreaves5 => Construct(0xeb2);
            public static FormLink<IAItemGetter> NDArmorHeavyGauntlets5 => Construct(0xeb3);
            public static FormLink<IAItemGetter> NDArmorHeavyCuirass5 => Construct(0xeb4);
            public static FormLink<IAItemGetter> NDArmorHeavyBoots5 => Construct(0xeb5);
            public static FormLink<IAItemGetter> NDArmorHeavyShield4 => Construct(0xeb6);
            public static FormLink<IAItemGetter> NDArmorHeavyHelmet4 => Construct(0xeb7);
            public static FormLink<IAItemGetter> NDArmorHeavyGreaves4 => Construct(0xeb8);
            public static FormLink<IAItemGetter> NDArmorHeavyGauntlets4 => Construct(0xeb9);
            public static FormLink<IAItemGetter> NDArmorHeavyCuirass4 => Construct(0xeba);
            public static FormLink<IAItemGetter> NDArmorHeavyBoots4 => Construct(0xebb);
            public static FormLink<IAItemGetter> NDArmorHeavyShield3 => Construct(0xebc);
            public static FormLink<IAItemGetter> NDArmorHeavyHelmet3 => Construct(0xebd);
            public static FormLink<IAItemGetter> NDArmorHeavyGreaves3 => Construct(0xebe);
            public static FormLink<IAItemGetter> NDArmorHeavyGauntlets3 => Construct(0xebf);
            public static FormLink<IAItemGetter> NDArmorHeavyCuirass3 => Construct(0xec0);
            public static FormLink<IAItemGetter> NDArmorHeavyBoots3 => Construct(0xec1);
            public static FormLink<IAItemGetter> NDArmorHeavyShield2 => Construct(0xec2);
            public static FormLink<IAItemGetter> NDArmorHeavyHelmet2 => Construct(0xec3);
            public static FormLink<IAItemGetter> NDArmorHeavyGreaves2 => Construct(0xec4);
            public static FormLink<IAItemGetter> NDArmorHeavyGauntlets2 => Construct(0xec5);
            public static FormLink<IAItemGetter> NDArmorHeavyCuirass2 => Construct(0xec6);
            public static FormLink<IAItemGetter> NDArmorHeavyBoots2 => Construct(0xec7);
            public static FormLink<IAItemGetter> NDKnightsShield => Construct(0xec8);
            public static FormLink<IAItemGetter> NDKnightsCuirass => Construct(0xec9);
            public static FormLink<IAItemGetter> NDArmorHeavyShield1 => Construct(0xeca);
            public static FormLink<IAItemGetter> NDArmorHeavyHelmet1 => Construct(0xecb);
            public static FormLink<IAItemGetter> NDArmorHeavyGreaves1 => Construct(0xecc);
            public static FormLink<IAItemGetter> NDArmorHeavyGauntlets1 => Construct(0xecd);
            public static FormLink<IAItemGetter> NDArmorHeavyCuirass1 => Construct(0xece);
            public static FormLink<IAItemGetter> NDArmorHeavyBoots1 => Construct(0xecf);
            public static FormLink<IAItemGetter> ND05ConjurerNote2 => Construct(0xed0);
            public static FormLink<IAItemGetter> ND05ConjurerNote1 => Construct(0xed1);
            public static FormLink<IAItemGetter> NDBook3ValuableKnightsoftheNine => Construct(0xed2);
            public static FormLink<IAItemGetter> NDBook4RareAdabala => Construct(0xed3);
            public static FormLink<IAItemGetter> NDBook3ValuableShezarr => Construct(0xed4);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV8 => Construct(0xed5);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV7 => Construct(0xed6);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV6 => Construct(0xed7);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV5 => Construct(0xed8);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV4 => Construct(0xed9);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV3 => Construct(0xeda);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV2 => Construct(0xedb);
            public static FormLink<IAItemGetter> NDBook2ReligiousSongofPelinalV1 => Construct(0xedc);
            public static FormLink<IAItemGetter> NDWayshrineMap => Construct(0xedd);
            public static FormLink<IAItemGetter> ND01SirAmielsJournal => Construct(0xede);
            public static FormLink<IAItemGetter> ND01RedDiamondRing => Construct(0xedf);
            public static FormLink<IAItemGetter> NDGarlasDaylight450 => Construct(0xef9);
            public static FormLink<IAItemGetter> ChorrolLightSoftYellow128 => Construct(0xefa);
            public static FormLink<IAItemGetter> CathedralCryptLight01Grey128 => Construct(0xefb);
            public static FormLink<IAItemGetter> CathedralCryptLight02Gray256 => Construct(0xefc);
            public static FormLink<IAItemGetter> CathedralCryptLight01Grey256 => Construct(0xefd);
            public static FormLink<IAItemGetter> NDSconceOFF => Construct(0xefe);
            public static FormLink<IAItemGetter> STorWhiteBright600 => Construct(0xeff);
            public static FormLink<IAItemGetter> CommonLightGrey512 => Construct(0xf00);
            public static FormLink<IAItemGetter> CommonLightGrey384 => Construct(0xf01);
            public static FormLink<IAItemGetter> NDPilgrimLight => Construct(0xf02);
            public static FormLink<IAItemGetter> ND05MiscStone => Construct(0xf03);
            public static FormLink<IAItemGetter> ND05MiscGem => Construct(0xf04);
            public static FormLink<IAItemGetter> ND05MiscSkull => Construct(0xf05);
            public static FormLink<IAItemGetter> ND05MiscHammer => Construct(0xf06);
            public static FormLink<IAItemGetter> ND05MiscBook => Construct(0xf07);
            public static FormLink<IAItemGetter> ND05MiscGoblet => Construct(0xf08);
            public static FormLink<IAItemGetter> ND05MiscHelm => Construct(0xf09);
            public static FormLink<IAItemGetter> ND05MiscSword => Construct(0xf0a);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward5 => Construct(0xf20);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward6 => Construct(0xf21);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward7 => Construct(0xf22);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward8 => Construct(0xf23);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward4 => Construct(0xf24);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward3 => Construct(0xf25);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward2 => Construct(0xf26);
            public static FormLink<IAItemGetter> NDUmarilClaymoreReward1 => Construct(0xf27);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe8Daedric => Construct(0xf28);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe7Ebony => Construct(0xf29);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe6Glass => Construct(0xf2a);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe4Dwarven => Construct(0xf2b);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe3Silver => Construct(0xf2c);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe2Steel => Construct(0xf2d);
            public static FormLink<IAItemGetter> NDAuroranBattleAxe5Elven => Construct(0xf2e);
            public static FormLink<IAItemGetter> NDWeaponSwordPelinal => Construct(0xf2f);
            public static FormLink<IAItemGetter> NDWeaponSword2 => Construct(0xf30);
            public static FormLink<IAItemGetter> NDWeaponSword3 => Construct(0xf31);
            public static FormLink<IAItemGetter> NDWeaponMace2 => Construct(0xf32);
            public static FormLink<IAItemGetter> NDWeaponMace3 => Construct(0xf33);
            public static FormLink<IAItemGetter> NDUmarilClaymore1 => Construct(0xf34);
            public static FormLink<IAItemGetter> NDUmarilClaymore8 => Construct(0xf35);
            public static FormLink<IAItemGetter> NDUmarilClaymore7 => Construct(0xf36);
            public static FormLink<IAItemGetter> NDUmarilClaymore6 => Construct(0xf37);
            public static FormLink<IAItemGetter> NDUmarilClaymore5 => Construct(0xf38);
            public static FormLink<IAItemGetter> NDUmarilClaymore4 => Construct(0xf39);
            public static FormLink<IAItemGetter> NDUmarilClaymore3 => Construct(0xf3a);
            public static FormLink<IAItemGetter> NDUmarilClaymore2 => Construct(0xf3b);
            public static FormLink<IAItemGetter> NDTitanKatana => Construct(0xf3c);
            public static FormLink<IAItemGetter> NDWeaponSword7 => Construct(0xf3d);
            public static FormLink<IAItemGetter> NDWeaponSword6 => Construct(0xf3e);
            public static FormLink<IAItemGetter> NDWeaponSword5 => Construct(0xf3f);
            public static FormLink<IAItemGetter> NDWeaponMace6 => Construct(0xf40);
            public static FormLink<IAItemGetter> NDWeaponMace5 => Construct(0xf41);
            public static FormLink<IAItemGetter> NDWeaponMace4 => Construct(0xf42);
            public static FormLink<IAItemGetter> NDWeaponSword4 => Construct(0xf43);
            public static FormLink<IAItemGetter> ND08WeaponSword4 => Construct(0xf44);
            public static FormLink<IAItemGetter> ND08WeaponSword3 => Construct(0xf45);
            public static FormLink<IAItemGetter> ND08WeaponSword2 => Construct(0xf46);
            public static FormLink<IAItemGetter> ND08WeaponSword1 => Construct(0xf47);
            public static FormLink<IAItemGetter> NDWeaponMace7 => Construct(0xf48);
            public static FormLink<IAItemGetter> ND08WeaponSword5 => Construct(0xf49);
            public static FormLink<IAItemGetter> NDWeaponSword8 => Construct(0xf4a);
            public static FormLink<IAItemGetter> NDWeaponMace8 => Construct(0xf4b);
            public static FormLink<IAItemGetter> ND05FortKey => Construct(0xfbf);
            public static FormLink<IAItemGetter> ND01AmielKey => Construct(0xfc0);
            public static FormLink<IAItemGetter> ND02PrioryKey => Construct(0xfc1);
            public static FormLink<IAItemGetter> NDLL0LootGems25 => Construct(0xfc2);
            public static FormLink<IAItemGetter> NDUmarilSwordReward100 => Construct(0xfc3);
            public static FormLink<IAItemGetter> NDLL0AuroranWeapon100 => Construct(0xfc4);
            public static FormLink<IAItemGetter> NDLL0ArmorLightCuirass => Construct(0xfc5);
            public static FormLink<IAItemGetter> NDLL0ArmorLightHelmet => Construct(0xfc6);
            public static FormLink<IAItemGetter> NDLL0ArmorLightGreaves => Construct(0xfc7);
            public static FormLink<IAItemGetter> NDLL0ArmorLightGauntlets => Construct(0xfc8);
            public static FormLink<IAItemGetter> NDLL0WeaponMaceLvl100 => Construct(0xfc9);
            public static FormLink<IAItemGetter> NDLL0WeaponSwordLvl100 => Construct(0xfca);
            public static FormLink<IAItemGetter> NDLL0ArmorHeavyShield => Construct(0xfcb);
            public static FormLink<IAItemGetter> NDLL0ArmorHeavyHelmet => Construct(0xfcc);
            public static FormLink<IAItemGetter> NDLL0ArmorHeavyGreaves => Construct(0xfcd);
            public static FormLink<IAItemGetter> NDLL0ArmorHeavyGauntlets => Construct(0xfce);
            public static FormLink<IAItemGetter> NDLL0ArmorHeavyCuirass => Construct(0xfcf);
            public static FormLink<IAItemGetter> NDLL0ArmorHeavyBoots => Construct(0xfd0);
            public static FormLink<IAItemGetter> NDLL0ArmorLightShield => Construct(0xfd1);
            public static FormLink<IAItemGetter> NDLL0ArmorLightBoots => Construct(0xfd2);
        }
    }
}
