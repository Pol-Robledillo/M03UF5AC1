using System;
namespace M03UF5AC1
{
    class Program
    {
        static void Main()
        {
            const string MsgInputPlayer = "Enter player name:";
            const string MsgInputMission = "Enter mission name:";
            const string MsgInputScore = "Enter score points:";
            const string MsgScoreSaved = "Score nº{0} saved.";
            const int numMissions = 10;


            List<Score> scores = new List<Score>();
            string? player, mission;
            int scorePoints;

            for (int i = 0; i < numMissions; i++)
            {
                do
                {
                    Console.WriteLine(MsgInputPlayer);
                    player = Console.ReadLine();
                } while (!Game.ValidatePlayerFormat(player));
                do
                {
                    Console.WriteLine(MsgInputMission);
                    mission = Console.ReadLine();
                } while (!Game.ValidateMissionFormat(mission));
                do
                {
                    Console.WriteLine(MsgInputScore);
                    scorePoints = int.Parse(Console.ReadLine());
                } while (!Game.ValidateScorePoints(scorePoints));
                scores.Add(new Score(player, mission, scorePoints));
                Console.WriteLine(MsgScoreSaved, i + 1);
                Console.WriteLine();
            }
            List<Score> filteredScores = Game.GenerateUniqueRanking(scores);
            filteredScores.Sort((x, y) => x.ScorePoints < y.ScorePoints ? 1 : x.ScorePoints > y.ScorePoints ? -1 : 0);
            foreach (Score score in filteredScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
