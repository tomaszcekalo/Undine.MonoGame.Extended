using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.MonoGame.Extended.Entities
{
    public class MGEComponentWrapper<A>
        where A : struct
    {
        public A Component;
    }
}