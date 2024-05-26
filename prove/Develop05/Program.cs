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
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Example: Create goals
                    Console.WriteLine("Enter goal details:");
                    // Prompt user for goal details and create a new goal
                    break;
                case "2":
                    // List goals
                    goalManager.ShowGoalList();
                    break;
                case "3":
                    // Save goals
                    goalManager.SaveGoals();
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    // Load goals
                    goalManager.LoadGoals();
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    // Example: Record event
                    Console.WriteLine("Enter the index of the goal you achieved:");
                    // Prompt user to select a goal and record an event
                    break;
                case "6":
                    // Quit
                    exitProgram = true;
                    Console.WriteLine("Exiting Eternal Quest. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }

            Console.WriteLine(); // Add a newline for readability
        }
    }
}
