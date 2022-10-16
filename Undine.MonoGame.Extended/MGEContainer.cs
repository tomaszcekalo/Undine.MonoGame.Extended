using MonoGame.Extended.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.MonoGame.Extended.Entities
{
    public class MGEContainer : EcsContainer
    {
        public WorldBuilder WorldBuilder { get; }
        public World World { get; }

        public MGEContainer()
        {
            this.WorldBuilder = new WorldBuilder();
            this.World = this.WorldBuilder.Build();
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new MGEEntity(World.CreateEntity());
        }
    }
}