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
            Graph gr = new Graph();
            List<Idlls> dlls = new List<Idlls>();
            dlls.Add(new dll1());
            dlls.Add(new dll2());
            dlls.Add(new dll3());
            dlls.Add(new dll4());
            dlls.Add(new dll5());
            dlls.Add(new dll6());
            double[] nums = new double[10];
            foreach (var item in dlls)
            {
                Console.WriteLine("Введите номер функции которую нужно посчитать?: TheFunc(1) ; FuncName(2)");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        nums[i] = item.TheFunc((double)i);
                    }
                    gr.Draw(nums);
                }
                else
                {
                    Console.WriteLine(item.FuncName());
                }
                
            }

            //Graph gr = new Graph();
            //Console.WriteLine("Введите номер функции которую нужно посчитать?: TheFunc(1) ; FuncName(2)");
           // string s = Console.ReadLine();
            //    if (s == "1")
            //    {
            //        try
            //        {
            //            for (int i = 0; i < 10; i++)
            //            {
            //                nums[i] = dll1.TheFunc(i);
            //            }
            //            gr.Draw(nums);
            //        }
            //        catch (Exception)
            //        {
            //            try
            //            {
            //                for (int i = 0; i < 10; i++)
            //                {
            //                    nums[i] = dll2.TheFunc(i);
            //                }
            //                gr.Draw(nums);
            //            }
            //            catch (Exception)
            //            {
            //                try
            //                {
            //                    for (int i = 0; i < 10; i++)
            //                    {
            //                        nums[i] = dll3.TheFunc(i);
            //                    }
            //                    gr.Draw(nums);
            //                }
            //                catch (Exception)
            //                {
            //                    try
            //                    {
            //                        for (int i = 0; i < 10; i++)
            //                        {
            //                            nums[i] = dll4.TheFunc(i);
            //                        }
            //                        gr.Draw(nums);
            //                    }
            //                    catch (Exception)
            //                    {
            //                        try
            //                        {
            //                            for (int i = 0; i < 10; i++)
            //                            {
            //                                nums[i] = dll5.TheFunc(i);
            //                            }
            //                            gr.Draw(nums);
            //                        }
            //                        catch (Exception)
            //                        {
            //                            for (int i = 0; i < 10; i++)
            //                            {
            //                                nums[i] = dll6.TheFunc(i);
            //                            }
            //                            gr.Draw(nums);
            //                            throw;
            //                        }
            //                        throw;
            //                    }
            //                    throw;
            //                }
            //                throw;
            //            }
            //            throw;
            //        }
            //    }
            //    else
            //    {
            //        try
            //        {

            //            Console.WriteLine(dll1.FuncName());
            //            Console.WriteLine("1");
            //        }
            //        catch (Exception)
            //        {
            //            try
            //            {
            //                Console.WriteLine(dll2.FuncName());
            //                Console.WriteLine("2");

            //            }
            //            catch (Exception)
            //            {
            //                try
            //                {
            //                    Console.WriteLine(dll3.FuncName());
            //                    Console.WriteLine("3");

            //                }
            //                catch (Exception)
            //                {
            //                    try
            //                    {
            //                        Console.WriteLine(dll4.FuncName());
            //                        Console.WriteLine("4");

            //                    }
            //                    catch (Exception)
            //                    {
            //                        try
            //                        {
            //                            Console.WriteLine(dll5.FuncName());
            //                            Console.WriteLine("5");

            //                        }
            //                        catch (Exception)
            //                        {
            //                            Console.WriteLine(dll6.FuncName());
            //                            Console.WriteLine("6");

            //                        }
            //                        throw;
            //                    }
            //                    throw;
            //                }
            //                throw;
            //            }
            //            throw;
            //        }
            //    }


        }  

        }
}

