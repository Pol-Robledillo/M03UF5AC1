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
            const string MsgPlayerFormatError = "Player name must contain only letters.";
            const string MsgMissionFormatError = "Mission name must start with the name of a greek letter followed by a ''-'' and three numbers.";
            const string MsgScorePointsError = "Score points must be between 0 and 500.";
            
            List<Score> scores = new List<Score>();
            string player, mission;
            int scorePoints;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(MsgInputPlayer);
                    player = Console.ReadLine();
                    if (!Score.ValidatePlayerFormat(player))
                    {
                        Console.WriteLine(MsgPlayerFormatError);
                    }
                } while (!Score.ValidatePlayerFormat(player));
                do
                {
                    Console.WriteLine(MsgInputMission);
                    mission = Console.ReadLine();
                    if (!Score.ValidateMissionFormat(mission))
                    {
                        Console.WriteLine(MsgMissionFormatError);
                    }
                } while (!Score.ValidateMissionFormat(mission));
                do
                {
                    Console.WriteLine(MsgInputScore);
                    scorePoints = int.Parse(Console.ReadLine());
                    if (!Score.ValidateScorePoints(scorePoints))
                    {
                        Console.WriteLine(MsgScorePointsError);
                    }
                } while (!Score.ValidateScorePoints(scorePoints));
                scores.Add(new Score(player, mission, scorePoints));
            }
        }
    }
}