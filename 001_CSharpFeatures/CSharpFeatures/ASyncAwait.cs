using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class ASyncAwait
    {
        public static Task<string> Send()
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Send!");
                return "message sent!";
            });
        }


        public static async Task<bool> RunAsync() 
        {
            Console.WriteLine("Start Send");
            var result = await Send();
            Console.WriteLine(result);
            Console.WriteLine("End Send");
            return true;
        }
    }

    partial class Runner 
    {
        public static void RunAsyncAwait()
        {
            Console.WriteLine("-----");
            ASyncAwait.RunAsync();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
