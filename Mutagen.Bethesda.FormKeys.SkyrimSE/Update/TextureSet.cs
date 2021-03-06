using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class TextureSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<ITextureSetGetter> Construct(uint id) => new FormLink<ITextureSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITextureSetGetter> LandscapeMountainSlab02Mask => Construct(0x2e34);
            public static FormLink<ITextureSetGetter> LandscapeMountainSlab01Mask => Construct(0x2e33);
            public static FormLink<ITextureSetGetter> LandscapeDirtCliffs01Mask => Construct(0x2e32);
            public static FormLink<ITextureSetGetter> LandscapeSnow02Landscape => Construct(0x2ca1);
            public static FormLink<ITextureSetGetter> LandscapeSnow01Landscape => Construct(0x2ca0);
        }
    }
}
