using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Report rep = new ReportRemoteGroup();
            //rep.CreateReport();

            Report rep2 = new ReportRemoteData();
            rep2.CreateReport();


        }
    }

    public class Report
    {
        virtual public void GetData() { Console.WriteLine("Get base data"); }
        virtual public void GroupData() { GetData(); Console.WriteLine("Group data"); }
        virtual public void GenerateReport() { Console.WriteLine("Generate Report"); }

        public void CreateReport()
        {
            GroupData();
            GenerateReport();
        }
    }
    public class ReportRemoteData : Report
    {
        public new void GetData() { Console.WriteLine("Get remote data"); }
        public override void GenerateReport() { Console.WriteLine("Gen remote report"); }
    }
    public class ReportRemoteGroup : ReportRemoteData
    {
        public override void GroupData()
        {
            base.GroupData();
            Console.WriteLine("Remote Group");
        }
    }

}
