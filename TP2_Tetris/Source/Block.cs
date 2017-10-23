namespace Source
{
    public class Block
    {
        public char c;

        public int x;
        public int y;

        public bool isFalling;

        public Block(char c)
        {
            this.c = c;

            this.x = 0;
            this.y = 1; 

            this.isFalling = true;
        }

    }
}
