using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveBunnies
{
    class Position
    {
        public int row { get; set; }
        public int col { get; set; }

        public override int GetHashCode()
        {
            return (row + col).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Position;
            if (other == null)
            {
                return false;
            }
            return row == other.row && col == other.col;
        }
    }
}
