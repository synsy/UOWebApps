namespace UOWebApps.Client.Services
{
    public class GoldTrackerService
    {
        public int TotalGold { get; set; } = 0;
        public int GoldSplit { get; set; } = 0;
        public int NumPlayers { get; set; } = 1;

        public void AddGold(int amount)
        {
            TotalGold += amount;
            SplitGold();
        }

        public void ResetGold()
        {
            TotalGold = 0;
            SplitGold();
        }

        public void SplitGold()
        {
            // Prevent division by zero
            if (NumPlayers > 0)
            {
                GoldSplit = TotalGold / NumPlayers;
            }
            else
            {
                GoldSplit = 0;
            }
        }
    }
}
