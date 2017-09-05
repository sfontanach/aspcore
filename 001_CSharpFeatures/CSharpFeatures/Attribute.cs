using System;
namespace CSharpFeatures
{
    public class SomeAttribute: System.Attribute
    {
        public string Name { get; set; }
        public SomeAttribute(string name)
        {
            this.Name = name;
        }
    }

    [Some("Michael")]
    public class Demo
    {
        
    }

    partial class Runner
    {
        public static void RunAttribute()
        {
            var demo = new Demo();
            Console.WriteLine(demo.GetType().GetType());
            Console.ReadLine();
        }
    }
}
