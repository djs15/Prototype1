using System;
using Cortex.Util;

namespace Cortex.Interfaces
{
    public interface IInput
    {
        Id Id { get; }
        double Strength { get; }
        Pattern Pattern { get; }
		void Trigger(double strength);
        event EventHandler<double> OnTrigger;
    }
}
