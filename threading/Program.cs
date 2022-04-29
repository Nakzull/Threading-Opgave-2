using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program
{
    public void WorkThreadFunction()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("C#-trådning er nemt!");
            Thread.Sleep(1000);
        }
    }
    public void WorkThreadFucktion2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Også med flere tråde...");
            Thread.Sleep(1000);
        }
    }

}
class threprog
{
    public static void Main()
    {
        program pg = new program();
        Thread t1 = new Thread(new ThreadStart(pg.WorkThreadFunction));
        t1.Start();

        Thread t2 = new Thread(new ThreadStart(pg.WorkThreadFucktion2));
        t2.Start();
        t2.Join();
    }
}