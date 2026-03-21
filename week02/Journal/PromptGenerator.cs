using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What did I learn today?",
        "What challenged me today?",
        "What am I grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}