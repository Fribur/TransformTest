//using Unity.Entities;
//using Unity.Rendering;
//using UnityEngine;
//using UnityEngine.Rendering;
//using UnityEngine.U2D;
//using Chart3D.Helper;
//using System.Collections.Generic;
//using Chart3D.Components;
//using Unity.Collections;
//using Unity.Transforms;
//using Unity.Mathematics;

//public partial class SpriteSpawner : SystemBase
//{
//    bool spawnUnderSceneRoot = false;

//    EntityManager _entityManager;
//    EntityArchetype SpritePrefab1Archetype, SpritePrefab2Archetype;
//    SpriteAtlas PointFeatureAtlas;
//    Sprite[] PointFeatureSpriteArray;
//    Material _material, PointSpritesMaterial;
//    EntityQuery SpriteQuery;
//    EntityQueryDesc PrefabQueryDesc;
//    S57Symbol tempSymbol;
//    Dictionary<S57Symbol, RenderMesh> SpriteRenderMeshDictionary;
//    public Dictionary<S57Symbol, Sprite> SpriteDictionary;


//    protected override void OnCreate()
//    {
//        _entityManager = World.EntityManager;

//        //Create Dictionary SpriteID, RenderMesh
//        _material = Resources.Load("Materials/SpriteMaterial", typeof(Material)) as Material;

//        PointFeatureAtlas = Resources.Load<SpriteAtlas>("PointFeatures");
//        PointFeatureSpriteArray = new Sprite[PointFeatureAtlas.spriteCount];
//        PointFeatureAtlas.GetSprites(PointFeatureSpriteArray);
//        PointSpritesMaterial = Material.Instantiate(_material);
//        PointSpritesMaterial.SetTexture("SpriteTexture2D", PointFeatureSpriteArray[0].texture);

//        SpriteDictionary = new Dictionary<S57Symbol, Sprite>(PointFeatureSpriteArray.Length);
//        SpriteRenderMeshDictionary = new Dictionary<S57Symbol, RenderMesh>(PointFeatureSpriteArray.Length);
//        for (int i = 0, length = PointFeatureSpriteArray.Length; i < length; i++)
//        {
//            if (SpriteSharedRef.SpriteEnum.TryGetValue(PointFeatureSpriteArray[i].name, out tempSymbol))
//            {
//                SpriteDictionary.Add(tempSymbol, PointFeatureSpriteArray[i]);
//                SpriteRenderMeshDictionary.Add(tempSymbol, new RenderMesh { material = PointSpritesMaterial, mesh = GetSpriteMesh(PointFeatureSpriteArray[i]), castShadows = ShadowCastingMode.Off, receiveShadows = false, layerMask = 1, layer = 1 });
//            }
//        }
//        //Request creation of 270,000 Sprites
//        CreateSpriteRequests();

//        //EntityQueries
//        SpriteQuery = GetEntityQuery(new EntityQueryDesc
//        {
//            All = new ComponentType[] { ComponentType.ReadOnly<SpriteRequestData>() },
//        });
//        PrefabQueryDesc = new EntityQueryDesc
//        {
//            All = new ComponentType[] { typeof(PrefabTag) },
//        };
//        SpritePrefab1Archetype = _entityManager.CreateArchetype(Blueprints.SpritePrefab1);
//        SpritePrefab2Archetype = _entityManager.CreateArchetype(Blueprints.SpritePrefab2);

//        RequireForUpdate(SpriteQuery);
//    }

//    protected override void OnUpdate()
//    {
//        var spriteRequestData = SpriteQuery.ToComponentDataArray<SpriteRequestData>(Allocator.TempJob);
//        spriteRequestData.Sort(default(SpriteRequestDataComparer));
//        int entityCount = 1;
//        var scaleList = new NativeList<Scale>(100, Allocator.TempJob);
//        var boundsList = new NativeList<RenderBounds>(100, Allocator.TempJob);
//        var translationList = new NativeList<Translation>(100, Allocator.TempJob);

//        RenderMesh renderMesh = SpriteRenderMeshDictionary[spriteRequestData[0].sprite];
//        scaleList.Add(new Scale { Value = 10 });
//        boundsList.Add(new RenderBounds { Value = renderMesh.mesh.bounds.ToAABB() });
//        translationList.Add(new Translation { Value = spriteRequestData[0].position });

//        if (spawnUnderSceneRoot)
//        {
//            var parentList = new NativeList<Parent>(100, Allocator.TempJob);
//            var sceneRootEntity = _entityManager.CreateEntity(typeof(SceneRootTag), typeof(Translation), typeof(Scale), typeof(LocalToWorld), typeof(WorldToLocal_Tag));
//            _entityManager.SetComponentData(sceneRootEntity, new Scale { Value = 1 });
//            var sceneRootParent = new Parent { Value = sceneRootEntity };
//            parentList.Add(sceneRootParent);

//            for (int i = 1, length = spriteRequestData.Length; i < length; i++)
//            {
//                if (spriteRequestData[i].spriteIndex == spriteRequestData[i - 1].spriteIndex)
//                {
//                    scaleList.Add(new Scale { Value = 10 });
//                    boundsList.Add(new RenderBounds { Value = renderMesh.mesh.bounds.ToAABB() });
//                    translationList.Add(new Translation { Value = spriteRequestData[i].position });
//                    parentList.Add(sceneRootParent);
//                    entityCount++;
//                }
//                else
//                {
//                    _entityManager.CreateEntity(SpritePrefab1Archetype, entityCount);
//                    var tempQuery = GetEntityQuery(PrefabQueryDesc);

//                    _entityManager.AddSharedComponentData(tempQuery, renderMesh);
//                    renderMesh = SpriteRenderMeshDictionary[spriteRequestData[i].sprite];

//                    _entityManager.AddComponentData(tempQuery, scaleList.AsArray());
//                    scaleList.Clear();
//                    scaleList.Add(new Scale { Value = 10 });

//                    _entityManager.AddComponentData(tempQuery, boundsList.AsArray());
//                    boundsList.Clear();
//                    boundsList.Add(new RenderBounds { Value = renderMesh.mesh.bounds.ToAABB() });

//                    _entityManager.AddComponentData(tempQuery, translationList.AsArray());
//                    translationList.Clear();
//                    translationList.Add(new Translation { Value = spriteRequestData[i].position });

//                    _entityManager.AddComponentData(tempQuery, parentList.AsArray());
//                    parentList.Clear();
//                    parentList.Add(sceneRootParent);

//                    _entityManager.RemoveComponent(tempQuery, typeof(PrefabTag));

//                    entityCount = 1;
//                }
//            }
//            parentList.Dispose();
//        }
//        else
//        {
//            for (int i = 1, length = spriteRequestData.Length; i < length; i++)
//            {
//                if (spriteRequestData[i].spriteIndex == spriteRequestData[i - 1].spriteIndex)
//                {
//                    scaleList.Add(new Scale { Value = 10 });
//                    boundsList.Add(new RenderBounds { Value = renderMesh.mesh.bounds.ToAABB() });
//                    translationList.Add(new Translation { Value = spriteRequestData[i].position });
//                    entityCount++;
//                }
//                else
//                {
//                    _entityManager.CreateEntity(SpritePrefab2Archetype, entityCount);
//                    var tempQuery = GetEntityQuery(PrefabQueryDesc);

//                    _entityManager.AddSharedComponentData(tempQuery, renderMesh);
//                    renderMesh = SpriteRenderMeshDictionary[spriteRequestData[i].sprite];

//                    _entityManager.AddComponentData(tempQuery, scaleList.AsArray());
//                    scaleList.Clear();
//                    scaleList.Add(new Scale { Value = 10 });

//                    _entityManager.AddComponentData(tempQuery, boundsList.AsArray());
//                    boundsList.Clear();
//                    boundsList.Add(new RenderBounds { Value = renderMesh.mesh.bounds.ToAABB() });

//                    _entityManager.AddComponentData(tempQuery, translationList.AsArray());
//                    translationList.Clear();
//                    translationList.Add(new Translation { Value = spriteRequestData[i].position });

//                    _entityManager.RemoveComponent(tempQuery, typeof(PrefabTag));

//                    entityCount = 1;
//                }
//            }
//        }
//        _entityManager.DestroyEntity(SpriteQuery);
//        spriteRequestData.Dispose();
//        scaleList.Dispose();
//        boundsList.Dispose();
//        translationList.Dispose();
//    }
//    static Mesh GetSpriteMesh(Sprite sprite)
//    {
//        Mesh mesh = new Mesh();
//        Vector2[] spriteVertices = sprite.vertices;
//        int vertLength = spriteVertices.Length;
//        Vector3[] vertices = new Vector3[vertLength];
//        Vector3[] normals = new Vector3[vertLength];
//        for (int i = 0; i < vertLength; i++)
//        {
//            vertices[i] = spriteVertices[i] / 30;
//            normals[i] = -Vector3.forward;
//        }
//        mesh.vertices = vertices;
//        mesh.uv = sprite.uv;

//        ushort[] spriteIndices = sprite.triangles;
//        int indexLength = spriteIndices.Length;
//        int[] indices = new int[indexLength];
//        for (int i = 0; i < indexLength; i++)
//            indices[i] = spriteIndices[i];
//        mesh.triangles = indices;
//        return mesh;
//    }
//    void CreateSpriteRequests()
//    {
//        for (int i = 1; i < 228; i++)
//        {
//            for (int j = 0; j < 1000; j++)
//            {
//                Entity spawned = _entityManager.CreateEntity(typeof(SpriteRequestData));
//                SpriteRequestData spriteRequestData = new SpriteRequestData { spriteIndex = i, position = new float3(i - 114, 0, j - 500), sprite = (S57Symbol)i };
//                _entityManager.SetComponentData(spawned, spriteRequestData);
//            }
//        }
//    }
//}
