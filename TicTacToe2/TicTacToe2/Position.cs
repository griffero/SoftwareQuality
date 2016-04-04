using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Position
    {
        private int column;
        private string row;

        public Position(string row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public int Column()
        {
            return column;
        }

        public string Row()
        {
            return row;
        }

        public int RowAsNumber()
        {
            int rowNumber = (int)Enum.Parse(typeof(Alphabet), row);
            return rowNumber;
        }

    }
}
