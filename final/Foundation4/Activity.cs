using System;

class Activity {
    private DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes) {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance() {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetSpeed() {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetPace() {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual string GetSummary() {
        return $"{date.ToShortDateString()} - {GetType().Name} ({minutes} min)";
    }
}