using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.AntTestEdMode;

[UClass, GeneratedType("AntTestEdModeObject", "UnrealSharp.AntTestEdMode.AntTestEdModeObject")]
public partial class UAntTestEdModeObject : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UAntTestEdModeObject()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AntTestEdModeObject");
        IntPtr Mesh_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Mesh");
        Mesh_Offset = FPropertyExporter.CallGetPropertyOffset(Mesh_NativeProperty);
    }
    
    static int Mesh_Offset;
    
    public UnrealSharp.Engine.UStaticMesh Mesh
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Engine.UStaticMesh>.FromNative(IntPtr.Add(NativeObject, Mesh_Offset), 0);
        }
        set
        {
            ObjectMarshaller<UnrealSharp.Engine.UStaticMesh>.ToNative(IntPtr.Add(NativeObject, Mesh_Offset), 0, value);
        }
    }
    
    
}