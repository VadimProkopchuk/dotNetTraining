using System.Text;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Base;

namespace DotNetTraining.Lesson2.Classes.ExtendsExample.Generators
{
    public class CarReportGenerator : BaseReportGenerator<CarEntity>
    {
        protected override bool IsValid(CarEntity entity) => entity.IsRed;

        protected override string ReportGeneratorName => nameof(CarReportGenerator);

        protected override StringBuilder AppendHeader(StringBuilder builder)
        {
            builder.AppendLine("Report Include Only Red Cars");
            return base.AppendHeader(builder);
        }
    }
}
