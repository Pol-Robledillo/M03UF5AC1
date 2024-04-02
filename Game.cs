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
            var filteredScores = from score in scores
                                 group score by new { score.Player, score.Mission } into g
                                 select g.First();

            return filteredScores;
        }
    }
}
