using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;
using Undine.MonoGame.Extended.Tests.Components;

namespace Undine.MonoGame.Extended.Entities.Tests
{
    [TestClass]
    public class EntityTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void ComponentCanBeAdded()
        {
            var container = new MGEContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
        }

        [TestMethod]
        public void ComponentCanBeRetrieved()
        {
            var container = new MGEContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = (MGEEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());

            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }
        [TestMethod]
        public void ComponentCanBeRemoved()
        {
            var container = new MGEContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = (MGEEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());

            ref var component = ref entity.GetComponent<AComponent>();
            entity.RemoveComponent<AComponent>();
            Assert.IsFalse(entity.HasComponent<AComponent>());
        }
    }
}