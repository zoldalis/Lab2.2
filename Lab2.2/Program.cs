using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class App
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Graph gr = new Graph();
            List<Idlls> dlls = new List<Idlls>();
            dlls.Add(new dll1());
            dlls.Add(new dll2());
            dlls.Add(new dll3());
            dlls.Add(new dll4());
            dlls.Add(new dll5());
            dlls.Add(new dll6());
            double[] nums = new double[10];
            dlls.ForEach(item =>
            {
                try
                {
                    Console.WriteLine($"{item.GetType().Name} : {item.f2()}");
                    for (int i = 0; i < 10; i++)
                    {
                        nums[i] = item.f1((double)i);
                    }
                    gr.Draw(nums, item.GetType().Name);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{item.GetType().Name} : {e.Message}");
                }


            });

            Console.ReadLine();

        }  

        }
}

