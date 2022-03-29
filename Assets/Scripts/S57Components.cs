using System;
using Unity.Entities;
using Unity.Mathematics;
using Chart3D.Helper;
using Unity.Transforms;
using Unity.Rendering;
using System.Collections.Generic;
using UnityEngine;


namespace Chart3D.Components
{
    public struct SpriteRequestData : IComponentData 
    { 
        public float3 position;
        public int spriteIndex;
        public S57Symbol sprite;
    }
    struct SpriteRequestDataComparer : IComparer<SpriteRequestData>
    {
        public int Compare(SpriteRequestData a, SpriteRequestData b)
        {
            if (a.spriteIndex == b.spriteIndex)
            {
                return 0;
            }
            else
            {
                if (a.spriteIndex > b.spriteIndex)
                    return 1;
                else
                    return -1;
            }
        }
    }


    public struct S57SpriteShared : ISharedComponentData { public S57Symbol Value; }
    public struct S57Sprite : IComponentData { public S57Symbol Value; }
    public struct PrefabTag : IComponentData { }
    public struct SceneRootTag : IComponentData { }
    public struct SpriteRequestedTag : IComponentData { }

}





