using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class ImageSpaceAdapter
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IImageSpaceAdapterGetter> Construct(uint id) => new FormLink<IImageSpaceAdapterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImageSpaceAdapterGetter> VATSImodDOFFAR => Construct(0x931);
            public static FormLink<IImageSpaceAdapterGetter> VATSImodDOFClose => Construct(0x8cd);
        }
    }
}
