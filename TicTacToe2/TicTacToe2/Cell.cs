using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Cell
    {
        private int mark;

        public Cell()
        {
            mark = (int)Marks.Empty;
        }
        public void MarkAs( int mark)
        {
            this.mark = mark;
        }
        public int Mark()
        {
            return mark;
        }
    }
}
