namespace DotNetTraining.Lesson2.Structures
{
    public struct StructuresExample
    {
        public StructuresExample(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public override string ToString()
        {
            return $"x: {X}, y: {Y}";
        }
    }
}
