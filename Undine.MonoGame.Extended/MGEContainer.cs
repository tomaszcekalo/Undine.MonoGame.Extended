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
        public World World { get; private set; }
        public bool WasWorldBuilt { get; private set; }
        public IGameTimeProvider GameTimeProvider { get; set; }

        public MGEContainer()
        {
            this.WorldBuilder = new WorldBuilder();
            //this.World = this.WorldBuilder.Build();
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            this.WorldBuilder.AddSystem(
                new MGESystem<A>()
                {
                    System = system
                });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            this.WorldBuilder.AddSystem(
                new MGESystem<A, B>()
                {
                    System = system
                });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            this.WorldBuilder.AddSystem(
                new MGESystem<A, B, C>()
                {
                    System = system
                });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            this.WorldBuilder.AddSystem(
                new MGESystem<A, B, C, D>()
                {
                    System = system
                });
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new MGESystem<A>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new MGESystem<A, B>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new MGESystem<A, B, C>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new MGESystem<A, B, C, D>()
            {
                System = system
            };
        }

        public override void Run()
        {
            World.Update(GameTimeProvider.GameTime);
        }

        private void BuildWorld()
        {
            WasWorldBuilt = true;
            this.World = this.WorldBuilder.Build();
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new MGEEntity(World.CreateEntity());
        }
    }
}