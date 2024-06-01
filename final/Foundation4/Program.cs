class Program {
    static void Main(string[] args) {
        var activities = new Activity[] {
            new Running(new DateTime(2024, 06, 01), 30, 3.0),
            new Running(new DateTime(2024, 06, 01), 30, 4.8),
            new StationaryBicycle(new DateTime(2024, 06, 01), 30, 20.0),
            new Swimming(new DateTime(2024, 06, 01), 30, 10)
        };

        foreach (var activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}