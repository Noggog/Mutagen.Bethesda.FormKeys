using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IGameSettingGetter> Construct(uint id) => new FormLink<IGameSettingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> fPathMinimalUseDoorPenalty => Construct(0xa468);
        }
    }
}
