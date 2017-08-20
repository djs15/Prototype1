using System;
using System.Collections.Generic;

namespace Cortex.Util
{
    public class Pattern
    {
        public bool IsReadOnly { get; private set; }
        public List<object> Sequence { get; set; }

        public Pattern()
        {
            IsReadOnly = false;
            Sequence = new List<object>();
        }

        public Pattern(object obj)
        {
            IsReadOnly = true;
            Sequence = new List<object>() { obj };
        }

        public void UpdatePattern(List<object> sequence)
        {
            if (IsReadOnly)
            {
                throw new NotImplementedException();
            }

            Sequence = sequence;
        }
    }
}
