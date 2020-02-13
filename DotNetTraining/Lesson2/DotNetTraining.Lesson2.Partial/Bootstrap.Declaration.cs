namespace DotNetTraining.Lesson2.Partial
{
    public partial class Bootstrap
    {
        public void Run()
        {
            LoadFirstModule();
            LoadSecondModule();
        }

        partial void LoadFirstModule();
        partial void LoadSecondModule();
    }
}
