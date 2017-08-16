using System;

namespace Cortex
{
    public class NeoCortex
    {
        public NeoCortex()
        {
            var layer1 = new Layer(1);
            var layer2 = new Layer(2, layer1);
            int a = 9;
        }
    }
}
