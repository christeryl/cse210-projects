using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].Value;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public List<Goal> GetGoalsList()
    {
        return goals;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            string status = goals[i].IsCompleted ? "[X]" : "[ ]";
            if (goals[i] is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{status} {goals[i].Name} - {checklistGoal.GetProgress()}");
            }
            else
            {
                Console.WriteLine($"{status} {goals[i].Name}");
            }
        }
        Console.WriteLine($"Total Score: {totalScore} points");
    }

    public void SaveGoals(string fileName)
    {
        string json = JsonSerializer.Serialize(goals, new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new GoalConverter() }
        });

        File.WriteAllText(fileName, json);
        Console.WriteLine($"Goals saved to {fileName}.");
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            goals = JsonSerializer.Deserialize<List<Goal>>(json, new JsonSerializerOptions
            {
                Converters = { new GoalConverter() }
            });

            Console.WriteLine($"Goals loaded from {fileName}.");
        }
        else
        {
            Console.WriteLine($"File {fileName} not found. No goals loaded.");
        }
    }

    // Custom converter to handle Goal deserialization
    private class GoalConverter : JsonConverter<Goal>
    {
        public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;

                if (root.TryGetProperty("$type", out var typeProperty))
                {
                    var typeName = typeProperty.GetString();
                    if (typeName == typeof(SimpleGoal).FullName)
                    {
                        return JsonSerializer.Deserialize<SimpleGoal>(root.GetRawText());
                    }
                    else if (typeName == typeof(EternalGoal).FullName)
                    {
                        return JsonSerializer.Deserialize<EternalGoal>(root.GetRawText());
                    }
                    else if (typeName == typeof(ChecklistGoal).FullName)
                    {
                        return JsonSerializer.Deserialize<ChecklistGoal>(root.GetRawText());
                    }
                }

                throw new JsonException("Unable to determine the type of the Goal.");
            }
        }

        public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
