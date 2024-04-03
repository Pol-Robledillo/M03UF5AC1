using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M03UF5AC1
{
    public class Score
    {
        public string? Player { get; set; }
        public string? Mission { get; set; }
        public int ScorePoints { get; set; }
        public Score(string player, string mission, int scorePoints)
        {
            Player = player;
            Mission = mission;
            ScorePoints = scorePoints;
        }
        public override string ToString()
        {
            return $"Player: {Player}, Mission: {Mission}, Score: {ScorePoints}";
        }
    }
}
