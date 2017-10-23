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

        public Tetromino(String firstOrientation, String secondOrientation, String thirdOrientation, String fourthOrientation)
        {
            this.firstOrientation = firstOrientation;
            this.secondOrientation = secondOrientation;
            this.thirdOrientation = thirdOrientation;
            this.fourthOrientation = fourthOrientation;
        }

        public Tetromino RotateRight()
        {
            return new Tetromino(secondOrientation, thirdOrientation, fourthOrientation, firstOrientation);
        }

        public Tetromino RotateLeft()
        {
            return new Tetromino(fourthOrientation, firstOrientation, secondOrientation, thirdOrientation);

        }

        public override String ToString()
        {
            return this.firstOrientation;
        }
    }
}
