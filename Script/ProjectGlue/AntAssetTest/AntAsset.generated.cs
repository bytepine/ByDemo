using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.AntAssetTest;

[UClass, GeneratedType("AntAsset", "UnrealSharp.AntAssetTest.AntAsset")]
public partial class UAntAsset : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UAntAsset()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AntAsset");
        IntPtr ScaleCurve_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ScaleCurve");
        ScaleCurve_Offset = FPropertyExporter.CallGetPropertyOffset(ScaleCurve_NativeProperty);
        IntPtr Mesh_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Mesh");
        Mesh_Offset = FPropertyExporter.CallGetPropertyOffset(Mesh_NativeProperty);
        IntPtr Num_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Num");
        Num_Offset = FPropertyExporter.CallGetPropertyOffset(Num_NativeProperty);
    }
    
    static int ScaleCurve_Offset;
    
    public UnrealSharp.Engine.FRuntimeFloatCurve ScaleCurve
    {
        get
        {
            return StructMarshaller<UnrealSharp.Engine.FRuntimeFloatCurve>.FromNative(IntPtr.Add(NativeObject, ScaleCurve_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.Engine.FRuntimeFloatCurve>.ToNative(IntPtr.Add(NativeObject, ScaleCurve_Offset), 0, value);
        }
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
    
    
    static int Num_Offset;
    
    public uint Num
    {
        get
        {
            return BlittableMarshaller<uint>.FromNative(IntPtr.Add(NativeObject, Num_Offset), 0);
        }
        set
        {
            BlittableMarshaller<uint>.ToNative(IntPtr.Add(NativeObject, Num_Offset), 0, value);
        }
    }
    
    
}