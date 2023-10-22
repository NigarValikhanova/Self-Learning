using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Lesson_21_02._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Multitasking
            // islemeyen halda proqramdi, run oldusa prosese cevrilir
            // CPU bir neche prosesi eyni anda isledirse bu multitaskingdi
            #endregion

            #region Multithreading
            // bir proqramda bir neche metodu eyni anda isledirse multithreadingdir
            // mesaj yaza yaza mail de gele biler for example
            // shared memory -- proses ve threadin esas ferqi

            //Thread thread = new Thread(TestX);
            //thread.Start();
            //TestY();

            //Thread thread2 = new Thread(TestX);
            //thread2.IsBackground = true; //main threadden asilidi. Main ishini bitiren kimi bitecek
            //thread2.Start();
            //TestY();
            #endregion

            #region ProsesClassi
            //Process process = new Process();
            //process.StartInfo.FileName = "calc.exe";
            //process.Start();

            //var pros = Process.GetCurrentProcess();
            //Console.WriteLine(pros.ToString());// hal hazirda isleyen prosesi gosterir

            //var pros1 = Process.GetProcesses();
            //foreach (var pro in pros1)
            //{
            //    Console.WriteLine(pro.ProcessName);
            //}
            //Console.WriteLine("Axtaris et");
            //string item = Console.ReadLine();
            ////Console.WriteLine(item.Replace(" ", "%20"));
            //WriteGoogle(item.Trim().Replace(" ", "%20"));

            #endregion
        }
        public static void TestX()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i + "XX");
            }
        }
        public static void TestY()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + "Y");
            }
        }
        public static void WriteGoogle(string word) 
        {
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\Chrome.exe", "https://www.google.com/search?q=" + word);
        }
    }
}