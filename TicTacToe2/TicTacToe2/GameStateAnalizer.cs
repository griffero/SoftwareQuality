using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class GameStateAnalizer
    {
        public bool IsMarkEqualToCellAtIndexInBoard(int mark, string row, int column, Board board)
        {
            //Position position = new Position(Enum.GetName((typeof(Alphabet)), row ), column);
            Position position = new Position(row, column);
            if(board.GetCellMarkAtPosition(position) == mark)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CountMarksInRow(int mark, string row, Board board) //RP2 no deberia ser countMarksInBoardRow
        {
            int marksInRow = 0;
            for(int j = 0; j< board.Dimension();j++)
            {
                if (IsMarkEqualToCellAtIndexInBoard(mark, row, j, board))
                {
                    marksInRow += 1;
                }
            }
            return marksInRow;
        }

        public int CountMarksInColumn(int mark, int column, Board board)
        {
            int marksInColumn = 0;
            for (int i = 0; i < board.Dimension(); i++ )
            {
                if(IsMarkEqualToCellAtIndexInBoard(mark,Enum.GetName(typeof(Alphabet),i),column,board))
                {
                    marksInColumn +=1;
                }
            }
            return marksInColumn;
        }

        public int CountMarksInDiagonal(int mark, string DiagonalInclination, Board board)
        {
            int marksInDiagonal = 0;
            for(int i = 0; i< board.Dimension(); i++)
            {
                if (DiagonalInclination.Equals(DiagonalTypes.UpDown))
                {
                    if (IsMarkEqualToCellAtIndexInBoard(mark, Enum.GetName(typeof(Alphabet), i), i, board))
                    {
                        marksInDiagonal += 1;
                    }
                }
                else if (DiagonalInclination.Equals(DiagonalTypes.DownUp))
                {
                    if (IsMarkEqualToCellAtIndexInBoard(mark, Enum.GetName(typeof(Alphabet),i),board.Dimension()- i, board))
                    {
                        marksInDiagonal += 1;
                    }
                }
            }
            return marksInDiagonal;
        }


        public int CheckForWinnerInBoard(Board board)
        {

        }

    }
}
