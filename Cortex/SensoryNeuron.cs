using System;
using System.Threading;
using Cortex.Interfaces;
using Cortex.Util;

namespace Cortex
{
    public class SensoryNeuron: IInput
    {
        private Timer _timer;
        private AutoResetEvent _autoReset;

		public Id Id { get; private set; }
		public double Strength { get; private set; }

		public SensoryNeuron(long index)
        {
            Id = new Id(0, index);
        }

        public void Trigger(double strength)
        {
            Strength = strength;

            /*if (_timer == null)
            {
                _autoReset = new AutoResetEvent(false);
                _timer = new Timer(DecreaseStrength, _autoReset, 0, Constants.TimerInterval);
                _autoReset.WaitOne();
                _timer.Dispose();
            }*/
        }

        /*
        private void DecreaseStrength(object info)
        {
            if (Strength <= 0)
            {
                Strength = 0;
                _autoReset.Set();
            }
            else 
            {
                if (Strength < Constants.StrengthDecrease)
                {
                    Strength = 0;
                }
                else
                {
                    Strength -= Constants.StrengthDecrease;
                }
            }

            Console.WriteLine(string.Format("Strength {0}", Strength));
        }*/
    }
}
