namespace DotNetTraining.Lesson2.Structures
{
    public struct StructuresExample
    {
        public int x;
        public int y;

        public StructuresExample(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}
