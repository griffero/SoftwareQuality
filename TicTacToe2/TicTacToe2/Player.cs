using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Player
    {
        private int mark;
        private int score;
        //creo que no es necesario
        //private TicTacToe ticTacToe;

        public Player(int mark)
        {
            this.mark = mark;
        }

        public int GetScore()
        {
            return score;
        }

        public int GetName()
        {
            return mark;
        }

        public void AddPointsToScore(int numberOfpoints)
        {
            score += numberOfpoints;
        }

        public void PlayGameAtPosition(TicTacToe ticTacToe, Position position)
        {
            //TODO 
        }

    }
}
