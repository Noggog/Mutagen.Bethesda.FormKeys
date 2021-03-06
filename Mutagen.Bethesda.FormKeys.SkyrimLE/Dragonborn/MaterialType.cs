using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class MaterialType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMaterialTypeGetter> Construct(uint id) => new FormLink<IMaterialTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMaterialTypeGetter> MaterialAsh => Construct(0x18c9c);
        }
    }
}
