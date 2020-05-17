﻿using DecisionMaker.Pages;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecisionMaker
{
    public class Activity
    {
        public string Type { get; set; }
        public List<string> Choices = new List<string>();
        public string ChosenActivity;
        static readonly Random random = new Random();

        // Add Choices
        public void AddChoice(string NewChoice)
        {
            bool isNewMovie = !Choices.Any(choice => choice == NewChoice);
            bool isNotEmpty = !string.IsNullOrWhiteSpace(NewChoice);
            if (isNewMovie & isNotEmpty)
            {
                Choices.Add(NewChoice);
            }
        }


        // Remove Choices
        public void RemoveChoice(string ChoiceToRemove)
        {
            var itemToRemove = Choices.Single(choice => choice == ChoiceToRemove);
            Choices.Remove(itemToRemove);
        }

        // Make a Choice
        public void MakeChoice()
        {
            bool isNotEmpty = Choices.Any();
            
            if (isNotEmpty)
            {
                int index = random.Next(Choices.Count);
                ChosenActivity = Choices[index];
            } else
            {
                ChosenActivity = string.Empty;
            }
        }
    }

    public class Choice2
    {
        public string Name { get; set; }
    }


    public class Activity2
    {
        static readonly Random random = new Random();

        public string Decision;

        public List<Choice2> Items { get; set; } = new List<Choice2>();

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
