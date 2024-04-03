using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M03UF5AC1
{
    public class Score : IComparable<Score>
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
        public int CompareTo(Score? other)
        {
            return ScorePoints.CompareTo(other.ScorePoints);
        }
    }
}
