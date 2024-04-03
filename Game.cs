using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M03UF5AC1
{
    public static class Game
    {
        public static bool ValidatePlayerFormat(string player)
        {
            const string MsgPlayerFormatError = "Player name must contain only letters.";
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (!regex.IsMatch(player))
            {
                Console.WriteLine(MsgPlayerFormatError);
            }
            return regex.IsMatch(player);
        }
        public static bool ValidateMissionFormat(string mission)
        {
            const string MsgMissionFormatError = "Mission name must start with the name of a greek letter followed by a ''-'' and three numbers.";
            Regex regex = new Regex(@"^(beta|gamma|delta|zeta|theta|kappa|lambda|mu|nu|xi|pi|rho|sigma|tau|phi|chi|psi)-\d{3}$");
            if (!regex.IsMatch(mission))
            {
                Console.WriteLine(MsgMissionFormatError);
            }
            return regex.IsMatch(mission);
        }
        public static bool ValidateScorePoints(int scorePoints)
        {
            const string MsgScorePointsError = "Score points must be between 0 and 500.";
            if (scorePoints < 0 || scorePoints > 500)
            {
                Console.WriteLine(MsgScorePointsError);
            }
            return scorePoints >= 0 && scorePoints <= 500;
        }
        public static List<Score> GenerateUniqueRanking(List<Score> scores)
        {
            var filteredScores = scores.GroupBy(score => new { score.Player, score.Mission })
                                       .Select(group => group.OrderByDescending(score => score.ScorePoints)
                                       .First())
                                       .ToList();
            return filteredScores;
        }
    }
}
