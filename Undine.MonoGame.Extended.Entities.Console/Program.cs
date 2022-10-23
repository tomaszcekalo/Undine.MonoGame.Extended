// See https://aka.ms/new-console-template for more information
using Microsoft.Xna.Framework;
using Undine.Core;
using Undine.MonoGame;
using Undine.MonoGame.Extended.Entities;

Console.WriteLine("Hello, World!");
var container = new MGEContainer()
{
    GameTimeProvider = new GameTimeProvider()
};
container.AddSystem(new SpeedSystem());
container.AddSystem(new AccelerationSystem());
container.Init();

var entity = container.CreateNewEntity();
entity.AddComponent(new PositionComponent());
entity.AddComponent(new VelocityComponent()
{
    x = 0,
    y = 10,
});
entity.AddComponent(new AccelerationComponent()
{
    x = 0,
    y = -1
});

for (int i = 0; i < 20; i++)
{
    container.Run();
    Console.WriteLine("Y =" + entity.GetComponent<PositionComponent>().y);
}

//var posOnly=
//var velOnly=
//var accOnly=
//var posAndVel=
//var posAndAcc=
//var velAndAcc=
//var complete=

//container.AddSystem()

internal class GameTimeProvider : IGameTimeProvider
{
    public GameTime GameTime { get; set; } = new GameTime()
    {
        ElapsedGameTime = TimeSpan.FromSeconds(1),
        TotalGameTime = TimeSpan.FromSeconds(1),
    };
}

internal class SpeedSystem : UnifiedSystem<PositionComponent, VelocityComponent>
{
    public override void ProcessSingleEntity(
        int entityId,
        ref PositionComponent a,
        ref VelocityComponent b)
    {
        a.x += b.x;
        a.y += b.y;
    }
}

internal class AccelerationSystem : UnifiedSystem<VelocityComponent, AccelerationComponent>
{
    public override void ProcessSingleEntity(
        int entityId,
        ref VelocityComponent a,
        ref AccelerationComponent b)
    {
        a.x += b.x;
        a.y += b.y;
    }
}

internal struct PositionComponent
{
    public float x;
    public float y;
}

internal struct VelocityComponent
{
    public float x;
    public float y;
}

internal struct AccelerationComponent
{
    public float x;
    public float y;
}