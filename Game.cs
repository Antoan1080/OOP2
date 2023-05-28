using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_1080
{
    internal class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get;set; }  
        public Referee Referee { get;set; }
        public Referee AssistantReferee1 { get;set; }
        public Referee AssistantReferee2 { get;set; }
        public List<(int Minute, Player Player)> Goals {get; set;}
        public string Result {get; set;}
        public Team Winner { get; set;}
        public Game( Team team1, Team team2, Referee referee, 
            Referee assistantReferee1, Referee assistantReferee2) 
        { 
            Team1 = team1;
            Team2 = team2;

            if (team1.Players.Count != 11 || team2.Players.Count != 11)
            {
                throw new Exception("Both teams must have 11 players only");
            }
            
            Referee = referee;
            Referee = assistantReferee1;
            Referee = assistantReferee2;
            Goals = new List<(int Minute, Player)>();
            Result = null;
            Winner = null;
        }
        public void AddGoal(int minute, Player player)
        {
            Goals.Add((minute, player));
        }
        public void RemoveGoal(int minute, Player player) //because of VAR 
        {  
            Goals.Remove((minute, player)); 
        }
        public void SetResult(string result, Team winner)
        { 
            Result = result;
            Winner = winner;
        }
        public void SetWinner(Team finalWinner)
        { 
            Winner = finalWinner;
        }

        
        


    }
}
