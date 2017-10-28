using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Piece
    {
        public interface Grid
        {
            int Rows();
            int Columns();
            char CellAt(int row, int col);
        }

        public Char[,] matrice;

        public Piece(String plop)
        {
            int rows = CountRows(plop);
            int columns = CountColumns(plop);

			this.matrice = new Char[rows, columns];

            int indice = 0;

            for (int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < columns; ++j)
                {
                    if (this.matrice[i, j] != '\n') {
                        this.matrice[i, j] = plop[indice];
                    }
                    indice += 1;
                }
            }
        }

        private int CountRows(String foo)
        {
            int result = 0;

            while (foo[result] != '\n')
            {
                ++result;
            }

            return result;
        }

        private int CountColumns(String bar)
        {
            int result = 0;

            for(int i = 0; i < bar.Length; ++i)
            {
                if (bar[i] == '\n')
                {
                    ++result;
                }
            }

            return result;
        }
    }
}
