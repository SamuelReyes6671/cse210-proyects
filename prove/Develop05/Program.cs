class Program
{
    static void Main(string[] args)
    {
        // Inicializar GoalManager
        GoalManager goalManager = new GoalManager();

        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Menú de Eternal Quest:");
            Console.WriteLine("1. Crear nueva meta");
            Console.WriteLine("2. Listar metas");
            Console.WriteLine("3. Guardar metas");
            Console.WriteLine("4. Cargar metas");
            Console.WriteLine("5. Registrar evento");
            Console.WriteLine("6. Salir");

            Console.Write("Ingresa tu elección: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ingresa los detalles de la meta:");
                    Console.Write("Nombre corto: ");
                    string shortName = Console.ReadLine();
                    Console.Write("Descripción: ");
                    string description = Console.ReadLine();
                    goalManager.CreateGoal(new SimpleGoal(shortName, description, 10));
                    Console.WriteLine("Meta creada exitosamente.");
                    break;
                case "2":
                    if (goalManager.Goals.Count > 0)
                    {
                        goalManager.ShowGoalList();
                    }
                    else
                    {
                        Console.WriteLine("No hay metas para mostrar. Crea nuevas metas primero.");
                    }
                    break;
                case "3":
                    Console.Write("Ingresa el nombre de archivo para guardar las metas (por ejemplo, metas.txt): ");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveGoals(saveFileName);
                    Console.WriteLine("Metas guardadas exitosamente.");
                    break;
                case "4":
                    Console.Write("Ingresa el nombre de archivo para cargar las metas desde (por ejemplo, metas.txt): ");
                    string loadFileName = Console.ReadLine();
                    goalManager.LoadGoals(loadFileName);
                    Console.WriteLine("Metas cargadas exitosamente.");
                    break;
                case "5":
                    if (goalManager.Goals.Count > 0)
                    {
                        Console.WriteLine("Selecciona una meta para registrar un evento:");
                        goalManager.ShowGoalList();
                        Console.Write("Ingresa el índice de la meta: ");
                        if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 0 && selectedIndex < goalManager.Goals.Count)
                        {
                            goalManager.RecordEvent(selectedIndex);
                            Console.WriteLine("Evento registrado exitosamente para la meta seleccionada.");
                        }
                        else
                        {
                            Console.WriteLine("Índice de meta no válido. Por favor, ingresa un índice válido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay metas disponibles para registrar un evento. Crea nuevas metas primero.");
                    }
                    break;
                case "6":
                    exitProgram = true;
                    Console.WriteLine("Saliendo de Eternal Quest. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingresa un número entre 1 y 6.");
                    break;
            }

            Console.WriteLine(); // Agregar una nueva línea para mayor legibilidad
        }
    }
}
