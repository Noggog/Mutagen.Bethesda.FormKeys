using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Npc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> dunBluePalaceWingEncGoatDomestic => Construct(0x804);
        }
    }
}
