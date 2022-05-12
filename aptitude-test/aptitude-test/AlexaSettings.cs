using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptitude_test
{
    public class Alexa
    {
        public Alexa()
        {
            GreetingMessage = "Hello, i am Alexa";
        }
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }
        public string Talk()
        {
            return $"{GreetingMessage}";
        }

        public (double, int) CalculateSalary()
        {
            // some calculation , i will just return hardcoded values
            return (123,19);
        }

    }

    public static class AlexaExtension
    {
        public static Alexa Configure(this Alexa alexa, Action<Alexa> action)
        {
            action.Invoke(alexa);
            return alexa;
        }
    }
}
