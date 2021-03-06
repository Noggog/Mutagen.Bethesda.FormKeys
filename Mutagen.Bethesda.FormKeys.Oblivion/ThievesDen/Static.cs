using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> redsaberinterior => Construct(0x138cd);
            public static FormLink<IStaticGetter> pirateflag02 => Construct(0x138d2);
            public static FormLink<IStaticGetter> redsaberTop01 => Construct(0x138ca);
            public static FormLink<IStaticGetter> pirateflag => Construct(0x138cb);
            public static FormLink<IStaticGetter> redsaber01 => Construct(0x138cc);
        }
    }
}
