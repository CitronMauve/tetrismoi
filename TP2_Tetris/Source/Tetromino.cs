using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Tetromino
    {
        public String firstOrientation;
        public String secondOrientation;
        public String thirdOrientation;
        public String fourthOrientation;

		public Piece[] pieces;
		public int actualOrientation;

		public static Tetromino T_SHAPE = new Tetromino(
			"....\n" +
			"TTT.\n" +
			".T..\n"
			,
			".T..\n" +
			"TT..\n" +
			".T..\n"
			,
			"....\n" +
			".T..\n" +
			"TTT.\n"
			,
			".T..\n" +
			".TT.\n" +
			".T..\n"
			);

		public static Tetromino L_SHAPE = new Tetromino(
			"....\n" +
			"IIII\n" +
			"....\n"
			,
			"..I.\n" +
			"..I.\n" +
			"..I.\n"
			,
			"....\n" +
			"IIII\n" +
			"....\n"
			,
			"..I.\n" +
			"..I.\n" +
			"..I.\n"
			);

		public Tetromino(String firstOrientation, String secondOrientation, String thirdOrientation, String fourthOrientation)
        {
            this.firstOrientation = firstOrientation;
            this.secondOrientation = secondOrientation;
            this.thirdOrientation = thirdOrientation;
            this.fourthOrientation = fourthOrientation;
        }

		public Tetromino(Piece firstPiece, Piece secondPiece, Piece thirdPiece, Piece fourthPiece)
		{
			this.pieces = new Piece[4] { firstPiece, secondPiece, thirdPiece, fourthPiece };
			this.actualOrientation = 0;
		}

		public Tetromino(Piece[] pieces)
		{
			this.pieces = pieces;
			this.actualOrientation = 0;
		}

		/*
        public Tetromino RotateRight()
        {
            return new Tetromino(secondOrientation, thirdOrientation, fourthOrientation, firstOrientation);
        }
		*/

		public void RotateRight()
		{
			this.actualOrientation = this.actualOrientation == 3 ? 0 : this.actualOrientation++;
		}

		/*
        public Tetromino RotateLeft()
        {
            return new Tetromino(fourthOrientation, firstOrientation, secondOrientation, thirdOrientation);

        }
		*/

		public void RotateLeft()
		{
			this.actualOrientation = this.actualOrientation == 0 ? 3 : this.actualOrientation--;

		}

		public override String ToString()
        {
            return this.firstOrientation;
        }
    }
}
