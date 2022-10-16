using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;
using Microsoft.Xna.Framework;

namespace Undine.MonoGame.Extended.Entities
{
    public class MGESystem<A> : EntityUpdateSystem, Core.ISystem
         where A : struct
    {
        private ComponentMapper<MGEComponentWrapper<A>> _componentsA;

        public UnifiedSystem<A> System { get; set; }

        public MGESystem()
            : base(Aspect.All(typeof(A)))
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (int entityId in ActiveEntities)
            {
                ref A a = ref _componentsA.Get(entityId).Component;

                System.ProcessSingleEntity(entityId, ref a);
            }
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _componentsA = mapperService.GetMapper<MGEComponentWrapper<A>>();
        }
    }

    public class MGESystem<A, B> : EntityUpdateSystem, Core.ISystem
         where A : struct
         where B : struct
    {
        private ComponentMapper<MGEComponentWrapper<A>> _componentsA;
        private ComponentMapper<MGEComponentWrapper<B>> _componentsB;

        public UnifiedSystem<A, B> System { get; set; }

        public MGESystem()
            : base(Aspect.All(typeof(A), typeof(B)))
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (int entityId in ActiveEntities)
            {
                ref A a = ref _componentsA.Get(entityId).Component;
                ref B b = ref _componentsB.Get(entityId).Component;

                System.ProcessSingleEntity(entityId, ref a, ref b);
            }
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _componentsA = mapperService.GetMapper<MGEComponentWrapper<A>>();
            _componentsB = mapperService.GetMapper<MGEComponentWrapper<B>>();
        }
    }

    public class MGESystem<A, B, C> : EntityUpdateSystem, Core.ISystem
         where A : struct
         where B : struct
         where C : struct
    {
        private ComponentMapper<MGEComponentWrapper<A>> _componentsA;
        private ComponentMapper<MGEComponentWrapper<B>> _componentsB;
        private ComponentMapper<MGEComponentWrapper<C>> _componentsC;

        public UnifiedSystem<A, B, C> System { get; set; }

        public MGESystem()
            : base(Aspect.All(typeof(A), typeof(B), typeof(C)))
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (int entityId in ActiveEntities)
            {
                ref A a = ref _componentsA.Get(entityId).Component;
                ref B b = ref _componentsB.Get(entityId).Component;
                ref C c = ref _componentsC.Get(entityId).Component;

                System.ProcessSingleEntity(entityId, ref a, ref b, ref c);
            }
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _componentsA = mapperService.GetMapper<MGEComponentWrapper<A>>();
            _componentsB = mapperService.GetMapper<MGEComponentWrapper<B>>();
            _componentsC = mapperService.GetMapper<MGEComponentWrapper<C>>();
        }
    }

    public class MGESystem<A, B, C, D> : EntityUpdateSystem, Core.ISystem
         where A : struct
         where B : struct
         where C : struct
         where D : struct
    {
        private ComponentMapper<MGEComponentWrapper<A>> _componentsA;
        private ComponentMapper<MGEComponentWrapper<B>> _componentsB;
        private ComponentMapper<MGEComponentWrapper<C>> _componentsC;
        private ComponentMapper<MGEComponentWrapper<D>> _componentsD;

        public UnifiedSystem<A, B, C, D> System { get; set; }

        public MGESystem()
            : base(Aspect.All(typeof(A), typeof(B), typeof(C), typeof(D)))
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (int entityId in ActiveEntities)
            {
                ref A a = ref _componentsA.Get(entityId).Component;
                ref B b = ref _componentsB.Get(entityId).Component;
                ref C c = ref _componentsC.Get(entityId).Component;
                ref D d = ref _componentsD.Get(entityId).Component;

                System.ProcessSingleEntity(entityId, ref a, ref b, ref c, ref d);
            }
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _componentsA = mapperService.GetMapper<MGEComponentWrapper<A>>();
            _componentsB = mapperService.GetMapper<MGEComponentWrapper<B>>();
            _componentsC = mapperService.GetMapper<MGEComponentWrapper<C>>();
            _componentsD = mapperService.GetMapper<MGEComponentWrapper<D>>();
        }
    }
}