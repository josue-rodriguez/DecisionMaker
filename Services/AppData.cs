using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecisionMaker.Services
{
    public class AppData
    {
        public int Age { get; set; }
    }

    public class Activity
    {
        static readonly Random random = new Random();

        public string Decision { get; set; }
        public int Number { get; set; }
        public List<Choice> Items { get; set; } = new List<Choice>();

        //Make a decision
        public void MakeDecision()
        {
            bool isNotEmpty = Items.Any();
            if (isNotEmpty)
            {
                int index = random.Next(Items.Count);
                Decision = Items[index].Name;
            }
            else
            {
                Decision = string.Empty;
            }
        }
    }
}
