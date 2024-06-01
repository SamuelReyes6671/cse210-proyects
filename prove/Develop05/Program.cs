class Program
{
    static void Main(string[] args)
    {
        // Initialize GoalManager
        GoalManager goalManager = new GoalManager();

        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Eternal Quest Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter goal details:");
                    Console.Write("Short name: ");
                    string shortName = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();
                    goalManager.CreateGoal(new SimpleGoal(shortName, description, 10));
                    Console.WriteLine("Goal created successfully.");
                    break;
                case "2":
                    if (goalManager.Goals.Count > 0)
                    {
                        goalManager.ShowGoalList();
                    }
                    else
                    {
                        Console.WriteLine("No goals to display. Create new goals first.");
                    }
                    break;
                case "3":
                    Console.Write("Enter file name to save goals to (e.g., goals.txt): ");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveGoals(saveFileName);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    Console.Write("Enter file name to load goals from (e.g., goals.txt): ");
                    string loadFileName = Console.ReadLine();
                    goalManager.LoadGoals(loadFileName);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    if (goalManager.Goals.Count > 0)
                    {
                        Console.WriteLine("Select a goal to record an event:");
                        goalManager.ShowGoalList();
                        Console.Write("Enter goal index: ");
                        if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 0 && selectedIndex < goalManager.Goals.Count)
                        {
                            goalManager.RecordEvent(selectedIndex);
                            Console.WriteLine("Event recorded successfully for the selected goal.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid goal index. Please enter a valid index.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No goals available to record an event. Create new goals first.");
                    }
                    break;
                case "6":
                    exitProgram = true;
                    Console.WriteLine("Exiting Eternal Quest. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                    break;
            }

            Console.WriteLine(); // Add a new line for readability
        }
    }
}
