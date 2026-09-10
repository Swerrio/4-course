using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMultitaskingApplication
{
    class Program
    {
        private static void printMessage()
        {
            Console.WriteLine("Hello world!");
        }

        private static string printMessage(string message)
        {
            return message.ToUpper();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Четыре способа создания задач ---");

            Task task1 = new Task(new Action(printMessage));
            Task task2 = new Task(delegate { Console.WriteLine("Hello world!"); });
            Task task3 = new Task(() => printMessage());
            Task task4 = new Task(() => { Console.WriteLine("Hello world!"); });

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();

            Task.WaitAll(task1, task2, task3, task4);

            Console.WriteLine("--- Задача, возвращающая результат ---");

            Task<string> message = new Task<string>(mes => printMessage((string)mes), "hello world");
            message.Start();
            Console.WriteLine("Сообщение: " + message.Result);

            Console.WriteLine("--- Продолжение задачи ContinueWith ---");

            Task<string> message2 = new Task<string>(mes => printMessage((string)mes), "hello world");
            message2.Start();
            Task cwt = message2.ContinueWith(task => Console.WriteLine("Сообщение: " + task.Result));
            cwt.Wait();

            Console.WriteLine("--- Дочерние задачи AttachedToParent ---");

            Task<string[]> message3 = new Task<string[]>(() =>
            {
                var result = new string[3];
                new Task(() => result[0] = printMessage("Hello"), TaskCreationOptions.AttachedToParent).Start();
                new Task(() => result[1] = printMessage("World"), TaskCreationOptions.AttachedToParent).Start();
                new Task(() => result[2] = printMessage("Hello world!"), TaskCreationOptions.AttachedToParent).Start();
                return result;
            });

            var cwt3 = message3.ContinueWith(mes => Array.ForEach(mes.Result, Console.WriteLine));
            message3.Start();
            cwt3.Wait();

            Console.WriteLine("Главный метод завершен.");
            Console.ReadLine();
        }
    }
}
