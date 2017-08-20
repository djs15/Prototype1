﻿using System;
namespace Cortex
{
    public static class Constants
    {
        public const int MaxLayers = 4;
        public const long MaxColumns = 8;
        public const double MaxStrength = 100.0;
        public const double ExperienceStrengthThreshold = 60.0;
        public const double PredictionStrengthThreshold = 80.0;
        public const double StrengthDecrease = 10.0;
        public const int TimerInterval = 20;
        public const int ExperienceQueueSize = 5;
    }
}
