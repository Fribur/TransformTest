using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;

namespace Chart3D.Components
{
    public static class Blueprints
    {
        public static BuiltinMaterialPropertyUnity_RenderingLayer _RenderingLayer = new BuiltinMaterialPropertyUnity_RenderingLayer { Value = new uint4(1, 0, 0, 0) };
        public static BuiltinMaterialPropertyUnity_WorldTransformParams _WorldTransformParams = new BuiltinMaterialPropertyUnity_WorldTransformParams { Value = new float4(0, 0, 0, 1) };
        public static BuiltinMaterialPropertyUnity_LightData _LightData = new BuiltinMaterialPropertyUnity_LightData { Value = new float4(0, 0, 1, 0) };

        public static ComponentType[] RequestedSpriteComponents = new ComponentType[]
        {
            typeof(SpriteRequestData),
        };

        public static ComponentType[] SpritePrefab1 = new ComponentType[]
        {
                typeof(PrefabTag),
                typeof(WorldToLocal_Tag),
                typeof(PerInstanceCullingTag),
                typeof(AmbientProbeTag),
                //typeof(BuiltinMaterialPropertyUnity_LightData),
                //typeof(BuiltinMaterialPropertyUnity_RenderingLayer),
                //typeof(BuiltinMaterialPropertyUnity_WorldTransformParams),
                typeof(LocalToWorld),
                typeof(Rotation),
                typeof(Parent),
                typeof(LocalToParent),
        };
        public static ComponentType[] SpritePrefab2 = new ComponentType[]
        {
                typeof(PrefabTag),
                typeof(WorldToLocal_Tag),
                typeof(PerInstanceCullingTag),
                typeof(AmbientProbeTag),
                //typeof(BuiltinMaterialPropertyUnity_LightData),
                //typeof(BuiltinMaterialPropertyUnity_RenderingLayer),
                //typeof(BuiltinMaterialPropertyUnity_WorldTransformParams),
                typeof(LocalToWorld),
                typeof(Rotation),
        };
    };
}
