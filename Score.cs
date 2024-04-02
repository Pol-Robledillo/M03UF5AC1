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
        public static bool ValidatePlayerFormat(string player)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            return regex.IsMatch(player);
        }
        public static bool ValidateMissionFormat(string mission)
        {
            List<string> nombresConsonantesGriegas = [ "Beta", "Gamma", "Delta", "Zeta", "Theta", "Kappa", "Lambda", "Mu", "Nu", "Xi", "Pi", "Rho", "Sigma", "Tau", "Phi", "Chi", "Psi", "Omega" ];

        }
        public static bool ValidateScorePoints(int scorePoints)
        {
            return scorePoints >= 0 && scorePoints <= 500;
        }
    }
}
