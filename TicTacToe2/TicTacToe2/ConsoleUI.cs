using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class ConsoleUI
    {
        private string[,] UIBoard;

        public void PrepareBoardToBeDrawn(Board board)
        {
            //In order to be able to draw the board borders, 1 unit was added in each direction. *RP1
            int UIBoardDimension = board.Dimension() + 1;
            UIBoard = new string[UIBoardDimension, UIBoardDimension];
            for (int i = 0; i < UIBoardDimension; i++)
            {
                for (int j = 0; j < UIBoardDimension; j++)
                {
                    if (i == 0 && j == 0) //Fill the first position with an space.
                    {
                        UIBoard[i, j] = " ";
                    }
                    else if (i == 0 && j != 0) //Fills the first row with columns numbers.
                    {
                        UIBoard[i, j] = j.ToString();
                    }
                    else if (j == 0 && i != 0)  //Fills the first column with rows letters. 
                    {
                        UIBoard[i, j] = Enum.GetName(typeof(Alphabet), i - 1);
                    }
                    else //Fills all spaces with cells marks.
                    {
                        Position position = new Position(Enum.GetName(typeof(Alphabet), i - 1), j - 1);
                        UIBoard[i, j] = board.getCellMarkAtPosition(position).ToString();
                    }
                }
            }
        }

        public void DrawBoard(Board board)
        {
            PrepareBoardToBeDrawn(board);
            for (int i = 0; i < UIBoard.GetLength(0); i++)
            {
                for (int j = 0; j < UIBoard.GetLength(1); j++)
                {
                    Console.Write("{0} ", UIBoard[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
