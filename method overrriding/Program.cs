using System.Security.Cryptography.X509Certificates;

namespace method_overrriding
{
    
        public class Person 
        {
           public string Name { get; set; }
           public string Surname { get; set; }
           public int Age {get; set; }
           public float Weight { get; set; }
           public float Height { get; set; }
             public override string ToString()
             {
                return Name + " " + Surname + " " + Age + " " + Weight + " " + Height;
             }
        }
       public  class Program
    { 
        public static void Main(string[] args)
        {
          var person = new Person();
            person.Name = "Niyazi";
            person.Surname = "Babayev";
            person.Age = 25;
            person.Weight = 60;
            person.Height = 1.80f;
            Console.WriteLine(person);
        }
    }
}