using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessManager
{
    public interface IFitnessManager
    {
        void LogUserSteps(string name, int steps);
        void UpdateRankings();
        void ShowLeaderboard();
    }
}
