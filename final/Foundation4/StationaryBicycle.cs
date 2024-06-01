class StationaryBicycle : Activity {
    private double speed; // in mph

    public StationaryBicycle(DateTime date, int minutes, double speed) : base(date, minutes) {
        this.speed = speed;
    }

    public override double GetSpeed() {
        return speed;
    }

    public override double GetPace() {
        return 60.0 / speed;
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} - Speed: {speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}