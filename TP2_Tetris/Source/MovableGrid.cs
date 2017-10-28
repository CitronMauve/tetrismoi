using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
	class MovableGrid
	{
		private Tetromino shape;
		private Tetromino fallingBlock;

		public MovableGrid(Tetromino shape)
		{
			this.shape = shape;
		}

		public void Drop(Tetromino shape)
		{
			CheckIfFalling();
			int r = StartingRowOffset(shape);
			fallingBlock = new MovableGrid(shape).MoveTo(r, Columns / 2 - shape.Column() / 2);
		}

		private void CheckIfFalling()
		{
			throw new NotImplementedException();
		}

		private int StartingRowOffset(Tetromino shape)
		{
			throw new NotImplementedException();
		}

		private object MoveTo(int r, object p)
		{
			throw new NotImplementedException();
		}

		public void MoveDown()
		{

		}

		public void MoveLeft() {

		}

		public void MoveRight()
		{

		}

		public void RotateRight()
		{

		}

		public void RotateLeft()
		{
		}



	}
}
