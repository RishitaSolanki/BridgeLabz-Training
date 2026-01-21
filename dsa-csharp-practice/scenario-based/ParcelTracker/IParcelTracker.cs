using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.ParcelTracker
{
    public interface IParcelTracker
    {
        void AddStage(string stage);
        void AddCheckpoint(string afterStage, string newStage);
        void TrackForward();
        void MarkLost(string stage);
    }
}

