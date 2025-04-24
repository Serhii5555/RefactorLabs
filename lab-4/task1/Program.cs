using System;
using System.Text;

namespace SupportChain
{
    abstract class SupportHandler
    {
        protected SupportHandler next;

        public void SetNext(SupportHandler next)
        {
            this.next = next;
        }

        public abstract bool HandleRequest(string issue);
    }

    class Level1Support : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            Console.WriteLine("Чи проблема пов'язана з SIM-картою? (так/ні)");
            var input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("Рівень 1 підтримки: SIM-карта. Проблема вирішується.");
                return true;
            }
            else
            {
                return next?.HandleRequest(issue) ?? false;
            }
        }
    }

    class Level2Support : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            Console.WriteLine("Чи проблема пов'язана з інтернетом? (так/ні)");
            var input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("Рівень 2 підтримки: Інтернет. Проблема вирішується.");
                return true;
            }
            else
            {
                return next?.HandleRequest(issue) ?? false;
            }
        }
    }

    class Level3Support : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            Console.WriteLine("Чи проблема з оплатою? (так/ні)");
            var input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("Рівень 3 підтримки: Оплата. Проблема вирішується.");
                return true;
            }
            else
            {
                return next?.HandleRequest(issue) ?? false;
            }
        }
    }

    class Level4Support : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            Console.WriteLine("Чи проблема технічна і вимагає глибокого аналізу? (так/ні)");
            var input = Console.ReadLine()?.ToLower();

            if (input == "так")
            {
                Console.WriteLine("Рівень 4 підтримки: Технічна команда. Проблема вирішується.");
                return true;
            }
            else
            {
                Console.WriteLine("Не знайдено відповідного рівня підтримки.");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SupportHandler level1 = new Level1Support();
            SupportHandler level2 = new Level2Support();
            SupportHandler level3 = new Level3Support();
            SupportHandler level4 = new Level4Support();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(level4);

            bool resolved = false;

            while (!resolved)
            {
                Console.WriteLine("\nВітаємо у службі підтримки. Відповідайте на питання:");
                resolved = level1.HandleRequest("питання користувача");

                if (!resolved)
                {
                    Console.WriteLine("Спробуйте ще раз.\n");
                }
            }

            Console.WriteLine("Дякуємо, що звернулись до служби підтримки!");
        }
    }
}
