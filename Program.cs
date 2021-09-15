using System;
using System.IO;

class handson3
{
    public static void Main()
    {
        string fileName = @"mytest.txt";

        try
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write("Create a file in the disk if it is exists");
            using (FileStream fileStr = File.Create(fileName))
            {
                Console.WriteLine("A file created with name mytest.txt");
            }
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}
