class Swimming : Activity {
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes) {
        this.laps = laps;
    }

    public override double GetDistance() {
        return laps * 50.0 / 1000; // Distance in kilometers
    }

    public override double GetSpeed() {
        return GetDistance() / (minutes / 60.0);
    }

    public override double GetPace() {
        return minutes / GetDistance();
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}