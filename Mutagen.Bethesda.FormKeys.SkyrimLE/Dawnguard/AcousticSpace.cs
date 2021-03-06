using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class AcousticSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IAcousticSpaceGetter> Construct(uint id) => new FormLink<IAcousticSpaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAcousticSpaceGetter> DLC1IntFalmerValleyLargeStoneBossChapel => Construct(0x14c61);
            public static FormLink<IAcousticSpaceGetter> IntVampireCastleGuildhall => Construct(0xf695);
            public static FormLink<IAcousticSpaceGetter> IntDungeonDLC1DarkfallPassageAcousticSpace => Construct(0x18421);
            public static FormLink<IAcousticSpaceGetter> DLC1IntDarkDungeonCave => Construct(0x6b0d);
        }
    }
}
