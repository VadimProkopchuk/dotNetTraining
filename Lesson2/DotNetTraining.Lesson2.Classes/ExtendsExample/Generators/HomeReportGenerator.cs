using DotNetTraining.Lesson2.Classes.ExtendsExample.Base;

namespace DotNetTraining.Lesson2.Classes.ExtendsExample.Generators
{
    public class HomeReportGenerator : BaseReportGenerator<HomeEntity>
    {
        protected override bool IsValid(HomeEntity entity) => true;

        protected override string ReportGeneratorName => nameof(HomeReportGenerator);
    }
}
