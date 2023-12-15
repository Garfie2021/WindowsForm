using System.Collections.Generic;

namespace SectionReportApplication1
{
    public class ReportDataModel
    {
        public string ReportNo { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ReportDataModelDetail1> ReportDetailList { get; set; } = new List<ReportDataModelDetail1>();
    }

    public class ReportDataModelDetail1
    {
        public string Test1 { get; set; }
        public string Test2 { get; set; }
        public string Test3 { get; set; }
    }
}
