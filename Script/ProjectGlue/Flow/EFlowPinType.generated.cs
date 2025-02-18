using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowPinType", "UnrealSharp.Flow.EFlowPinType")]
public enum EFlowPinType : byte
{
    /// <summary>
    /// Execution pin
    /// </summary>
    Exec = 0,
    /// <summary>
    /// FBoolProperty
    /// </summary>
    Bool = 1,
    /// <summary>
    /// FByteProperty FInt16Property FIntProperty FInt64Property FUInt16Property FUInt32Property FUInt64Property
    /// </summary>
    Int = 2,
    /// <summary>
    /// FFloatProperty, FDoubleProperty
    /// </summary>
    Float = 3,
    /// <summary>
    /// FNameProperty
    /// </summary>
    Name = 4,
    /// <summary>
    /// FStringProperty
    /// </summary>
    String = 5,
    /// <summary>
    /// FTextProperty
    /// </summary>
    Text = 6,
    /// <summary>
    /// FEnumProperty, FByteProperty
    /// </summary>
    Enum = 7,
    /// <summary>
    /// FVector (FStructProperty)
    /// </summary>
    Vector = 8,
    /// <summary>
    /// FRotator (FStructProperty)
    /// </summary>
    Rotator = 9,
    /// <summary>
    /// FTransform (FStructProperty)
    /// </summary>
    Transform = 10,
    /// <summary>
    /// FGameplayTag (FStructProperty)
    /// </summary>
    GameplayTag = 11,
    /// <summary>
    /// FGameplayTagContainer (FStructProperty)
    /// </summary>
    GameplayTagContainer = 12,
    /// <summary>
    /// FInstancedStruct (FStructProperty)
    /// </summary>
    InstancedStruct = 13,
    /// <summary>
    /// FObjectProperty, FObjectPtrProperty, FWeakObjectProperty, FLazyObjectProperty, FSoftObjectProperty
    /// </summary>
    Object = 14,
    /// <summary>
    /// FClassProperty, FClassPtrProperty, FSoftClassProperty
    /// </summary>
    Class = 15,
    Max = 16,
    Invalid = 17,
    Min = 0,
}