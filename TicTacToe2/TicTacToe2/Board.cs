using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Board
    {
        private int dimension;
        private Cell[,] cells;

        public Board(int dimension)
        {
            this.dimension = dimension;
            InitializeBoardWithEmptyCells();
        }

        public void InitializeBoardWithEmptyCells()
        {
            cells = new Cell[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
        }

        public void MarkCellAtPositionWithSymbol(Position position, int symbol)
        {
            CellAtPosition(position).MarkAs(symbol);
        }

        public Cell[,] Cells()
        {
            return cells;
        }

        public int GetCellMarkAtPosition(Position position)
        {
            return CellAtPosition(position).Mark();
        }

        public Cell CellAtPosition(Position position)
        {
            return cells[position.RowAsNumber(), position.Column()];
        }

        public int Dimension()
        {
            return dimension;
        }

    }
}
