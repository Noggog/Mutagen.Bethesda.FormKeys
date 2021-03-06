using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> DLCHorseArmor => Construct(0xcec);
        }
    }
}
