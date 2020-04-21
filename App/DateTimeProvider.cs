public class DateTimeProvider : ITimeProvider {
    public DateTimeProvider now() {
        return DateTime.Hour;
    }

    public string toTimeOfTheDay() {
        if(this.now < 12)
            return "morning";
        else if(this.now > 12 && this.now < 20)
            return "afternoon";
        else
            return "night";
    }
}