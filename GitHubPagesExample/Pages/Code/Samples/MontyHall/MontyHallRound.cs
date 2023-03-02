namespace GitHubPagesExample.Pages.Code.Samples.MontyHall
{
    public class MontyHallRound
    {
        public MontyHallSteps Step { get; private set; }

        public MontyHallStrategies Strategy { get; private set; }

        public int Number { get; private set; }
        public int YourDoor { get; set; }
        public int HostDoor { get; set; }

        /// <summary>
        /// Stay or switch - this is the door number (1-3) that you stay or switch to
        /// </summary>
        public int StrategyDoor { get; set; }

        public int PrizeDoor { get; set; }

        public bool IsWin => Step == MontyHallSteps.Finished && StrategyDoor == PrizeDoor;

        private Random _random = new Random();

        public MontyHallRound(int number, MontyHallStrategies strategy)
        {
            Number = number;
            Strategy = strategy;
            PrizeDoor = randomDoor();
        }

        public void ProcessStep(MontyHallSteps step)
        {
            Step = step;
            if (Step == MontyHallSteps.YourChoice)
            {
                YourDoor = randomDoor();
            }
            else if (Step == MontyHallSteps.HostChoice)
            {
                HostDoor = getDoorExcept(YourDoor, PrizeDoor);
            }
            else if(Step == MontyHallSteps.AltChoice)
            {
                if (Strategy == MontyHallStrategies.Stay)
                    StrategyDoor = YourDoor;
                else
                    StrategyDoor = getDoorExcept(YourDoor, HostDoor);
            }
            else if(Step == MontyHallSteps.Finished)
            {

            }
        }

        private int getDoorExcept(int except1, int except2)
        {
            return new[] { 1, 2, 3 }.Except(new[] { except1, except2 }).First();
        }

        private int randomDoor()
        {
            return _random.Next(1, 4);
        }
    }
}
