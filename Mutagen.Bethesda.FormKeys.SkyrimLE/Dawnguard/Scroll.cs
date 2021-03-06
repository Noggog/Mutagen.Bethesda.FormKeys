using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Scroll
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IScrollGetter> Construct(uint id) => new FormLink<IScrollGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScrollGetter> DLC1dunRedwaterDenTelekinesisScroll => Construct(0x14042);
        }
    }
}
