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
            const int numMissions = 4;


            List<Score> scores = new List<Score>();
            string? player, mission;
            int scorePoints;

            for (int i = 0; i < numMissions; i++)
            {
                do
                {
                    Console.WriteLine(MsgInputPlayer);
                    player = Console.ReadLine();
                } while (!Score.ValidatePlayerFormat(player));
                do
                {
                    Console.WriteLine(MsgInputMission);
                    mission = Console.ReadLine();
                } while (!Score.ValidateMissionFormat(mission));
                do
                {
                    Console.WriteLine(MsgInputScore);
                    scorePoints = int.Parse(Console.ReadLine());
                } while (!Score.ValidateScorePoints(scorePoints));
                scores.Add(new Score(player, mission, scorePoints));
            }
            List<Score> filteredScores = Game.GenerateUniqueRanking(scores);
            foreach (Score score in filteredScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}