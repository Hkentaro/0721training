using System;

namespace ConsoleApp3
{
    class Program
    {
        // Mainメソッド
        static void Main()
        {
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine($"年齢は{age}歳です");

            string name = "山田";
            Console.WriteLine(name);
            Console.WriteLine($"名前は{name}です");

            int height = 8;
            int width = 5;
            int area = height * width;
            Console.WriteLine($"面積は{area}㎡です");

            Console.WriteLine("おはようこんにちはこんばんは");
            Console.WriteLine("おはよう\nこんにちは\nこんばんは");

            var message = "おはようございます";
            var lengh = message.Length;
            Console.WriteLine(lengh);

            var emptyString = "";
            Console.WriteLine("1行目");
            Console.WriteLine(emptyString);
            Console.WriteLine("3行目");

        }
    }
}
