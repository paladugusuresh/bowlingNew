using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
        int rollsCount = 0;
        List<int> rolls = new List<int>();
       
        public void Roll(int pins)
        {
            SetPinsToFrame(pins);
        }

        public int GetScore()
        {
            var score = new GameScore();
            foreach (var roll in rolls)
            {
                score.Roll(roll);
            }
            return score.CalculateScore();
        }

        private void SetPinsToFrame(int pins)
        {
            rollsCount++;
            switch (rollsCount % 2)
            {
                case 0:
                    if (rolls[rolls.Count() - 1] != 10)
                    {
                        rolls.Add(pins);
                    }
                    break;
                default:
                    rolls.Add(pins);
                    break;
            }
        }
       
    }
}
