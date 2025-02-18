using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EExecuteComponentSource", "UnrealSharp.Flow.EExecuteComponentSource")]
public enum EExecuteComponentSource : byte
{
    Undetermined = 0,
    BindToExisting = 1,
    InjectFromTemplate = 2,
    InjectFromClass = 3,
    Max = 4,
    Invalid = 5,
    Min = 0,
    UsesInjectManagerFirst,
    UsesInjectManagerLast,
}