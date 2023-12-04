using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        int choice;
        do
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                MenuManager.HandleMenuChoice(choice, goalManager);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (choice != 6);
    }
}

class MenuManager
{
    public static void HandleMenuChoice(int choice, GoalManager goalManager)
    {
        switch (choice)
        {
            case 1:
                CreateNewGoal(goalManager);
                break;
            case 2:
                goalManager.DisplayGoals();
                break;
            case 3:
                SaveGoals(goalManager);
                break;
            case 4:
                LoadGoals(goalManager);
                break;
            case 5:
                RecordEvent(goalManager);
                break;
            case 6:
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                break;
        }
    }

    private static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the point value of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            Console.WriteLine("Select the type of goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int goalType))
            {
                switch (goalType)
                {
                    case 1:
                        goalManager.AddGoal(new SimpleGoal(name, value));
                        Console.WriteLine("Simple goal added!");
                        break;
                    case 2:
                        goalManager.AddGoal(new EternalGoal(name, value));
                        Console.WriteLine("Eternal goal added!");
                        break;
                    case 3:
                        Console.Write("Enter the target count for the Checklist Goal: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            goalManager.AddGoal(new ChecklistGoal(name, value, targetCount));
                            Console.WriteLine("Checklist goal added!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for target count. Goal not added.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid goal type. Goal not added.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Goal not added.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for point value. Goal not added.");
        }
    }

    private static void RecordEvent(GoalManager goalManager)
{
    Console.WriteLine("Select a goal to record an event:");

    List<Goal> goals = goalManager.GetGoalsList();

    for (int i = 0; i < goals.Count; i++)
    {
        Console.WriteLine($"{i}. {goals[i].Name}");
    }

    Console.Write("Enter the index of the goal: ");
    if (int.TryParse(Console.ReadLine(), out int goalIndex))
    {
        goalManager.RecordEvent(goalIndex);
    }
    else
    {
        Console.WriteLine("Invalid input for goal index. Event not recorded.");
    }
}




    private static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();
        goalManager.SaveGoals(fileName);
    }

    private static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine();
        goalManager.LoadGoals(fileName);
    }
}


