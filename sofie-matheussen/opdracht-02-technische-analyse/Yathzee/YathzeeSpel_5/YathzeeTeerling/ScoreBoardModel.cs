using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
    public class ScoreBoardModel
    {
        private List<TeerlingController> teerlingen = new List<TeerlingController>();
        private int aantalWorpen = 0;
        private int highscore = 0;
        private int score = 0;

        public List<TeerlingController> Teerlingen
        {
            get
            {
                return teerlingen;
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
