using System;
using System.Collections.Generic;
using System.Linq;

namespace aptitude_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("challenge 1----------------------------------");
            Console.WriteLine();

            int[] arr = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            var challengeObj = new Challenges();
            var result = challengeObj.Challenge(arr);
            Console.WriteLine($"biggest number {0}", result);

            Console.WriteLine();
            Console.WriteLine("challenge 2--------------------------------");
            // challenge 2
            while (true)
            {
                var user = new User();
                Console.WriteLine("Please enter the username, or q to exist");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUserCount()}");
            }

            Console.WriteLine();
            Console.WriteLine("challenge 3-----------------------------");
            // challange 3

            // Abstract factory #1
            Humanoid john = new Humanoid(new Dancing());

            Console.WriteLine(john.ShowSkill());
            // Abstract factory #2
 
            Humanoid alex = new Humanoid(new Cooking());

            Console.WriteLine(alex.ShowSkill());
            // no factory
            Humanoid bob = new Humanoid();

            Console.WriteLine(bob.ShowSkill());

            Console.WriteLine();
            Console.WriteLine("challenge 4");

            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk());

            alexa.Configure(x =>
            {
                x.OwnerName = "Bob Merley";
                x.GreetingMessage = $"Hello {x.OwnerName}, I'm at your service.";
            });

            Console.WriteLine(alexa.Talk());


            Console.WriteLine();
            Console.WriteLine("challenge 5-----------------------------");
            // here i am using alexa class for calcuation instead creating new class for simplicity
            var (avarageSalary, numberOfEmplyee) = alexa.CalculateSalary();
            Console.WriteLine("avarage salary : {0}", avarageSalary);

            Console.WriteLine("Number of employees : {0}", numberOfEmplyee);

            Console.WriteLine();
            Console.WriteLine("challenge 6-----------------------------");

            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBolcony();

            var normalHouse = myHouse.Build();
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");
            var luxuryHouse = myHouse.Build();

            Console.WriteLine(normalHouse.Describe());

            Console.WriteLine();
            Console.WriteLine("challenge 7-----------------------------");

            Console.WriteLine("Hello World!");
        }

    }
}
