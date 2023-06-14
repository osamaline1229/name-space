using addElements;
using data;
using subject;
using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        student chair = new student();
        chair.work();


        database dat = new database();
        dat.order();

        addition area1 = new addition();
        area1.areaof();
        
    }
}

namespace addElements
{
    class addition
    {
        int area = 0;
        public int areaof(int lenght, int wieght)
        {
            area = lenght * wieght;
            return area;
        }
    }
}