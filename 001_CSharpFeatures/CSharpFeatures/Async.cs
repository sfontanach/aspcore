using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class Async
    {
        public static void Send(Action<string> onSucceed)
        {
            Task.Run(() => { 
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Send!");
                onSucceed("Message sent!");
            });
        }

        public static void RunAsync(Action<bool> onSucceed) 
        {
            Console.WriteLine("Start Send");
            Send(x => {
                Console.WriteLine(x);
                Console.WriteLine("End Send");
                onSucceed(true);
            });
        }
    }

    partial class Runner 
    {
        public static void RunAsync() 
        {
            Console.WriteLine("----");    
            Async.RunAsync(x => {});
            Console.WriteLine("------");
            Console.ReadLine();
        }
    }
}
