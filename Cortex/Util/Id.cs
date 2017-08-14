using System;
namespace Cortex.Util
{
    public class Id
    {
        public int Layer { get; private set; }
        public long Index { get; private set; }

        public Id(int layer, long index)
        {
            Layer = layer;
            Index = index;
        }

        public override string ToString()
        {
            return string.Format("[Id: Layer={0}, Index={1}]", Layer, Index);
        }
    }
}
