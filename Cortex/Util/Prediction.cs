using System;
using System.Collections.Generic;
using Cortex.Interfaces;

namespace Cortex.Util
{
    public class Prediction
    {
        public List<IInput> AboveInputs { get; }
		public List<IInput> LayerInputs { get; }

		public Prediction()
        {
        }
    }
}
