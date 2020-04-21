namespace App{
    public interface ITimeProvider{
        DateTime now { get; set; }
        string toTimeOfTheDay();
    }
}