using System;
using System.Dynamic;
namespace CSharpFeatures
{
    public class DynamicObject
    {
        public static dynamic CreateUser(string name)
        {
            dynamic person = new ExpandoObject();
			person.SayHi = new Action(() => Console.WriteLine(person.Name));
            person.Name = "Michael";
            return person;

		}
    }

    partial class Runner 
    {
        public static void RunDynamicObject() 
        {
            dynamic person = DynamicObject.CreateUser("Michael");
            person.SayHi();
			person.GivenName = "Gfeller";
			person.SayHi = new Action(() => Console.WriteLine(person.Name + " " + person.GivenName));
			person.SayHi();
			Console.ReadLine();
        }
    }
}
