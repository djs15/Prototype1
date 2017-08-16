using System;
using System.Collections.Generic;
using System.Linq;
using Cortex.Interfaces;
using Cortex.Util;

namespace Cortex
{
    public class Layer
    {
        public int Id { get; private set; }
        public List<IInput> Columns { get; set; }

        public Layer(int id, Layer below = null)
        {
            Id = id;
            Columns = new List<IInput>();

            for (long i = 0; i < Constants.MaxColumns; i++)
            {
                var column = new Column(id, i);

                if (below == null)
                {
                    var neuron = new SensoryNeuron(i);
                    var experience = new Experience(neuron);
                    column.SetExperience(experience);
                }
                else
                {
                    var experience = new Experience(below.Columns);
                    column.SetExperience(experience);
                }

                Columns.Add(column);
            }

            foreach (Column column in Columns)
            {
                var prediction = new Prediction();
                prediction.SetLayerInputs(Columns.Where(c => c != column).ToList());

                if (below != null)
                {
                    foreach (Column belowColumn in below.Columns)
                    {
                        belowColumn.Prediction.AddAboveInput(column);
                    }
				}

				column.SetPrediction(prediction);
            }
        }

        public void Trigger()
        {
            
        }
    }
}
