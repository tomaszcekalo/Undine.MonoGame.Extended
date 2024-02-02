using MonoGame.Extended.Entities;
using Undine.Core;

namespace Undine.MonoGame.Extended.Entities
{
    public class MGEEntity : IUnifiedEntity
    {
        public Entity Entity { get; set; }

        public MGEEntity(Entity entity)
        {
            this.Entity = entity;
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            Entity.Attach(new MGEComponentWrapper<A>() { Component = component });
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref Entity.Get<MGEComponentWrapper<A>>().Component;
        }

        public void RemoveComponent<A>() where A : struct
        {
            Entity.Detach<MGEComponentWrapper<A>>();
        }

        public bool HasComponent<A>() where A : struct
        {
            return Entity.Has<MGEComponentWrapper<A>>();
        }
    }
}