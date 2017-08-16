using System;
using System.Collections.Generic;
using Cortex.Interfaces;

namespace Cortex.Util
{
    public class Prediction
    {
        public List<IInput> AboveInputs { get; private set; }
        public List<IInput> LayerInputs { get; private set; }

		public Prediction()
        {
            AboveInputs = new List<IInput>();
            LayerInputs = new List<IInput>();
        }

        public void AddAboveInput(IInput input)
        {
            AboveInputs.Add(input);
        }

        public void SetLayerInputs(List<IInput> inputs)
        {
            LayerInputs = inputs;
        }
    }
}
