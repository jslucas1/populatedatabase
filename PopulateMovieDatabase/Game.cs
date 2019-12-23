using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateMovieDatabase
{
    class Game
    {
        string favorite;
        string underdog;
        double line;
        int week;
        string date;
        string time;
        int favoriteScore;
        string homeTeam;

        public Game()
        {

        }
        public Game(string favorite, string underdog, double line, int week, string date, string time, string homeTeam)
        {
            this.favorite = favorite;
            this.underdog = underdog;
            this.line = line;
            this.week = week;
            this.date = date;
            this.time = time;
             this.homeTeam = homeTeam;
        }

        public string Favorite { get => favorite; set => favorite = value; }
        public string Underdog { get => underdog; set => underdog = value; }
        public double Line { get => line; set => line = value; }
        public int Week { get => week; set => week = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string HomeTeam { get => homeTeam; set => homeTeam = value; }
    }
}
