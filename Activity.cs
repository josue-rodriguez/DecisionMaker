using DecisionMaker.Pages;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecisionMaker
{
    public class Choice
    {
        public string Name { get; set; }
    }


    public class Activity
    {
        static readonly Random random = new Random();

        public string Decision;

        public List<Choice> Items { get; set; } = new List<Choice>();

        //Make a decision
        public void MakeDecision()
        {
            bool isNotEmpty = Items.Any();
            if (isNotEmpty)
            {
                int index = random.Next(Items.Count);
                Decision = Items[index].Name;
            } else
            {
                Decision = string.Empty;
            }
        }
    }
}
