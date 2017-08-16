using System;
using System.Collections.Generic;
using Cortex.Interfaces;

namespace Cortex.Util
{
    public class Experience
    {
        public List<IInput> Inputs { get; private set; }

        public Experience(IInput input)
        {
            Inputs = new List<IInput>() { input };
        }

        public Experience(List<IInput> inputs)
        {
            Inputs = inputs;
        }
    }
}
