using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.MonoGame.Extended.Entities
{
    public class MGESystem<A> : EntityUpdateSystem, Core.ISystem
         where A : struct
    {
        public MGESystem(UnifiedSystem<A> system)
            : base(Aspect.All(typeof(A)))
        { }

        public override void Initialize(IComponentMapperService mapperService)
        {
            throw new NotImplementedException();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}