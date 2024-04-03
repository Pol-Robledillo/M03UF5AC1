using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5AC1
{
    public static class Game
    {
        public static List<Score> GenerateUniqueRanking(List<Score> scores)
        {
            List<Score> filteredScores = new List<Score>();
            var filteredScoresVar = scores.GroupBy(score => new { score.Player, score.Mission })
                                          .Select(group => group.OrderByDescending(score => score.ScorePoints).First());
            foreach (Score score in filteredScoresVar)
            {
                filteredScores.Add(score);
            }
            filteredScores.Sort();
            return filteredScores;
        }
    }
}
