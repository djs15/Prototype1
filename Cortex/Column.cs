using System;
using System.Collections.Generic;
using Cortex.Interfaces;
using Cortex.Util;

namespace Cortex
{
    public class Column: IInput
    {
        private Queue<Tuple<IInput, double>> _experienceQueue;

		public Id Id { get; private set; }
        public Pattern Pattern { get; private set; }
        public Experience Experience { get; private set; }
        public Prediction Prediction { get; private set; }
        public event EventHandler<double> OnTrigger;

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
            _experienceQueue = new Queue<Tuple<IInput, double>>(Constants.ExperienceQueueSize);
        }

        public void SetExperience(Experience experience)
        {
            Experience = experience;

            foreach (var input in experience.Inputs)
            {
                input.OnTrigger += OnExperienceTrigger;
            }
        }

        public void SetPrediction(Prediction prediction)
        {
            Prediction = prediction;

            foreach (var input in prediction.AboveInputs)
            {
                input.OnTrigger += OnPredictionTrigger;
            }

            foreach (var input in prediction.LayerInputs)
            {
                input.OnTrigger += OnPredictionTrigger;
            }
        }

        public void Trigger(double strength)
        {
            throw new NotSupportedException();
        }

        private void OnExperienceTrigger(object sender, double strength)
        {
            var input = (IInput)sender;

            if (Pattern == null)
            {
                Pattern = input.Pattern;
            }
            else if (Id.Layer == 1 && input.Pattern == Pattern)
            {
                
            }

            _experienceQueue.Enqueue(new Tuple<IInput, double>(input, strength));

            if (strength > Constants.ExperienceStrengthThreshold)
            {
                OnTrigger.Invoke(this, Strength);
            }
        }

        private void OnPredictionTrigger(object sender, double strength)
        {
            if (Strength > Constants.PredictionStrengthThreshold)
            {
                OnTrigger.Invoke(this, Strength);
            }
		}
    }
}
