using System;
using Cortex.Util;

namespace Cortex.Interfaces
{
    public interface IInput
    {
        Id Id { get; }
        double Strength { get; }
        void Trigger(double strength);
    }
}
