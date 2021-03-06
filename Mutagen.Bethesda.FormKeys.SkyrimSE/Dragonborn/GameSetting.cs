using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IGameSettingGetter> Construct(uint id) => new FormLink<IGameSettingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> sTESVDLC2FlyingMountLandingMessage => Construct(0x1e2bb);
            public static FormLink<IGameSettingGetter> sTESVDLC2FlyingMountCannotLandMessage => Construct(0x1e2ba);
            public static FormLink<IGameSettingGetter> sTESVDLC2FlyingMountCancelLandingMessage => Construct(0x1e2b9);
            public static FormLink<IGameSettingGetter> sTESVDLC2FlyingDragonNoCastMessage => Construct(0x1e2b8);
            public static FormLink<IGameSettingGetter> sTESVDLC2DragonUnableToFlyMessage => Construct(0x1e2b7);
        }
    }
}
