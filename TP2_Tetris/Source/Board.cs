using System;
using System.Collections.Generic;

namespace Source
{
    public class Board
    {
        readonly int rows;
        readonly int columns;
        public List<Block> blocks;
        

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;

            this.blocks = new List<Block>();
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
            foreach(Block block in blocks)
            {
                if (block.isFalling) block.x += 1;
            }
        }
    }
}
 