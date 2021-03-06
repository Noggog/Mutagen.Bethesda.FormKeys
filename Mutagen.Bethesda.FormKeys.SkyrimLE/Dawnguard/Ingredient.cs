using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngredientGetter> DLC1MountainFlower01Yellow => Construct(0x2a78);
            public static FormLink<IIngredientGetter> DLC01PoisonBloom => Construct(0x185fb);
            public static FormLink<IIngredientGetter> DLC01ChaurusHunterAntennae => Construct(0x183b7);
            public static FormLink<IIngredientGetter> DLC01GlowPlant01Ingredient => Construct(0xb097);
            public static FormLink<IIngredientGetter> DLC01MothWingAncestor => Construct(0x59ba);
        }
    }
}
