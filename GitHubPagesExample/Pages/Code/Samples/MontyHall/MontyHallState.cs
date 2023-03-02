using System;

namespace GitHubPagesExample.Pages.Code.Samples.MontyHall
{
    public class MontyHallState
    {
        public event Action OnRoundChange;

        public void NotifyRoundChanged() => OnRoundChange?.Invoke();

        public event Action<MontyHallRound, MontyHallSteps> OnStepChange;

        public void NotifyStepChanged(MontyHallRound round, MontyHallSteps step) => OnStepChange?.Invoke(round, step);
    }
}
