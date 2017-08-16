using System;
using System.Collections.Generic;
using Cortex.Interfaces;
using Cortex.Util;

namespace Cortex
{
    public class Column: IInput
    {
		public Id Id { get; private set; }
		
        public Experience Experience { get; private set; }
        public Prediction Prediction { get; private set; }

        public double Strength 
        {
            get
            {
                return Calculate.GetStrength(Experience, Prediction);
            }
        }

        public Column(int layer, long index)
        {
            Id = new Id(layer, index);
        }

        public void SetExperience(Experience experience)
        {
            Experience = experience;
        }

        public void SetPrediction(Prediction prediction)
        {
            Prediction = prediction;
        }

        public void Trigger(double strength)
        {
            throw new NotImplementedException();
        }
    }
}
