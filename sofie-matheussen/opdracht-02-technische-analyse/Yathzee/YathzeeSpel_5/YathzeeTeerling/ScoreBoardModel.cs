using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
    public class ScoreBoardModel
    {
        private List<TeerlingView> teerlingen = new List<TeerlingView>();
        private int aantalWorpen = 0;
        private int highscore = 0;
        private int score = 0;

        public List<TeerlingView> Teerlingen
        {
            get
            {
                return teerlingen;
            }
            set
            {
                teerlingen =  value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public int Highscore
        {
            get
            {
                return highscore;
            }
            set
            {
                highscore = value;
            }
        }
    }
}
