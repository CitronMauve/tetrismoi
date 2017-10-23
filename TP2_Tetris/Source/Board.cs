using System;
using System.Collections.Generic;

namespace Source
{
    public class Board
    {
        readonly int rows;
        readonly int columns;
        public Block[,] board;
        public List<Block> blocks;
        

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.board = new Block[rows, columns];
            this.blocks = new List<Block>();
            FillEmptyBoard();
        }

        private void FillEmptyBoard()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    board[i, j] = new Block('.');
                }
            }
        }

        public override String ToString()
        {
            String s = "";
            bool isBlockPresent = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    foreach(Block block in blocks)
                    {
                        if (block.x == row && block.y == col) {
                            s += block.c;
                            isBlockPresent = true;
                            break;
                        }
                    }
                    if (!isBlockPresent) s += ".";
                    isBlockPresent = false;
                }
                s += "\n";
            }
            return s;
        }

        public bool IsFallingBlock()
        {
            foreach (Block block in this.blocks)
            {
                if (block.isFalling) return true;
            }

            return false;
        }

        public void Drop(Block block)
        {
            if (IsFallingBlock())
            {
                throw new ArgumentException();
            }
            blocks.Add(block);
        }

        public void Tick()
        {
            foreach (Block block in blocks)
            {
                if (block.x == rows - 1)
                {
                    block.isFalling = false;
                    continue;
                }

                if (board[block.x + 1, block.y].c != '.') {
                    block.isFalling = false;
                }

                if (block.isFalling && block.x < rows - 1) {
                    board[block.x, block.y] = new Block('.');
                    block.x += 1;
                    board[block.x, block.y] = new Block(block.c);
                }
            }
        }
        
    }
}
 