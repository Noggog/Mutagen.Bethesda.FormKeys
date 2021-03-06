using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Climate
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IClimateGetter> Construct(uint id) => new FormLink<IClimateGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClimateGetter> KarthspireClimate => Construct(0xf91);
            public static FormLink<IClimateGetter> BloatedMansClimate => Construct(0xe7c4e);
            public static FormLink<IClimateGetter> SovngardeClimate => Construct(0x90a91);
            public static FormLink<IClimateGetter> BlackreachClimate => Construct(0x239fb);
            public static FormLink<IClimateGetter> SkyrimClimate => Construct(0x812);
            public static FormLink<IClimateGetter> DefaultClimate => Construct(0x15f);
        }
    }
}
