using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Lab2._2
{
    public interface Idlls
    {
        double f1(double x);
        string f2();
    }
    
    public class dll1 : Idlls
    {
        public double f1(double x) {
            return 0;
        }
        public string f2()
        {
            return "";
        }
        [DllImport("Lib.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);

        [DllImport("Lib.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FuncName();
        public dll1()
        {
            
        }
    }
    class dll2 : Idlls
    {
        public double f1(double x)
        {
            return 0;
        }
        public string f2()
        {
            return "";
        }

        [DllImport("Lib2-2-1.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);

        [DllImport("Lib2-2-1.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FuncName();

        public dll2()
        {

        }
    }
    class dll3 : Idlls
    {

        public double f1(double x)
        {
            return 0;
        }
        public string f2()
        {
            return "";
        }
        [DllImport("Lib2-2-2.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);

        [DllImport("Lib2-2-2.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FuncName();

        public dll3()
        {

        }
    }
    class dll4 : Idlls
    {

        public double f1(double x)
        {
            return 0;
        }
        public string f2()
        {
            return "";
        }

        [DllImport("Lib2-2-3.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);

        [DllImport("Lib2-2-3.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FuncName();

        public dll4()
        {

        }
    }
    class dll5 : Idlls
    {

        public double f1(double x)
        {
            return 0;
        }
        public string f2()
        {
            return "";
        }

        [DllImport("Lib2-2-3-1.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);

        [DllImport("Lib2-2-3-1.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FuncName();

        public dll5()
        {

        }
    }
    class dll6 : Idlls
    {

        public double f1(double x)
        {
            return 0;
        }
        public string f2()
        {
            return "";
        }

        [DllImport("Lib2-2-3-2.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);

        [DllImport("Lib2-2-3-2.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FuncName();

        public dll6()
        {

        }

    }
    class Graph
    {


        public Graph()
        {

        }
        public void Draw(double[] nums)
        {
            try
            {
                Application application = new Application();
                application.Visible = true;
                Workbook workbook = application.Workbooks.Add(1);
                Worksheet sheet = (Worksheet)workbook.ActiveSheet;
                int i = 0;
                for (; i < 10; i++)
                {
                    sheet.Cells[i + 1, 1] = i;
                    double f = nums[i];
                    sheet.Cells[i + 1, 2] = f;
                }
                ChartObjects xlCharts = (ChartObjects)sheet.ChartObjects();
                ChartObject myChart = (ChartObject)xlCharts.Add(110, 0, 350, 250);
                Chart chart = myChart.Chart;
                SeriesCollection seriesCollection = (SeriesCollection)chart.SeriesCollection();
                Series series = seriesCollection.NewSeries();
                string A = "A" + Convert.ToString(i + 1);
                string B = "B" + Convert.ToString(i + 1);
                series.XValues = sheet.get_Range("A1", A);
                series.Values = sheet.get_Range("B1", B);
                chart.ChartType = XlChartType.xlXYScatterSmooth;
            }
            catch (Exception e)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write(e.Message);
            }
        }
    }
}
