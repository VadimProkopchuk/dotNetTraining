namespace DotNetTraining.Lesson5.PointersAndUnsafe
{
	public class PointersExample
	{
		public static unsafe void SquarePtrParam(int* p)
		{
			*p *= *p;
		}

		public static unsafe int RunFixedStatementExample()
		{
			var human = new Human
			{
				Age = 21,
				Name = "Ivan"
			};

			fixed (int* p = &human.Age)
			{
				if (*p < 30)
				{
					*p = 30;
				}
			}

			return human.Age;
		}
	}
}
