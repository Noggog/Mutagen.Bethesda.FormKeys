using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MaterialObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMaterialObjectGetter> Construct(uint id) => new FormLink<IMaterialObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMaterialObjectGetter> DLC02IceShader01 => Construct(0x3b396);
            public static FormLink<IMaterialObjectGetter> DLC2AshMaterialDusting1P => Construct(0x3a11d);
            public static FormLink<IMaterialObjectGetter> DLC2SnowMaterialLakeSurface => Construct(0x33edb);
            public static FormLink<IMaterialObjectGetter> AshLODMaterialMtns1P => Construct(0x32720);
            public static FormLink<IMaterialObjectGetter> AshMaterialSolstheimLight1P => Construct(0x2ad46);
            public static FormLink<IMaterialObjectGetter> AshMaterialSolstheimMtns1P => Construct(0x24fe0);
            public static FormLink<IMaterialObjectGetter> MossMaterialSolstheim01 => Construct(0x1be2d);
            public static FormLink<IMaterialObjectGetter> AshMaterialSolstheim1P => Construct(0x16e0c);
        }
    }
}
