using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> SDoorManholeCoverInvisible => Construct(0x308b);
            public static FormLink<IDoorGetter> ccEEJSSE003_RiftenRWDoorLoad01 => Construct(0x2fca);
            public static FormLink<IDoorGetter> ccEEJSSE003_RiftenRWDoorJail01 => Construct(0x2fc8);
            public static FormLink<IDoorGetter> ccBGSSSE043_FarmBTrapdoor01 => Construct(0x2fc6);
            public static FormLink<IDoorGetter> ccBGSSSE043_FarmBTrapdoor02 => Construct(0x2fc5);
            public static FormLink<IDoorGetter> CreationClubPlaceHolderDoor => Construct(0x2f3b);
        }
    }
}
