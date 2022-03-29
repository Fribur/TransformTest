using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using Chart3D.Components;

public partial class MoveSceneRootSystem : SystemBase
{
    Random rnd = new Random(1);
    protected override void OnUpdate()
    {
        var randFloat = rnd.NextFloat(-0.1f, 0.1f);
        var movement = new float3 (randFloat, 0, randFloat);
        Entities.WithAll<SceneRootTag>().ForEach((ref Translation translation) =>
        {
            translation.Value += movement;
        }).Schedule();
    }
}
