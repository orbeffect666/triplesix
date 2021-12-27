using System;
using System.IO;
namespace Lab3sem
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[10];
            FileStream fs = new FileStream("FileStreamTest.txt",
            FileMode.OpenOrCreate);
            if (fs.Length == 0)
            {
                Console.WriteLine("Writing Data...");
                for (short i = 0; i < 10; i++)
                    data[i] = (byte)i;
                fs.Write(data, 0, 10); // Запись данных
            }
            else
            {
                fs.Seek(-5, SeekOrigin.End); // Ищем конец
                int count = fs.Read(data, 0, 10); // Чтение данных
                for (int i = 0; i < count; i++) Console.WriteLine(data[i]);
            }
            fs.Close();
        }
    }
}
