using System;

// 本程序的命名空间
namespace _1_1_Hello
{
    class Program
    {
        // main函数
        static void Main(string[] args)
        {
            Console.Write("Hello World~");
            Console.Write("ReadKey结束");  // 字符串 string
            Console.WriteLine("BBB");
            Console.Write("CCC");

            Console.WriteLine(234);     // 整数 int
            Console.WriteLine(3.1415);  // 浮点数 double 
            Console.WriteLine(3.1415f); // 浮点数 float

            Console.ReadLine(); // 读取输入一行字符串，以换行键结束
            Console.WriteLine("a"); // 单引号代表的是一个字符

            Console.WriteLine("Hello" + 888);
            Console.WriteLine("1" + 1);

            Console.WriteLine(333 * 256 + 7);

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine("Hello World!");

            Console.ReadKey(); // 等待键盘输入一个按键，程序会卡在这一步不走

            Console.WriteLine("ReadKey结束");

            Console.ReadKey();

            Console.WriteLine("Readkey 2 结束");

            Console.WriteLine(Console.ReadLine());
            // Console.WriteLine(Console.WriteLine()); WriteLine返回类型为void，不返回任何内容
            Console.WriteLine(Console.ReadKey()); // 返回的内容是很奇怪的内容
            Console.ReadKey();
        }
    }
}
