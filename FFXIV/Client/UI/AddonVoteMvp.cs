using FFXIVClientStructs.FFXIV.Component.GUI;
using System.Runtime.InteropServices;

namespace FFXIVClientStructs.FFXIV.Client.UI
{
    // Client::UI::AddonVoteMvp
    //   Component::GUI::AtkUnitBase
    //     Component::GUI::AtkEventListener
    [StructLayout(LayoutKind.Explicit, Size = 0x260)]
    public unsafe struct AddonVoteMvp
    {
        [FieldOffset(0x0)] public AtkUnitBase AtkUnitBase;
        [FieldOffset(0x220)] public AtkComponentButton* VoteButton;
        [FieldOffset(0x228)] public AtkComponentCheckBox* check1;
        [FieldOffset(0x230)] public AtkComponentCheckBox* check2;
        [FieldOffset(0x238)] public AtkComponentCheckBox* check3;
        [FieldOffset(0x240)] public AtkComponentCheckBox* check4;
        [FieldOffset(0x248)] public AtkComponentCheckBox* check5;
        [FieldOffset(0x250)] public AtkComponentCheckBox* check6;
        [FieldOffset(0x258)] public AtkComponentCheckBox* check7;
    }
}