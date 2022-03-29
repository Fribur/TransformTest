using UnityEngine;
using Unity.Mathematics;
using UnityEngine.U2D;
using System.Collections.Generic;
using Chart3D.Helper;

public class MonoSpawnSprites : MonoBehaviour
{
    public bool spawnUnderSceneRoot = false;
    GameObject SceneRoot;
    Unity.Mathematics.Random rnd = new Unity.Mathematics.Random(1);
    SpriteAtlas PointFeatureAtlas;
    Sprite[] PointFeatureSpriteArray;
    Material _material, PointSpritesMaterial;    
    Dictionary<S57Symbol, Sprite> SpriteDictionary;
    S57Symbol tempSymbol;
    List<GameObject> allSprites;

    void Start()
    {
        SceneRoot = GameObject.Find("root");

        //Create Dictionary SpriteID, Mesh
        _material = Resources.Load("Materials/SpriteMaterial", typeof(Material)) as Material;

        PointFeatureAtlas = Resources.Load<SpriteAtlas>("PointFeatures");
        PointFeatureSpriteArray = new Sprite[PointFeatureAtlas.spriteCount];
        PointFeatureAtlas.GetSprites(PointFeatureSpriteArray);
        PointSpritesMaterial = Material.Instantiate(_material);
        PointSpritesMaterial.SetTexture("SpriteTexture2D", PointFeatureSpriteArray[0].texture);

        SpriteDictionary = new Dictionary<S57Symbol, Sprite>(PointFeatureSpriteArray.Length);
        for (int i = 0, length = PointFeatureSpriteArray.Length; i < length; i++)
        {
            if (SpriteSharedRef.SpriteEnum.TryGetValue(PointFeatureSpriteArray[i].name, out tempSymbol))
            {
                SpriteDictionary.Add(tempSymbol, PointFeatureSpriteArray[i]);               
            }
        }
        float scale = 0.4f;
        Vector3 scaleVector = new Vector3(scale, scale, scale);

        allSprites=new List<GameObject>();
        for (int i = 1; i < 228; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                GameObject go = new GameObject();
                SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
                sr.sprite = SpriteDictionary[(S57Symbol)i];
                go.transform.position = new Vector3(i - 114, 0, j - 500);
                go.transform.localScale = scaleVector;
                allSprites.Add(go);
                //
            }
        }
        if(spawnUnderSceneRoot)
        {
            for (int i = 0, length= allSprites.Count; i < length; i++)
                allSprites[i].transform.parent = SceneRoot.transform;
        }
    }


    void Update()
    {
        var randFloat = rnd.NextFloat(-0.1f, 0.1f);
        var movement = new Vector3(randFloat, 0, randFloat);

        if (spawnUnderSceneRoot)
        {
            SceneRoot.SetActive(false);
            transform.Translate(movement);
            SceneRoot.SetActive(true);
        }
        else
        {
            for (int i = 0, length = allSprites.Count; i < length; i++)
                allSprites[i].transform.Translate(movement);
        }
    }
}