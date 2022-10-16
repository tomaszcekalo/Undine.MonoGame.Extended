using MonoGame.Extended.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.MonoGame.Extended.Entities
{
    public class MGEEntity : IUnifiedEntity
    {
        private Entity entity;

        public MGEEntity(Entity entity)
        {
            this.entity = entity;
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            entity.Attach(new MGEComponentWrapper<A>() { Component = component });
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref entity.Get<MGEComponentWrapper<A>>().Component;
        }
    }
}